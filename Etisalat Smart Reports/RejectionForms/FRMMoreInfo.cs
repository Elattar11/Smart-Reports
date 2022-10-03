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
    public partial class FRMMoreInfo : Form
    {
        DataTable tbl = new DataTable();
        DatabaseConnection db = new DatabaseConnection();

        DataTable dtCounts = new DataTable();

        public FRMMoreInfo()
        {
            InitializeComponent();
        }

        private void LoadDataFromDatabase()
        {
            tbl.Clear();
            tbl = db.ReadData("select * from TB_More_Info", "");
            dgvMoreInfo.DataSource = tbl;

        }
        private void LoadCountsFromDatabase()
        {
            dtCounts.Clear();
            dtCounts = db.ReadData("select sum (Valid) from TB_More_Info", "");
            lblTotalValid.Text = dtCounts.Rows[0][0].ToString();

            dtCounts.Clear();
            dtCounts = db.ReadData("select sum ([Not Valid]) from TB_More_Info", "");
            lblTotalNotValid.Text = dtCounts.Rows[0][0].ToString();

            dtCounts.Clear();
            dtCounts = db.ReadData("select sum ([Cant Be Validate]) from TB_More_Info", "");
            lblTotalCantBeValidate.Text = dtCounts.Rows[0][0].ToString();

            dtCounts.Clear();
            dtCounts = db.ReadData("select sum ([Empty Validity]) from TB_More_Info", "");
            lblEmptyValidity.Text = dtCounts.Rows[0][0].ToString();

            dtCounts.Clear();
            dtCounts = db.ReadData("select sum (Valid) +sum([Not Valid]) + sum([Cant Be Validate]) + sum([Empty Validity]) from TB_More_Info", "");
            lblTotalValidity.Text = dtCounts.Rows[0][0].ToString();
        }

        private void FRMMoreInfo_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
            LoadCountsFromDatabase();
        }
    }
}
