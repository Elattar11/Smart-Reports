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

namespace Etisalat_Smart_Reports
{
    public partial class MyMessageBox : Form
    {
        private int borderSize = 2;
        public MyMessageBox()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(192, 0, 0);//Border color
            //this.Show();
        }
        //Drag For
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public enum MyMessageBoxButtons
        {
            OK = 0, YesNo = 1, YesNoCancel = 2
        };

        public enum MyMessageBoxIcon
        {
            informative = 0, warning = 1, error = 2, accept = 3, question = 4
        };
        public static DialogResult Show(string msg)
        {
            MyMessageBox myMessageBox = new MyMessageBox();
            myMessageBox.lblTitle.Text = "";
            myMessageBox.labelMessage.Text = "";
            myMessageBox.labelMessage.Text = msg;
            myMessageBox.pictureBox1.Visible = false;
            myMessageBox.btnCancel.Visible = false;
            myMessageBox.btnNo.Visible = false;
            myMessageBox.btnYes.Visible = false;

            myMessageBox.ShowDialog();

            return myMessageBox.DialogResult;

        }

        public static DialogResult Show(string msg, string title)
        {
            MyMessageBox myMessageBox = new MyMessageBox();
            myMessageBox.lblTitle.Text = "";
            myMessageBox.labelMessage.Text = "";
            myMessageBox.labelMessage.Text = msg;
            myMessageBox.lblTitle.Text = title;
            myMessageBox.pictureBox1.Visible = false;

            myMessageBox.btnCancel.Visible = false;
            myMessageBox.btnNo.Visible = false;
            myMessageBox.btnYes.Visible = false;

            myMessageBox.ShowDialog();

            return myMessageBox.DialogResult;
        }

        public static DialogResult Show(string msg, string title, MyMessageBoxButtons buttons)
        {
            MyMessageBox myMessageBox = new MyMessageBox();
            myMessageBox.lblTitle.Text = "";
            myMessageBox.labelMessage.Text = "";
            myMessageBox.labelMessage.Text = msg;
            myMessageBox.lblTitle.Text = title;
            myMessageBox.pictureBox1.Visible = false;
            if (MyMessageBoxButtons.OK == buttons)
            {
                myMessageBox.btnCancel.Visible = false;
                myMessageBox.btnNo.Visible = false;
                myMessageBox.btnYes.Visible = false;
            }
            else if (MyMessageBoxButtons.YesNo == buttons)
            {
                myMessageBox.btnCancel.Visible = false;
                myMessageBox.btnNo.Visible = true;
                myMessageBox.btnYes.Visible = true;
                myMessageBox.btnOk.Visible = false;
            }
            else if (MyMessageBoxButtons.YesNoCancel == buttons)
            {
                myMessageBox.btnCancel.Visible = true;
                myMessageBox.btnNo.Visible = true;
                myMessageBox.btnYes.Visible = true;
                myMessageBox.btnOk.Visible = false;
            }

            myMessageBox.ShowDialog();

            return myMessageBox.DialogResult;

        }

        public static DialogResult Show(string msg, string title, MyMessageBoxButtons buttons, MyMessageBoxIcon icon)
        {
            MyMessageBox myMessageBox = new MyMessageBox();
            myMessageBox.lblTitle.Text = "";
            myMessageBox.labelMessage.Text = "";
            myMessageBox.labelMessage.Text = msg;
            myMessageBox.lblTitle.Text = title;
            myMessageBox.pictureBox1.Visible = true;
            if (MyMessageBoxButtons.OK == buttons)
            {
                myMessageBox.btnCancel.Visible = false;
                myMessageBox.btnNo.Visible = false;
                myMessageBox.btnYes.Visible = false;
            }
            else if (MyMessageBoxButtons.YesNo == buttons)
            {
                myMessageBox.btnCancel.Visible = false;
                myMessageBox.btnNo.Visible = true;
                myMessageBox.btnYes.Visible = true;
                myMessageBox.btnOk.Visible = false;
            }
            else if (MyMessageBoxButtons.YesNoCancel == buttons)
            {
                myMessageBox.btnCancel.Visible = true;
                myMessageBox.btnNo.Visible = true;
                myMessageBox.btnYes.Visible = true;
                myMessageBox.btnOk.Visible = false;
            }

            if (MyMessageBoxIcon.error == icon)
            {
                myMessageBox.pictureBox1.Image = Properties.Resources.error;
            }
            else if (MyMessageBoxIcon.informative == icon)
            {
                myMessageBox.pictureBox1.Image = Properties.Resources.informative;
            }
            else if (MyMessageBoxIcon.warning == icon)
            {
                myMessageBox.pictureBox1.Image = Properties.Resources.warning;
            }
            else if (MyMessageBoxIcon.accept == icon)
            {
                myMessageBox.pictureBox1.Image = Properties.Resources.accept;
            }
            else if (MyMessageBoxIcon.question == icon)
            {
                myMessageBox.pictureBox1.Image = Properties.Resources.question;
            }

            myMessageBox.ShowDialog();

            return myMessageBox.DialogResult;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
