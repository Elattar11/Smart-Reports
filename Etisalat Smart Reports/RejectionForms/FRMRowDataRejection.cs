using Etisalat_Smart_Reports.MyMethods;
using Etisalat_Smart_Reports.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using Z.Dapper.Plus;
using System.Data.SqlClient;

namespace Etisalat_Smart_Reports.RejectionForms
{
    public partial class FRMRowDataRejection : Form
    {
        DataTableCollection tableCollection;

        DatabaseConnection db = new DatabaseConnection();
        public FRMRowDataRejection()
        {
            InitializeComponent();
        }

        private void cbxSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.DataTable dt = tableCollection[cbxSheet.SelectedItem.ToString()];
            //dgvExcel.DataSource = dt;   
            if (dt != null)
            {
                List<Rejection> rjlst = new List<Rejection>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Rejection rj = new Rejection();
                    rj.SR_Number = dt.Rows[i]["SR #"].ToString();
                    rj.Short_Code = dt.Rows[i]["Short Code"].ToString();
                    rj.Type = dt.Rows[i]["Type"].ToString();
                    rj.Area = dt.Rows[i]["Area"].ToString();
                    rj.Sub_Area = dt.Rows[i]["Sub Area"].ToString();
                    rj.Product_Type = dt.Rows[i]["Product Type"].ToString();
                    rj.Product = dt.Rows[i]["Product"].ToString();
                    rj.Description = dt.Rows[i]["Description"].ToString();
                    rj.Contact_Number = dt.Rows[i]["Contact Number"].ToString();


                    if ((dt.Rows[i]["Serial #"].ToString()) == DBNull.Value.ToString())
                    {
                        rj.Serial = 0;
                    }
                    else
                    {
                        rj.Serial = (int)Convert.ToInt64(dt.Rows[i]["Serial #"]);
                    }
                    rj.Status = dt.Rows[i]["Status"].ToString();
                    rj.Sub_Status = dt.Rows[i]["Sub-Status"].ToString();
                    rj.Opened_Date = dt.Rows[i]["Opened Date"].ToString();
                    rj.Owner_Team = dt.Rows[i]["Owner Team"].ToString();
                    rj.Creator = dt.Rows[i]["Creator"].ToString();
                    rj.Account = dt.Rows[i]["Account"].ToString();
                    rj.Summary = dt.Rows[i]["Summary"].ToString();
                    rj.Custoemr_Code = dt.Rows[i]["Customer Code"].ToString();
                    rj.Comited = dt.Rows[i]["Committed"].ToString();
                    rj.Creator_Team = dt.Rows[i]["Creator Team"].ToString();
                    rj.Owner = dt.Rows[i]["Owner"].ToString();
                    rj.SLA_Breached = dt.Rows[i]["SLA Breached"].ToString();
                    rj.Closed_Date = dt.Rows[i]["Closed Date"].ToString();
                    rj.SS_Required = dt.Rows[i]["Smart Script Required"].ToString();
                    rj.CB_Required = dt.Rows[i]["Call-Back Required"].ToString();
                    rj.Acc_Segment = dt.Rows[i]["Account/Asset Op. Segment"].ToString();
                    rj.Reachability = dt.Rows[i]["Reachability"].ToString();
                    rj.Validity = dt.Rows[i]["Validity"].ToString();
                    rj.SLA_PV_Reached = dt.Rows[i]["SLA Pre-Violation Reached"].ToString();
                    rj.No_Of_Suspension = Convert.ToInt32(dt.Rows[i]["Number of Suspension"]);
                    rj.No_Of_PTrails = Convert.ToInt32(dt.Rows[i]["No. Of Pending Trials"]);
                    rj.Asset_Segment = dt.Rows[i]["Account/Asset Segment"].ToString();
                    rj.ARPU = dt.Rows[i]["ARPU"].ToString();
                    rj.BS_Rej_Reason = dt.Rows[i]["BS Rejection Reason"].ToString();
                    rj.Rate_Plan_At_Creator = dt.Rows[i]["Rate Plan at Creation"].ToString();
                    rj.Compensation_Related = dt.Rows[i]["Compensation/Retention Related"].ToString();

                    if ((dt.Rows[i]["Compensation/Retention Value"].ToString()) == DBNull.Value.ToString())
                    {
                        rj.Compensation_Value = 0;
                    }
                    else
                    {
                        rj.Compensation_Value = Convert.ToInt32(dt.Rows[i]["Compensation/Retention Value"]);
                    }
                    //rj.Compensation_Value = Convert.ToInt32(dt.Rows[i]["Compensation/Retention Value"]);
                    rj.Release_Date = dt.Rows[i]["Release Date"].ToString();
                    rj.Acc_Type = dt.Rows[i]["Account Type"].ToString();
                    rj.NTRA = dt.Rows[i]["NTRA"].ToString();
                    rj.FCR_FVR = dt.Rows[i]["FCR/FVR"].ToString();
                    rj.Agent_Queue = dt.Rows[i]["Agent's Queue"].ToString();
                    rj.Last_Update = dt.Rows[i]["Last Updated"].ToString();
                    rj.Last_Update_By = dt.Rows[i]["Last Updated By"].ToString();
                    rj.Comp_Add_Closer = dt.Rows[i]["Complaint Additional Closures"].ToString();
                    rj.Bill_Cycle = dt.Rows[i]["Bill Cycle"].ToString();
                    rj.IT_Rej_Reason = dt.Rows[i]["IT Rejection Reason"].ToString();
                    rj.Customer_Sat = dt.Rows[i]["Customer Satisfaction"].ToString();
                    rj.Assigenment_Path = dt.Rows[i]["Assignment Path"].ToString();

                    rjlst.Add(rj);
                }

