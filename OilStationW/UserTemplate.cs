using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilStationW
{
    class UserTemplate
    {
       static public DataTable  dtPri;

        
        string strTempletId = "";
        Form frm = new Form();
        public void GetPrivForThisForm(Form CurrForm)
        {

           
            frm = CurrForm;
            //if(this.PriviFile==  glb_function.ProgramType.none )
            //          return;
            if (glb_function.glb_strUserName == "وسيم الأغبري")
                return;
            if (glb_function.glb_strUserName == "")
            {
                glb_function.MsgBox("لا يوجد اسم مستخدم");
                frm.Close();
            }


            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtTemplete = cnn.GetDataTable("select u.templet_id,h.templet_name from  templet_header h,user_templet u " +
                        " where h.pkid = u.templet_id " +
                        " and h.form_eng_name = '" + frm.Tag.ToString() + "' and u.user_id=" + glb_function.glb_strUserId);

            if (dtTemplete == null || dtTemplete.Rows.Count <= 0)
            {
                glb_function.MsgBox("لا توجد صلاحيات لهذه الشاشة");
               frm.Close();
                return;
            }


            strTempletId = dtTemplete.Rows[0]["templet_id"].ToString();
            lstTemplet_SelectedIndexChanged(null, null);




        }
        private void lstTemplet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lstTemplet.SelectedValue == null)
            //    return;

            // if (lstTemplet.SelectedValue.ToString() != "System.Data.DataRowView" && lstTemplet.SelectedValue.ToString() != "")
            {

                //string strStat = "select h.pkid,h.form_eng_name,h.form_type_en ,d.control_type,d.en_name,d.real_value,d.ar_name,multi_form_for_user " +
                //      " from templet_header h,templet_details d" +
                //     "  where h.pkid = d.header_id " +
                //    "  and h.pkid = " + lstTemplet.SelectedValue.ToString();

                string strStat = "select h.pkid,h.form_eng_name,h.form_type_en ,d.control_type,d.en_name,d.real_value,d.ar_name,multi_form_for_user " +
                      " from templet_header h,templet_details d" +
                     "  where h.pkid = d.header_id " +
                    "  and h.pkid = " + strTempletId;


                ConnectionToMySQL cnn = new ConnectionToMySQL();
                dtPri = cnn.GetDataTable(strStat);

                //if (dtPri.Rows[0]["multi_form_for_user"].ToString() == "1")
                //{
                //    lstTemplet.Visible = true;

                //}


                for (int i = 0; i < dtPri.Rows.Count; i++)
                {
                    if (dtPri.Rows[i]["control_type"].ToString() == "Visability")
                    {
                        if (dtPri.Rows[i]["real_value"].ToString() == "1")
                        {
                            Control ctr = GetControlByName(frm, dtPri.Rows[i]["en_name"].ToString());
                            if (ctr != null)
                                ctr.Visible = true;
                        }

                        else
                        {
                            Control ctr = GetControlByName(frm, dtPri.Rows[i]["en_name"].ToString());
                            if (ctr != null)
                                ctr.Visible = false;
                        }

                    }
                    else if (dtPri.Rows[i]["control_type"].ToString() == "Enability")
                    {
                        if (dtPri.Rows[i]["real_value"].ToString() == "1")
                        {

                            Control ctr = GetControlByName(frm, dtPri.Rows[i]["en_name"].ToString());
                            if (ctr != null)
                                ctr.Enabled = true;
                            //string strss = dtPri.Rows[i]["en_name"].ToString();
                            //this.Controls[dtPri.Rows[i]["en_name"].ToString()].Enabled = true;
                        }

                        else
                        {
                            Control ctr = GetControlByName(frm, dtPri.Rows[i]["en_name"].ToString());
                            if (ctr != null)
                                ctr.Enabled = false;
                        }

                    }
                    else if (dtPri.Rows[i]["control_type"].ToString() == "List" || dtPri.Rows[i]["control_type"].ToString() == "Text" || dtPri.Rows[i]["control_type"].ToString() == "MultiChoices" || dtPri.Rows[i]["control_type"].ToString() == "Free MultiChoices" || dtPri.Rows[i]["control_type"].ToString() == "Free List")
                    {

                        Control ctr = GetControlByName(frm, dtPri.Rows[i]["en_name"].ToString());
                        if (ctr != null)
                            ctr.Text = dtPri.Rows[i]["real_value"].ToString();
                        //}

                    }



                }



               
            }
        }
        private Control GetControlByName(Control ctrl, string Name)
        {
            Control bReturn = null;
            foreach (Control c in ctrl.Controls)
                if (c.Name == Name)
                {
                    bReturn = c;
                    return bReturn;
                }

                else
                    if (bReturn == null)
                    bReturn = GetControlByName(c, Name);

            return bReturn;
        }
        public static bool HasPrivilege(string strPriv)
        {
            if (glb_function.glb_strUserName == "وسيم الأغبري")
                return true;


            string str = dtPri.Rows.Count.ToString();
            string strss = dtPri.Rows[0]["en_name"].ToString();

            DataRow[] childRows = dtPri.Select("[en_name]='" + strPriv + "'");
            if (childRows[0]["control_type"].ToString() == "Enability")
            {
                if (childRows[0]["real_value"].ToString() == "1")
                    return true;
                else
                    return false;
            }
            if (childRows[0]["control_type"].ToString() == "Visability")
            {
                if (childRows[0]["real_value"].ToString() == "1")
                    return true;
                else
                    return false;
            }



            return false;

        }
     

    }
}
