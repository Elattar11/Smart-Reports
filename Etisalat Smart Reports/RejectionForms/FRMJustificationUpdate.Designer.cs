namespace Etisalat_Smart_Reports.RejectionForms
{
    partial class FRMJustificationUpdate
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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.paneldesk = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOwnerTeam = new System.Windows.Forms.TextBox();
            this.lblCreator = new System.Windows.Forms.Label();
            this.txtSubStatus = new System.Windows.Forms.TextBox();
            this.lblSRNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubArea = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIT = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPerv = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtJustification = new System.Windows.Forms.TextBox();
            this.btnJustificationUpdate = new System.Windows.Forms.Button();
            this.txtSRNumber = new System.Windows.Forms.TextBox();
            this.pnHeader.SuspendLayout();
            this.paneldesk.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Black;
            this.pnHeader.Controls.Add(this.btnClose);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1100, 39);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(1055, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 35);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // paneldesk
            // 
            this.paneldesk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.paneldesk.Controls.Add(this.groupBox3);
            this.paneldesk.Controls.Add(this.groupBox2);
            this.paneldesk.Controls.Add(this.groupBox1);
            this.paneldesk.Controls.Add(this.lblCreator);
            this.paneldesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldesk.Location = new System.Drawing.Point(0, 39);
            this.paneldesk.Name = "paneldesk";
            this.paneldesk.Size = new System.Drawing.Size(1100, 640);
            this.paneldesk.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSRNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblSRNumber);
            this.groupBox1.Controls.Add(this.txtBS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSubArea);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOwnerTeam);
            this.groupBox1.Controls.Add(this.txtSubStatus);
            this.groupBox1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 266);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SR Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(49, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status : ";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("LBC", 12F);
            this.txtStatus.Location = new System.Drawing.Point(204, 153);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(291, 33);
            this.txtStatus.TabIndex = 6;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(49, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Owner Team : ";
            // 
            // txtOwnerTeam
            // 
            this.txtOwnerTeam.Font = new System.Drawing.Font("LBC", 12F);
            this.txtOwnerTeam.Location = new System.Drawing.Point(204, 103);
            this.txtOwnerTeam.Name = "txtOwnerTeam";
            this.txtOwnerTeam.ReadOnly = true;
            this.txtOwnerTeam.Size = new System.Drawing.Size(291, 33);
            this.txtOwnerTeam.TabIndex = 4;
            this.txtOwnerTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCreator
            // 
            this.lblCreator.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCreator.Location = new System.Drawing.Point(12, 3);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(1076, 42);
            this.lblCreator.TabIndex = 1;
            this.lblCreator.Text = "Creator";
            this.lblCreator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSubStatus
            // 
            this.txtSubStatus.Font = new System.Drawing.Font("LBC", 12F);
            this.txtSubStatus.Location = new System.Drawing.Point(204, 202);
            this.txtSubStatus.Name = "txtSubStatus";
            this.txtSubStatus.ReadOnly = true;
            this.txtSubStatus.Size = new System.Drawing.Size(291, 33);
            this.txtSubStatus.TabIndex = 2;
            this.txtSubStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSRNumber
            // 
            this.lblSRNumber.AutoSize = true;
            this.lblSRNumber.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSRNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSRNumber.Location = new System.Drawing.Point(327, 41);
            this.lblSRNumber.Name = "lblSRNumber";
            this.lblSRNumber.Size = new System.Drawing.Size(126, 26);
            this.lblSRNumber.TabIndex = 0;
            this.lblSRNumber.Text = "SR Number : ";
            this.lblSRNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(49, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sub Status : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(581, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sub Area : ";
            // 
            // txtSubArea
            // 
            this.txtSubArea.Font = new System.Drawing.Font("LBC", 12F);
            this.txtSubArea.Location = new System.Drawing.Point(737, 103);
            this.txtSubArea.Name = "txtSubArea";
            this.txtSubArea.ReadOnly = true;
            this.txtSubArea.Size = new System.Drawing.Size(291, 33);
            this.txtSubArea.TabIndex = 9;
            this.txtSubArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(581, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "BS Rejection : ";
            // 
            // txtBS
            // 
            this.txtBS.Font = new System.Drawing.Font("LBC", 12F);
            this.txtBS.Location = new System.Drawing.Point(737, 153);
            this.txtBS.Name = "txtBS";
            this.txtBS.ReadOnly = true;
            this.txtBS.Size = new System.Drawing.Size(291, 33);
            this.txtBS.TabIndex = 11;
            this.txtBS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(581, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "IT Rejection : ";
            // 
            // txtIT
            // 
            this.txtIT.Font = new System.Drawing.Font("LBC", 12F);
            this.txtIT.Location = new System.Drawing.Point(737, 202);
            this.txtIT.Name = "txtIT";
            this.txtIT.ReadOnly = true;
            this.txtIT.Size = new System.Drawing.Size(291, 33);
            this.txtIT.TabIndex = 13;
            this.txtIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnPerv);
            this.groupBox2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1076, 87);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("LBC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnNext.IconColor = System.Drawing.Color.White;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 30;
            this.btnNext.Location = new System.Drawing.Point(566, 27);
            this.btnNext.Name = "btnNext";
            this.btnNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNext.Size = new System.Drawing.Size(67, 33);
            this.btnNext.TabIndex = 115;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPerv
            // 
            this.btnPerv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPerv.BackColor = System.Drawing.Color.Black;
            this.btnPerv.FlatAppearance.BorderSize = 0;
            this.btnPerv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerv.Font = new System.Drawing.Font("LBC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerv.ForeColor = System.Drawing.Color.White;
            this.btnPerv.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnPerv.IconColor = System.Drawing.Color.White;
            this.btnPerv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPerv.IconSize = 30;
            this.btnPerv.Location = new System.Drawing.Point(443, 27);
            this.btnPerv.Name = "btnPerv";
            this.btnPerv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPerv.Size = new System.Drawing.Size(67, 33);
            this.btnPerv.TabIndex = 114;
            this.btnPerv.UseVisualStyleBackColor = false;
            this.btnPerv.Click += new System.EventHandler(this.btnPerv_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnJustificationUpdate);
            this.groupBox3.Controls.Add(this.txtJustification);
            this.groupBox3.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1076, 204);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Justification";
            // 
            // txtJustification
            // 
            this.txtJustification.Font = new System.Drawing.Font("LBC", 12F);
            this.txtJustification.Location = new System.Drawing.Point(54, 32);
            this.txtJustification.Multiline = true;
            this.txtJustification.Name = "txtJustification";
            this.txtJustification.Size = new System.Drawing.Size(974, 85);
            this.txtJustification.TabIndex = 5;
            // 
            // btnJustificationUpdate
            // 
            this.btnJustificationUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnJustificationUpdate.BackColor = System.Drawing.Color.Black;
            this.btnJustificationUpdate.Font = new System.Drawing.Font("LBC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJustificationUpdate.ForeColor = System.Drawing.Color.White;
            this.btnJustificationUpdate.Location = new System.Drawing.Point(378, 134);
            this.btnJustificationUpdate.Name = "btnJustificationUpdate";
            this.btnJustificationUpdate.Size = new System.Drawing.Size(320, 47);
            this.btnJustificationUpdate.TabIndex = 118;
            this.btnJustificationUpdate.Text = "Update Justification";
            this.btnJustificationUpdate.UseVisualStyleBackColor = false;
            this.btnJustificationUpdate.Click += new System.EventHandler(this.btnJustificationUpdate_Click);
            // 
            // txtSRNumber
            // 
            this.txtSRNumber.Font = new System.Drawing.Font("LBC", 12F);
            this.txtSRNumber.Location = new System.Drawing.Point(459, 38);
            this.txtSRNumber.Name = "txtSRNumber";
            this.txtSRNumber.ReadOnly = true;
            this.txtSRNumber.Size = new System.Drawing.Size(291, 33);
            this.txtSRNumber.TabIndex = 14;
            this.txtSRNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRMJustificationUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1100, 679);
            this.Controls.Add(this.paneldesk);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMJustificationUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMJustificationUpdate";
            this.Load += new System.EventHandler(this.FRMJustificationUpdate_Load);
            this.pnHeader.ResumeLayout(false);
            this.paneldesk.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        public FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel paneldesk;
        private System.Windows.Forms.Label lblSRNumber;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOwnerTeam;
        private System.Windows.Forms.TextBox txtSubStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubArea;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPerv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtJustification;
        private System.Windows.Forms.Button btnJustificationUpdate;
        private System.Windows.Forms.TextBox txtSRNumber;
    }
}