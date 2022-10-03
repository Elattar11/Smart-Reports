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
    public partial class FRMEsclations : Form
    {
        DataTable tbl = new DataTable();
        DatabaseConnection db = new DatabaseConnection();
        public FRMEsclations()
        {
            InitializeComponent();
        }

        private void LoadDataFromDatabase()
        {
            tbl.Clear();
            tbl = db.ReadData("select * from TB_Esclations", "");
            dgvEsclations.DataSource = tbl;

        }

        private void FRMEsclations_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }
    }
}
