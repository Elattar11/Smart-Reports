using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etisalat_Smart_Reports.MyMethods
{
    internal class Methods
    {
        public int borderSize = 2;
        private Form activeForm = null;

        public void openSmallForm(Form form)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "frmStart" || frm.Name == "MainForm") continue;
                if (form.Name == frm.Name)
                {
                    frm.Activate();
                    return;
                }
            }
            form.Show();
        }

        public void AdjustForm(Form form)
        {
            switch (form.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    form.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (form.Padding.Top != borderSize)
                        form.Padding = new Padding(borderSize);
                    break;
            }

        }

        public void openChildFormInPanel(Form childForm, Panel pn)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn.Controls.Add(childForm);
            pn.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();



        }
    }
}
