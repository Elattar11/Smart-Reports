using Etisalat_Smart_Reports.MyMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etisalat_Smart_Reports.RejectionForms
{
    public partial class FRMPivotRejection : Form
    {
        DataTable tbl = new DataTable();
        DataTable dtCounts = new DataTable();
        DataTable dtAgent = new DataTable();
        DatabaseConnection db = new DatabaseConnection();
        public FRMPivotRejection()
        {
            InitializeComponent();
        }

        private void LoadDataFromDatabase()
        {
            tbl.Clear();
            tbl = db.ReadData("select * from TB_Rejection_Pivot", "");
            dgvPivotRejection.DataSource = tbl;
            
        }

        private void LoadDataFromCBX()
        {
            tbl.Clear();
            tbl = db.ReadData("select * from TB_Rejection_Pivot where Creator = '" + cbxAgents.Text.ToString() + "'", "");
            dgvPivotRejection.DataSource = tbl;
        }
        private void FillType()
        {
            cbxAgents.DataSource = db.ReadData("select Creator from TB_Rejection_Pivot", "");
            cbxAgents.DisplayMember = "Creator";
            cbxAgents.ValueMember = "Creator";
        }
        private void LoadCountsFromDatabase()
        {
            dtCounts.Clear();
            dtCounts = db.ReadData("select count(FCR_FVR) from TB_Rejection where FCR_FVR = 'N' AND BS_Rej_Reason = '' AND IT_Rej_Reason = '' AND Status != 'Rejected'", "");
            lblTotalHandled.Text = dtCounts.Rows[0][0].ToString();

            dtCounts.Clear();
            dtCounts = db.ReadData("select count(FCR_FVR) from TB_Rejection where FCR_FVR = 'N' AND BS_Rej_Reason != '' OR IT_Rej_Reason != '' OR Status = 'Rejected'", "");
            lblTotalRejected.Text = dtCounts.Rows[0][0].ToString();

            dtCounts.Clear();
            dtCounts = db.ReadData("select count(FCR_FVR) from TB_Rejection where FCR_FVR = 'Y'", "");
            lblTotalFCR.Text = dtCounts.Rows[0][0].ToString();

            dtCounts.Clear();
            dtCounts = db.ReadData("select count(FCR_FVR) from TB_Rejection where FCR_FVR = 'N'", "");
            lblTotalSR.Text = dtCounts.Rows[0][0].ToString();

            double x = Convert.ToDouble(lblTotalRejected.Text);
            double y = Convert.ToDouble(lblTotalSR.Text);


            double z = (x / y) * 100;

            lblTotalRate.Text = z.ToString("0.00");
        }

        private void FRMPivotRejection_Load(object sender, EventArgs e)
        {
            cbxAgents.Visible = false;
            chxSelectAll.Checked = true;
            LoadData();
            //LoadDataFromDatabase();
            LoadCountsFromDatabase();
            FillType();

        }

        private void dgvPivotRejection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvPivotRejection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPivotRejection.Rows[e.RowIndex];
                string creator = row.Cells[0].Value.ToString();

                lblAgentName.Text = creator;
                dtAgent.Clear();
                dtAgent = db.ReadData("select [Grand Total] from TB_Rejection_Pivot  where Creator = '" + creator + "'", "");
                lblAgSR.Text = dtAgent.Rows[0][0].ToString();

                dtAgent.Clear();
                dtAgent = db.ReadData("select count(FCR_FVR) from TB_Rejection where FCR_FVR = 'Y' AND Creator = '"+ creator + "'", "");
                lblAgFCR.Text = dtAgent.Rows[0][0].ToString();

                dtAgent.Clear();
                dtAgent = db.ReadData("select Handled from TB_Rejection_Pivot  where Creator = '"+ creator + "'", "");
                lblAgHandled.Text = dtAgent.Rows[0][0].ToString();

                dtAgent.Clear();
                dtAgent = db.ReadData("select Rejected from TB_Rejection_Pivot  where Creator = '" + creator + "'", "");
                lblAgRejected.Text = dtAgent.Rows[0][0].ToString();


                double x = Convert.ToDouble(lblAgRejected.Text);
                double y = Convert.ToDouble(lblAgSR.Text);


                double z = (x / y) * 100;

                lblAgRate.Text = z.ToString("0.00");
            }
        }

        private void cbxAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (chxSelectAll.Checked == true)
            {
                LoadDataFromDatabase();
                cbxAgents.Visible = false;
            }
            else if (chxSelectAll.Checked == false)
            {
                cbxAgents.Visible = true;
                LoadDataFromCBX();
            }
        }

        private void chxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
