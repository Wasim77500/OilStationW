using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WIA;

namespace OilStationW.Purchases
{
    public partial class frmPurchaseDocuments : OilStationW.myForm
    {
        private byte[] ReturnedImageByte;
        public string strHeader_id = "1";
        public frmPurchaseDocuments()
        {
            InitializeComponent();
        }

        private void myGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmPurchaseDocuments_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            EnterImage();
        }
        private void EnterImage()
        {

            if (rbScanner.Checked)
            {
                ReturnedImageByte = GetImageFromScanner();


            }
            else
            {
                ReturnedImageByte = GetImageFromFile();
            }

            if (ReturnedImageByte != null)
            {
                pictureBox3.Image = Image.FromStream(new MemoryStream(ReturnedImageByte));
            }
            else
                pictureBox3.Image = null;
        }
        private byte[] GetImageFromFile()
        {
            byte[] MyImageByte = null;
            OpenFileDialog MyOpenFileDialog = new OpenFileDialog();
            MyOpenFileDialog.Title = "فتح ملف صور";
            MyOpenFileDialog.Multiselect = false;
            MyOpenFileDialog.Filter = "Image Files|*.jpg";
            MyOpenFileDialog.FilterIndex = 1;
            MyOpenFileDialog.ShowDialog(this);
            try
            {
                string ImageFileNam = MyOpenFileDialog.FileName;
                if (ImageFileNam != "")
                {
                    long ImageFileSize = (new FileInfo(ImageFileNam).Length);
                    if (ImageFileSize <= (1048576 * 5))
                    {
                        FileStream MyImageFile = new FileStream(ImageFileNam, FileMode.Open, FileAccess.Read);
                        MyImageByte = (new BinaryReader(MyImageFile).ReadBytes((int)ImageFileSize));


                    }
                    else
                    {
                        throw (new Exception("حجم الملف المحدد أكبر من الحجم المسموح به الحجم المسموح خمسه ميجا فقط"));
                    }
                }
                else
                {
                    throw (new Exception("لم يتم تحديد الملف المراد حفظه"));
                }
            }
            catch (Exception Err)
            {
                glb_function.MsgBox(Err.Source + " : " + Err.Message);
            }
            return MyImageByte;
        }
        private byte[] GetImageFromScanner()
        {
            byte[] MyImageByte = null;
            try
            {
                const string wiaFormatJPEG = "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}";
                CommonDialogClass wiaDiag = new CommonDialogClass();

                ImageFile wiaImage = null;
                wiaImage = wiaDiag.ShowAcquireImage(WiaDeviceType.ScannerDeviceType, WiaImageIntent.ColorIntent, WiaImageBias.MinimizeSize, wiaFormatJPEG, true, true, false);
                if (wiaImage == null)
                    return null;

                Vector vect = wiaImage.FileData;
                MyImageByte = (byte[])vect.get_BinaryData();


            }
            catch (Exception err)
            {
                if (err.Message.IndexOf("0x80210015") != -1)
                {
                    glb_function.MsgBox("لم يتم التعرف على أي ماسحة ضوئية");
                }
                else
                {
                    glb_function.MsgBox(err.Message);
                }
            }
            return MyImageByte;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ImageConverter converter = new ImageConverter();
            PictureBox pbHelper = new PictureBox();
            byte[] rowData;
            if (pictureBox3.Image != null)
            {

                pbHelper.Image = pictureBox3.Image;
                pbHelper.Image.Save("DecresResolution.png", System.Drawing.Imaging.ImageFormat.Png);
                pbHelper.Load("DecresResolution.png");

                pbHelper.Image.Save("DecresResolution.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                pbHelper.Load("DecresResolution.jpg");


                rowData = (byte[])converter.ConvertTo(pbHelper.Image, typeof(byte[]));


            }
            else
            {

                rowData = null;
            }


            ConnectionToMySQL cnn = new ConnectionToMySQL();
            MySqlParameter paraImage = new MySqlParameter();

            paraImage.MySqlDbType = MySqlDbType.Blob;
            paraImage.Direction = System.Data.ParameterDirection.Input;
            paraImage.Value = rowData;
            paraImage.ParameterName = "P_image";



            string strStat = "insert into pi_documents values((select ifnull(max(b.pkid),0)+1 from pi_documents b)" +
                ",'فعال'" +
                ",sysdate()" +
                "," + glb_function.glb_strUserId +
                "," + strHeader_id +
                 ",'" + txtImgDescription.Text.Trim() + "'" +
                 ",@P_image" +
                ")";

            int icheck = cnn.InsertDataWithBlob(strStat, paraImage, null, null);
            if (icheck <= 0)
            {
                glb_function.MsgBox("حدث خطأ اثناء ادخال المستند");
                return;
            }
            cnn.glb_commitTransaction();

            pbHelper.Dispose();
            pbHelper = null;
            txtImgDescription.Text = "";
            pictureBox3.Image = null;
            
            GetData();
        }
        private void GetData()
        {
            dgvDocumnets.Rows.Clear();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtDoc = cnn.GetDataTable("SELECT pkid,doc_name,Image_doc FROM pi_documents where header_id=" + strHeader_id);
           
            for (int i = 0; i < dtDoc.Rows.Count; i++)
            {
                dgvDocumnets.Rows.Add();
                dgvDocumnets[clmPKid.Index,i].Value = dtDoc.Rows[i]["pkid"].ToString();
                dgvDocumnets[clmImageDescription.Index, i].Value = dtDoc.Rows[i]["doc_name"].ToString();
                var data = (Byte[])(dtDoc.Rows[i]["Image_doc"]);
                var stream = new MemoryStream(data);
                dgvDocumnets[clmImage.Index, dgvDocumnets.Rows.Count - 1].Value = Image.FromStream(stream);

            }


        }

        private void dgvDocumnets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

           
            if (e.ColumnIndex == clmShowImage.Index)
            {
                Image img = dgvDocumnets[clmImage.Index, e.RowIndex].Value as Image;
                string strFilePath = @"1.jpg";

                img.Save(strFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = strFilePath;
                p.StartInfo.Verb = "Open";
                p.Start();

            }
        }
    }
}