                tBRejectionBindingSource.DataSource = rjlst;
            }
        }

        private void btnOpenExcelFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openDialog.FileName;
                    using (var stream = File.Open(openDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }

                            });

                            tableCollection = result.Tables;
                            cbxSheet.Items.Clear();
                            foreach (System.Data.DataTable table in tableCollection)
                            {
                                cbxSheet.Items.Add(table.TableName);
                            }
                        }
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (cbxSheet.Text == "")
            {
                MyMessageBox.Show("Please choose your Excel sheet first", "ERROR", MyMessageBox.MyMessageBoxButtons.OK, MyMessageBox.MyMessageBoxIcon.warning);
            }
            else
            {
                try
                {
                    string connstring = @"Data Source=.\SQLEXPRESS;Initial Catalog=ETIS;Integrated Security=True";
                    DapperPlusManager.Entity<Rejection>().Table("TB_Rejection");
                    List<Rejection> rjList = tBRejectionBindingSource.DataSource as List<Rejection>;
                    if (rjList != null)
                    {
                        using (IDbConnection db = new SqlConnection(connstring))
                        {
                            db.BulkInsert(rjList);
                        }
                        db.ReadData("insert into TB_Rejection_Pivot (Creator,Handled,Rejected,[Grand Total]) select Creator,sum(case when FCR_FVR = 'N' AND BS_Rej_Reason = '' AND IT_Rej_Reason = '' AND Status != 'Rejected' then 1 else 0 end) as Handled,sum(case when FCR_FVR = 'N' AND BS_Rej_Reason != '' OR IT_Rej_Reason != '' OR Status = 'Rejected' then 1 else 0 end)as Rejected,sum(case when FCR_FVR = 'N' AND BS_Rej_Reason = '' AND IT_Rej_Reason = '' AND Status != 'Rejected' OR FCR_FVR = 'N' AND BS_Rej_Reason != '' OR IT_Rej_Reason != '' OR Status = 'Rejected'then 1 else 0 end)as total from TB_Rejection GROUP BY Creator order by Creator", "");
                        db.ReadData("insert into TB_Rejected_Tickets(SR_Number, Creator, Owner_Team, Status, Sub_Status,Sub_Area, BS_Rej_Reason, IT_Rej_Reason) select SR_Number, Creator, Owner_Team, Status, Sub_Status, Sub_Area, BS_Rej_Reason, IT_Rej_Reason from TB_Rejection where FCR_FVR = 'N' AND BS_Rej_Reason != '' OR IT_Rej_Reason != '' OR Status = 'Rejected'", "");
                        db.ReadData("insert into TB_More_Info(Creator, Valid, [Not Valid], [Cant Be Validate], [Empty Validity]) select Creator, sum(case when Validity = 'Valid' AND Owner_Team = 'CC Outsourcing Inbound' AND FCR_FVR = 'Y' then 1 else 0 end)as Valid, sum(case when Validity = 'Not Valid' AND Owner_Team = 'CC Outsourcing Inbound' AND FCR_FVR = 'Y' then 1 else 0 end)as [Not Valid], sum(case when Validity = 'Cant be Validated' AND Owner_Team = 'CC Outsourcing Inbound' AND FCR_FVR = 'Y' then 1 else 0 end)as [Cant Be Validate], sum(case when Validity = '' AND Owner_Team = 'CC Outsourcing Inbound' AND FCR_FVR = 'Y' AND Short_Code not like '1%' then 1 else 0 end)as [Empty Validity] from TB_Rejection GROUP BY Creator order by Creator", "");
                        db.ReadData("insert into TB_Esclations(Creator, [Count Of Esclations SR]) select Creator, sum(case when FCR_FVR = 'N' AND Owner_Team = 'ISP Champions' AND Short_Code = '3936016' then 1 else 0 end)[Count Of Esclations SR] from TB_Rejection GROUP BY Creator order by Creator","");
                        MyMessageBox.Show("Data dded to database Successfully ...", "DONE", MyMessageBox.MyMessageBoxButtons.OK, MyMessageBox.MyMessageBoxIcon.accept);

                    }


                }
                catch (Exception)
                {

                    MyMessageBox.Show("You must clear the old data befor adding the new data", "ERROR", MyMessageBox.MyMessageBoxButtons.OK, MyMessageBox.MyMessageBoxIcon.warning);
                }

            }
            
        }

        private void btnDeleteAllData_Click(object sender, EventArgs e)
        {
            var rs = MyMessageBox.Show("Are you want to delete all data from database ? ", "ATTENTION", MyMessageBox.MyMessageBoxButtons.YesNoCancel, MyMessageBox.MyMessageBoxIcon.warning);
            if (rs == DialogResult.Yes)
            {
                db.ReadData("delete from TB_Rejection ", "All data are deleted successfully");
                db.ReadData("delete from TB_Rejection_Pivot ", "");
                db.ReadData("delete from TB_Rejected_Tickets", "");
                db.ReadData("delete from TB_More_Info", "");
                db.ReadData("delete from TB_Esclations", "");
            }
        }

        private void FRMRowDataRejection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eTISDataSet.TB_Rejection' table. You can move, or remove it, as needed.
            this.tB_RejectionTableAdapter.Fill(this.eTISDataSet.TB_Rejection);

        }
    }
}
