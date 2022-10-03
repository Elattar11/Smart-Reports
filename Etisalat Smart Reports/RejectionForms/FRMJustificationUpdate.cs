using Etisalat_Smart_Reports.MyMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etisalat_Smart_Reports.RejectionForms
{
    public partial class FRMJustificationUpdate : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        Methods m = new Methods();
        DataTable dt = new DataTable();
        private int borderSize = 2;
        private Form activeForm = null;

        int row;
        public FRMJustificationUpdate()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(192, 0, 0);//Border color
        }

        //Drag For
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void ShowFromDataBase()
        {
            dt.Clear();
            dt = db.ReadData("select * from TB_Rejected_Tickets", "");
            if (dt.Rows.Count <= 0)
            {
                MyMessageBox.Show("لا يوجد بيانات فى هذه الشاشة", "ERROR", MyMessageBox.MyMessageBoxButtons.OK, MyMessageBox.MyMessageBoxIcon.error);
            }
            else
            {
                txtSRNumber.Text = dt.Rows[row][0].ToString();
                lblCreator.Text = dt.Rows[row][1].ToString();
                txtOwnerTeam.Text = dt.Rows[row][2].ToString();
                txtStatus.Text = dt.Rows[row][3].ToString();
                txtSubStatus.Text = dt.Rows[row][4].ToString();
                txtSubArea.Text = dt.Rows[row][5].ToString();
                txtBS.Text = dt.Rows[row][6].ToString();
                txtIT.Text = dt.Rows[row][7].ToString();
                txtJustification.Text = dt.Rows[row][8].ToString();
            }
            
        }

        private void btnPerv_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                dt.Clear();
                dt = db.ReadData("select count (SR_Number) from TB_Rejected_Tickets", "");
                row = Convert.ToInt32(dt.Rows[0][0]) - 1;
                ShowFromDataBase();
            }
            else
            {
                row--;
                ShowFromDataBase();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.ReadData("select count (SR_Number) from TB_Rejected_Tickets", "");
            if (Convert.ToInt32(dt.Rows[0][0]) - 1 == row)
            {
                row = 0;
                ShowFromDataBase();
            }
            else
            {
                row++;
                ShowFromDataBase();
            }
        }

        private void FRMJustificationUpdate_Load(object sender, EventArgs e)
        {
            ShowFromDataBase();
        }

        private void btnJustificationUpdate_Click(object sender, EventArgs e)
        {
            var rs = MyMessageBox.Show("Are you want to update justification for this SR ?", "ATTENTION", MyMessageBox.MyMessageBoxButtons.YesNoCancel, MyMessageBox.MyMessageBoxIcon.warning);
            if (rs == DialogResult.Yes)
            {
                db.ReadData("update TB_Rejected_Tickets set Justification='" + txtJustification.Text.ToString() + "' where SR_Number='" + Convert.ToString(txtSRNumber.Text) + "' ", "SR Justification has been updated");
            }
        }
    }
}
