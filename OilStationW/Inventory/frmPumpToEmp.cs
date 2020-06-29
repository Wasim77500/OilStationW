using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilStationW.Inventory
{
    public partial class frmPumpToEmp : OilStationW.myForm
    {
        public frmPumpToEmp()
        {
            InitializeComponent();
        }

        private void frmPumpToEmp_Load(object sender, EventArgs e)
        {
            FillEmp();
            FillPumps();
            GetData();
        }
        private void FillPumps()
        {

            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtPump = cnn.GetDataTable("SELECT pkid,pumpname " +
                               " FROM pumps p " +
                               " where p.warehouse_id in (select w.pkid from warehouse w where w.branch_id = " + glb_function.glb_strBranchPkid + ") " +
                               " and p.stat = 'متاحة'");
            lstPumps.DataSource = dtPump.DefaultView;
            lstPumps.ValueMember = "pkid";
            lstPumps.DisplayMember = "pumpname";


        }
        private void FillEmp()
        {
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtEmp = cnn.GetDataTable("select pkid,empname from emp where branch_id=" + glb_function.glb_strBranchPkid);
            lstEmp.DataSource = dtEmp.DefaultView;
            lstEmp.ValueMember = "pkid";
            lstEmp.DisplayMember = "empname";
        }
        private void GetData()
        {
            dgvEmpPump.Rows.Clear();
            ConnectionToMySQL cnn = new ConnectionToMySQL();
            DataTable dtEmpPump = cnn.GetDataTable("SELECT pe.pkid,pe.emp_id,e.empname,pe.pump_id,p.PumpName " +
                                    "FROM pump_emp pe " +
                                    "join pumps p on(pe.pump_id = p.pkid) " +
                                    "join emp e on(pe.emp_id = e.pkid) " +
                                    "where date_format(pe.assign_date, '%d/%m/%Y') ='" + dtpWorkingDate.Value.ToString("dd/MM/yyyy") + "'");

           
            for (int i = 0; i < dtEmpPump.Rows.Count; i++)
            {

                dgvEmpPump.Rows.Add();
                dgvEmpPump[clmPkid.Index,i].Value  = dtEmpPump.Rows[i]["pkid"].ToString();
                dgvEmpPump[clmEmpId.Index, i].Value = dtEmpPump.Rows[i]["emp_id"].ToString();
                dgvEmpPump[clmEmpName.Index, i].Value = dtEmpPump.Rows[i]["empname"].ToString();
                dgvEmpPump[clmPumpId.Index, i].Value = dtEmpPump.Rows[i]["pump_id"].ToString();
                dgvEmpPump[clmPumpName.Index, i].Value = dtEmpPump.Rows[i]["PumpName"].ToString();


                

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstEmp.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار العامل");
                lstEmp.Focus();
                return;
            }

            if (lstPumps.SelectedIndex == -1)
            {
                glb_function.MsgBox("الرجاء اختيار الطرمبة");
                lstPumps.Focus();
                return;
            }

            ConnectionToMySQL cnn = new ConnectionToMySQL();
            ConnectionToMySQL cnnSave = new ConnectionToMySQL();

            int icheck = cnnSave.TranDataToDB("insert into pump_emp " +
                          " values((select ifnull(max(b.pkid),0)+1 from pump_emp b)" +
                          ",'فعال'" +
                          ",SYSDATE() " +
                          "," + glb_function.glb_strUserId +
                          ",str_to_date('" + dtpWorkingDate.Value.ToString("dd/MM/yyyy") + "','%d/%m/%Y')" +
                          ",'" + lstEmp.SelectedValue.ToString() + "'" +
                         "," + lstPumps.SelectedValue.ToString() +

                         ")");

            if (icheck <= 0)
            {

                glb_function.MsgBox("حدث خطأ اثناء عملية اضافة البيانات");
                return;
            }

            icheck = cnnSave.TranDataToDB("update pumps set stat ='شغالة' where pkid=" + lstPumps.SelectedValue.ToString());
            if (icheck <= 0)
            {
                cnnSave.glb_RollbackTransaction();
                glb_function.MsgBox("حدث خطأ اثناء عملية اضافة البيانات");
                return;
            }


            cnnSave.glb_commitTransaction();

            lstEmp.SelectedIndex = -1;
            lstPumps.SelectedIndex = -1;
            FillPumps();
            GetData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
