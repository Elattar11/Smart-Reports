using Etisalat_Smart_Reports.MyMethods;
using Etisalat_Smart_Reports.RejectionForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etisalat_Smart_Reports.Layers
{
    public partial class FRMRejectionMain : Form
    {
        Methods m = new Methods();
        public FRMRejectionMain()
        {
            InitializeComponent();
        }

        private void btnCustomersManage_Click(object sender, EventArgs e)
        {

            m.openChildFormInPanel(new FRMRowDataRejection(), pnDeskTop);
        }

        private void FRMRejectionMain_Load(object sender, EventArgs e)
        {
            m.openChildFormInPanel(new FRMRowDataRejection(), pnDeskTop);
        }

        private void btnPivorRej_Click(object sender, EventArgs e)
        {
            m.openChildFormInPanel(new FRMPivotRejection(), pnDeskTop);
        }

        private void btnRejectedSR_Click(object sender, EventArgs e)
        {
            m.openChildFormInPanel(new FRMRejectedTickets(), pnDeskTop);
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            m.openChildFormInPanel(new FRMMoreInfo(), pnDeskTop);
        }

        private void btnEsclations_Click(object sender, EventArgs e)
        {
            m.openChildFormInPanel(new FRMEsclations(), pnDeskTop);
        }

        private void btnFCRDash_Click(object sender, EventArgs e)
        {
            m.openChildFormInPanel(new FRMFCRCahrt(), pnDeskTop);
        }
    }
}
