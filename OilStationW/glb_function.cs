using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Globalization;

class glb_function
     {


    //when program statr
    internal static string glb_strUserId = "";
    internal static string glb_strUserName = "";
    internal static string glb_strBranchPkid = "";

    internal static bool blMsg;
    internal static string glb_iMainCurrId;
    internal static int glb_iMainCurrDecimal;

   

    //internal static string strRoot = @"f:\erth\";
    internal static string strRoot = "";
  // internal static string strDataSource = "localhost:1521/orclw";
  internal static string strDataSource = "192.168.0.3:1521/orclw";
   // internal static string strDataSource = "192.168.20.50:1521/orclw";





    internal void clearItems(Control myControl)
    {

        try
        {
            foreach (Control ctrl in myControl.Controls)
            {




                if (ctrl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctrl).Text = "";

                }
                else if (ctrl.GetType() == typeof(myText))
                {
                    ((myText)ctrl).Text = "";

                }
                else if (ctrl.GetType() == typeof(NumericUpDown))
                {
                    if (((NumericUpDown)ctrl).Minimum >= 0)
                        ((NumericUpDown)ctrl).Value = ((NumericUpDown)ctrl).Minimum;
                    else
                        ((NumericUpDown)ctrl).Value = 0;

                }
                else if (ctrl.GetType() == typeof(myNumber))
                {
                    if (((myNumber)ctrl).Minimum >= 0)
                        ((myNumber)ctrl).Value = ((myNumber)ctrl).Minimum;
                    else
                        ((myNumber)ctrl).Value = 0;
                }

                else if (ctrl.GetType() == typeof(myList))
                {
                    ((myList)ctrl).SelectedIndex = -1;
                    ((myList)ctrl).Text = "";

                }
                else if (ctrl.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                    ((ComboBox)ctrl).Text = "";

                }
                else if (ctrl.GetType() == typeof(myDate))
                {
                    ((myDate)ctrl).Value = DateTime.Now;

                }
                else if (ctrl.GetType() == typeof(DateTimePicker))
                {
                    ((DateTimePicker)ctrl).Value = DateTime.Now;

                }
                else if (ctrl.GetType() == typeof(MaskedTextBox))
                {
                    ((MaskedTextBox)ctrl).Text = "";
                }
                else if (ctrl.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)ctrl).Checked = false;
                }
                else if (ctrl.GetType() == typeof(DataGridView))
                {
                    if (((DataGridView)ctrl) != null)
                    {
                      
                            ((DataGridView)ctrl).Rows.Clear();
                       
                    }
                }
                else if (ctrl.GetType() == typeof(myDataGrid))
                {
                    if (((myDataGrid)ctrl) != null)
                    {
                       
                            ((myDataGrid)ctrl).Rows.Clear();
                        
                    }
                }
                else if (ctrl.GetType() == typeof(PictureBox))
                {
                    if (((PictureBox)ctrl).Tag == null || ((PictureBox)ctrl).Tag.ToString() == "")

                        ((PictureBox)ctrl).Image = null;
                }
                else
                    clearItems(ctrl);


            }


        }// main foreach


        catch (Exception ex)
        {
           
            MessageBox.Show(ex.ToString());
        }
    }//end clearItems

      

        public static void MsgBox(string strMsg)
          {

        OilStationW.frmMsg frm = new OilStationW.frmMsg();
              frm.lblMsg.Text  = strMsg;
              frm.Text = "Massage";
              frm.btnOk.Visible = true;
              frm.ShowDialog();
              frm.Dispose();

          }
        public static void MsgBox(string strMsg, string strTitle)
          {
        OilStationW.frmMsg frm = new OilStationW.frmMsg();
              frm.lblMsg.Text = strMsg;
              frm.Text = strTitle;
              frm.btnOk.Visible = true;
              frm.ShowDialog();
              frm.Dispose();

          }

        public static bool MsgBox(string strMsg, string strTitle, bool blDialog)
          {
        OilStationW.frmMsg frm = new OilStationW. frmMsg();
              frm.lblMsg.Text = strMsg;
              frm.Text = strTitle;
              frm.btnYes.Visible = true;
              frm.btnNO.Visible = true;
              frm.ShowDialog();
              frm.Dispose();

              return blMsg ;

          }

    public static string Encrypt(string toEncrypt, bool useHashing)
    {
        byte[] keyArray;
        byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

        AppSettingsReader settingsReader = new AppSettingsReader();



        string key = "Hashpassword98549642";


        if (useHashing)
        {

            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();
        }
        else
            keyArray = UTF8Encoding.UTF8.GetBytes(key);

        TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

        tdes.Key = keyArray;

        tdes.Mode = CipherMode.ECB;


        tdes.Padding = PaddingMode.PKCS7;

        ICryptoTransform cTransform = tdes.CreateEncryptor();

        byte[] resultArray =
          cTransform.TransformFinalBlock(toEncryptArray, 0,
          toEncryptArray.Length);

        tdes.Clear();
        return Convert.ToBase64String(resultArray, 0, resultArray.Length);
    }
    public static string Decrypt(string cipherString, bool useHashing)
    {
        byte[] keyArray;
        //get the byte code of the string

        byte[] toEncryptArray = Convert.FromBase64String(cipherString);

        System.Configuration.AppSettingsReader settingsReader =
                                            new AppSettingsReader();
        //Get your key from config file to open the lock!
        //string key = (string)settingsReader.GetValue("SecurityKey",   typeof(String));
        string key = "Hashpassword98549642";

        if (useHashing)
        {
            //if hashing was used get the hash code with regards to your key
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            //release any resource held by the MD5CryptoServiceProvider

            hashmd5.Clear();
        }
        else
        {
            //if hashing was not implemented get the byte code of the key
            keyArray = UTF8Encoding.UTF8.GetBytes(key);
        }

        TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        //set the secret key for the tripleDES algorithm
        tdes.Key = keyArray;
        //mode of operation. there are other 4 modes. 
        //We choose ECB(Electronic code Book)

        tdes.Mode = CipherMode.ECB;
        //padding mode(if any extra byte added)
        tdes.Padding = PaddingMode.PKCS7;

        ICryptoTransform cTransform = tdes.CreateDecryptor();
        byte[] resultArray = cTransform.TransformFinalBlock(
                             toEncryptArray, 0, toEncryptArray.Length);
        //Release resources held by TripleDes Encryptor                
        tdes.Clear();
        //return the Clear decrypted TEXT
        return UTF8Encoding.UTF8.GetString(resultArray);
    }
    public static bool IsSoftwareInstalled(string softwareName)
    {
        var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall") ??
              Registry.LocalMachine.OpenSubKey(
                  @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall");

        if (key == null)
            return false;

        return key.GetSubKeyNames()
            .Select(keyName => key.OpenSubKey(keyName))
            .Select(subkey => subkey.GetValue("DisplayName") as string)
            .Any(displayName => displayName != null && displayName.Contains(softwareName));
    }

    static public string Hijri_To_Gregorian(string hijriDate)
    {
        // CultureInfo arCI = new CultureInfo("ar-SA");
        // string hijri = hijriDate;
        //// System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-SA");
        // DateTime tempDate = DateTime.ParseExact(hijri, "dd/MM/yyyy", arCI.DateTimeFormat, DateTimeStyles.AllowInnerWhite);
        //return  tempDate.ToString("yyyyMMdd");



        //string[] allFormats ={"yyyy/MM/dd","yyyy/M/d",
        //    "dd/MM/yyyy","d/M/yyyy",
        //    "dd/M/yyyy","d/MM/yyyy","yyyy-MM-dd",
        //    "yyyy-M-d","dd-MM-yyyy","d-M-yyyy",
        //    "dd-M-yyyy","d-MM-yyyy","yyyy MM dd",
        //    "yyyy M d","dd MM yyyy","d M yyyy",
        //    "dd M yyyy","d MM yyyy"};
        string[] allFormats = { "dd/MM/yyyy" };
        CultureInfo arCul;
        CultureInfo enCul;
        arCul = new CultureInfo("ar-SA");
        enCul = new CultureInfo("en-US");

        
        DateTime tempDate = DateTime.ParseExact(hijriDate, allFormats, arCul.DateTimeFormat, DateTimeStyles.RoundtripKind);
        return tempDate.ToString("dd/MM/yyyy", enCul.DateTimeFormat);


    }

    public static string Gregorian_To_Hijri(string strDate)
    {
        //DateTimeFormatInfo DTFormat;
        //DateTime DateConv=new DateTime();


        //DateConv =Convert.ToDateTime( strDate);
        ///// We can't have the hijri date writen in English. We will get a runtime error





        ///// Set the date time format to the given culture
        //    DTFormat = new System.Globalization.CultureInfo("ar-sa", false).DateTimeFormat;

        ///// Set the calendar property of the date time format to the given calendar
        //DTFormat.Calendar = new System.Globalization.HijriCalendar();

        ///// We format the date structure to whatever we want
        //DTFormat.ShortDatePattern = "yyyyMMdd";
        ////return (DateConv.Date.ToString("f", DTFormat));
        ////return DateConv.Date.ToString("dd/MM/yyyy",DTFormat );

        //return DateConv.Date.ToString("yyyyMMdd", DTFormat);

        //string[] allFormats ={"yyyy/MM/dd","yyyy/M/d",
        //    "dd/MM/yyyy","d/M/yyyy",
        //    "dd/M/yyyy","d/MM/yyyy","yyyy-MM-dd",
        //    "yyyy-M-d","dd-MM-yyyy","d-M-yyyy",
        //    "dd-M-yyyy","d-MM-yyyy","yyyy MM dd",
        //    "yyyy M d","dd MM yyyy","d M yyyy",
        //    "dd M yyyy","d MM yyyy"};
        string[] allFormats = { "dd/MM/yyyy" };
        CultureInfo arCul;
        CultureInfo enCul;
        arCul = new CultureInfo("ar-SA");
        enCul = new CultureInfo("en-US");
        DateTime tempDate = new DateTime();
     
        tempDate=DateTime.ParseExact(strDate, allFormats, enCul.DateTimeFormat, DateTimeStyles.AllowWhiteSpaces);
        return tempDate.ToString("dd/MM/yyyy", arCul.DateTimeFormat);
    }

    public static bool UpdateHistory(string strTableName, string strColName, string strPkid, string strOldValue, string strNewValue, string strColArName)
    {
        ConnectionToMySQL cnn = new ConnectionToMySQL();
        int icheck = 0;
        // insert into USER_TEMPLET values((select ifnull(max(b.pkid),0)+1 from USER_TEMPLET b),

        icheck = cnn.TranDataToDB("insert into updatehistory values((select ifnull(max(b.pk),0)+1 from updatehistory b)," + glb_function.glb_strUserId + ",sysdate(),'" + strTableName + "','" + strColName + "'," + strPkid + ",'" + strOldValue + "','" + strNewValue + "','" + strColArName + "')");

        if (icheck <= 0)
            return false;


        // cnn.glb_commitTransaction();
        return true;

    }
    public static double GetQty(string strItemId, string strWarehouseId)
    {
        ConnectionToMySQL cnn = new ConnectionToMySQL();
        DataTable dtQty = cnn.GetDataTable("select ifnull(sum(qty) ,0) from item_trans where item_id=" + strItemId + " and warehouse_id=" + strWarehouseId);

        double dQty = Convert.ToDouble(dtQty.Rows[0][0].ToString());
        return dQty;
    }

}


