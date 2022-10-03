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
    public partial class FRMRejectedTickets : Form
    {
        DataTable tbl = new DataTable();
        DatabaseConnection db = new DatabaseConnection();
        Methods m = new Methods();

        private void LoadDataFromDatabase()
        {
            tbl.Clear();
            tbl = db.ReadData("select * from TB_Rejected_Tickets", "");
            dgvRejectedSR.DataSource = tbl;


        }

        private void LoadDataFromCBXAgents()
        {
            tbl.Clear();
            tbl = db.ReadData("select * from TB_Rejected_Tickets where Creator = '" + cbxAgents.Text.ToString() + "'", "");
            dgvRejectedSR.DataSource = tbl;
        }

        private void LoadDataFromCBXSubArea()
        {
            tbl.Clear();
            tbl = db.ReadData("select * from TB_Rejected_Tickets where Sub_Area = '" + cbxSubArea.Text.ToString() + "'", "");
            dgvRejectedSR.DataSource = tbl;
        }
        private void FillAgentsType()
        {
            cbxAgents.DataSource = db.ReadData("select distinct Creator from TB_Rejected_Tickets", "");
            cbxAgents.DisplayMember = "Creator";
            cbxAgents.ValueMember = "Creator";
        }

        private void FillSubAreaType()
        {
            cbxSubArea.DataSource = db.ReadData("select distinct Sub_Area from TB_Rejected_Tickets", "");
            cbxSubArea.DisplayMember = "Sub_Area";
            cbxSubArea.ValueMember = "Sub_Area";
        }
        private void LoadSubAreaData()
        {
            if (chxSelectAllSubArea.Checked == true)
            {
                LoadDataFromDatabase();
                cbxSubArea.Visible = false;
            }
            else if (chxSelectAllSubArea.Checked == false)
            {
                cbxSubArea.Visible = true;
                LoadDataFromCBXSubArea();
            }
        }

        private void LoadData()
        {
            if (chxSelectAllAgents.Checked == true)
            {
                LoadDataFromDatabase();
                cbxAgents.Visible = false;
            }
            else if (chxSelectAllAgents.Checked == false)
            {
                cbxAgents.Visible = true;
                LoadDataFromCBXAgents();
            }
        }
        public FRMRejectedTickets()
        {
            InitializeComponent();
        }

        private void FRMRejectedTickets_Load(object sender, EventArgs e)
        {
            cbxSubArea.Visible = false;
            cbxAgents.Visible = false;
            chxSelectAllAgents.Checked = true;
            chxSelectAllSubArea.Checked = true;
            FillAgentsType();
            FillSubAreaType();
            LoadSubAreaData();
            LoadData();
        }

        private void cbxAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void chxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void chxSelectAllSubArea_CheckedChanged(object sender, EventArgs e)
        {
            LoadSubAreaData();
        }

        private void cbxSubArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubAreaData();
        }

        private void btnAutoJustify_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRejectedSR.Rows.Count <= 0)
                {
                    MyMessageBox.Show("There is no data to justify", "ERROR", MyMessageBox.MyMessageBoxButtons.OK, MyMessageBox.MyMessageBoxIcon.warning);
                }
                else
                {
                    db.ReadData("update TB_Rejected_Tickets set Justification = 'After check we did not found any reason to reject this SR' where IT_Rej_Reason != '' OR Sub_Area = 'Maintenance-Inside Cairo' OR Sub_Area = 'Maintenance-Outside Cairo' OR Sub_Area = 'Maint-Outside Cairo-RET' OR Sub_Area = 'Maint-Inside Cairo-RET'", "All Home Visits and ITs Tickets has ben justified");
                }
                
            }
            catch (Exception)
            {

                MyMessageBox.Show("", "ERROR", MyMessageBox.MyMessageBoxButtons.OK, MyMessageBox.MyMessageBoxIcon.warning);
            }
        }

        private void JustificationFilter()
        {
            if (cbxJustificationFilter.Text == "All")
            {
                LoadDataFromDatabase();
            }
            else if (cbxJustificationFilter.Text == "Justified")
            {
                tbl.Clear();
                tbl = db.ReadData("select * from TB_Rejected_Tickets where Justification IS NOT NUll", "");
                dgvRejectedSR.DataSource = tbl;
            }
            else if (cbxJustificationFilter.Text == "Not Justified")
            {
                tbl.Clear();
                tbl = db.ReadData("select * from TB_Rejected_Tickets where Justification IS NUll", "");
                dgvRejectedSR.DataSource = tbl;
            }
        }

        private void cbxJustificationFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            JustificationFilter();
        }

        private void btnJustification_Click(object sender, EventArgs e)
        {
            m.openSmallForm(new FRMJustificationUpdate());
        }
    }
}
