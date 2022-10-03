namespace Etisalat_Smart_Reports
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelHeaderNavBar = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelDeskTop = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnMaxmized = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnRejection = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelHeaderNavBar.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.btnRejection);
            this.panelMenu.Controls.Add(this.panelHeaderNavBar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(270, 953);
            this.panelMenu.TabIndex = 1;
            // 
            // panelHeaderNavBar
            // 
            this.panelHeaderNavBar.Controls.Add(this.btnMenu);
            this.panelHeaderNavBar.Controls.Add(this.picLogo);
            this.panelHeaderNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderNavBar.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderNavBar.Name = "panelHeaderNavBar";
            this.panelHeaderNavBar.Size = new System.Drawing.Size(270, 114);
            this.panelHeaderNavBar.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.lblHeader);
            this.panelTitleBar.Controls.Add(this.btnMaxmized);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(270, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1512, 50);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panelDeskTop
            // 
            this.panelDeskTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.panelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskTop.Location = new System.Drawing.Point(270, 50);
            this.panelDeskTop.Name = "panelDeskTop";
            this.panelDeskTop.Size = new System.Drawing.Size(1512, 903);
            this.panelDeskTop.TabIndex = 3;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(6, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(0, 30);
            this.lblHeader.TabIndex = 11;
            // 
            // btnMaxmized
            // 
            this.btnMaxmized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxmized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMaxmized.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaxmized.IconColor = System.Drawing.Color.White;
            this.btnMaxmized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaxmized.IconSize = 20;
            this.btnMaxmized.Location = new System.Drawing.Point(1422, 0);
            this.btnMaxmized.Name = "btnMaxmized";
            this.btnMaxmized.Size = new System.Drawing.Size(45, 44);
            this.btnMaxmized.TabIndex = 10;
            this.btnMaxmized.UseVisualStyleBackColor = false;
            this.btnMaxmized.Click += new System.EventHandler(this.btnMaxmized_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(1377, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 44);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(1467, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 44);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRejection
            // 
            this.btnRejection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRejection.FlatAppearance.BorderSize = 0;
            this.btnRejection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRejection.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejection.ForeColor = System.Drawing.Color.White;
            this.btnRejection.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.btnRejection.IconColor = System.Drawing.Color.White;
            this.btnRejection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRejection.IconSize = 30;
            this.btnRejection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRejection.Location = new System.Drawing.Point(0, 114);
            this.btnRejection.Name = "btnRejection";
            this.btnRejection.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRejection.Size = new System.Drawing.Size(270, 52);
            this.btnRejection.TabIndex = 3;
            this.btnRejection.Tag = "Rejection";
            this.btnRejection.Text = "    Rejection";
            this.btnRejection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRejection.UseVisualStyleBackColor = true;
            this.btnRejection.Click += new System.EventHandler(this.btnRejection_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(224, 28);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 47);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // picLogo
            // 
            this.picLogo.ErrorImage = null;
            this.picLogo.Image = global::Etisalat_Smart_Reports.Properties.Resources.etlogo;
            this.picLogo.Location = new System.Drawing.Point(8, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(210, 90);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1782, 953);
            this.Controls.Add(this.panelDeskTop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelHeaderNavBar.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHeaderNavBar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnMaxmized;
        private FontAwesome.Sharp.IconButton btnMinimize;
        public FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelDeskTop;
        private FontAwesome.Sharp.IconButton btnRejection;
        private System.Windows.Forms.Label lblHeader;
    }
}

