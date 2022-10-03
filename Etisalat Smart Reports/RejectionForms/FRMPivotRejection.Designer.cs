namespace Etisalat_Smart_Reports.RejectionForms
{
    partial class FRMPivotRejection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxAgentResult = new System.Windows.Forms.GroupBox();
            this.lblAgRate = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblAgRejected = new System.Windows.Forms.Label();
            this.lblAgHandled = new System.Windows.Forms.Label();
            this.lblAgFCR = new System.Windows.Forms.Label();
            this.lblAgSR = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAgentName = new System.Windows.Forms.Label();
            this.lblTotalRate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalSR = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalFCR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalRejected = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalHandled = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPivotRejection = new System.Windows.Forms.DataGridView();
            this.cbxAgents = new System.Windows.Forms.ComboBox();
            this.chxSelectAll = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.gbxAgentResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPivotRejection)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chxSelectAll);
            this.panel1.Controls.Add(this.cbxAgents);
            this.panel1.Controls.Add(this.gbxAgentResult);
            this.panel1.Controls.Add(this.lblTotalRate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTotalSR);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblTotalFCR);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTotalRejected);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTotalHandled);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvPivotRejection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1512, 903);
            this.panel1.TabIndex = 0;
            // 
            // gbxAgentResult
            // 
            this.gbxAgentResult.Controls.Add(this.lblAgRate);
            this.gbxAgentResult.Controls.Add(this.label14);
            this.gbxAgentResult.Controls.Add(this.lblAgRejected);
            this.gbxAgentResult.Controls.Add(this.lblAgHandled);
            this.gbxAgentResult.Controls.Add(this.lblAgFCR);
            this.gbxAgentResult.Controls.Add(this.lblAgSR);
            this.gbxAgentResult.Controls.Add(this.label9);
            this.gbxAgentResult.Controls.Add(this.label8);
            this.gbxAgentResult.Controls.Add(this.label7);
            this.gbxAgentResult.Controls.Add(this.label2);
            this.gbxAgentResult.Controls.Add(this.lblAgentName);
            this.gbxAgentResult.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAgentResult.Location = new System.Drawing.Point(1071, 201);
            this.gbxAgentResult.Name = "gbxAgentResult";
            this.gbxAgentResult.Size = new System.Drawing.Size(429, 597);
            this.gbxAgentResult.TabIndex = 106;
            this.gbxAgentResult.TabStop = false;
            this.gbxAgentResult.Text = "Agent Result";
            // 
            // lblAgRate
            // 
            this.lblAgRate.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAgRate.ForeColor = System.Drawing.Color.Navy;
            this.lblAgRate.Location = new System.Drawing.Point(195, 248);
            this.lblAgRate.Name = "lblAgRate";
            this.lblAgRate.Size = new System.Drawing.Size(171, 30);
            this.lblAgRate.TabIndex = 118;
            this.lblAgRate.Text = "0";
            this.lblAgRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(26, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 26);
            this.label14.TabIndex = 117;
            this.label14.Text = "Rate : ";
            // 
            // lblAgRejected
            // 
            this.lblAgRejected.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAgRejected.ForeColor = System.Drawing.Color.Navy;
            this.lblAgRejected.Location = new System.Drawing.Point(195, 211);
            this.lblAgRejected.Name = "lblAgRejected";
            this.lblAgRejected.Size = new System.Drawing.Size(171, 30);
            this.lblAgRejected.TabIndex = 116;
            this.lblAgRejected.Text = "0";
            this.lblAgRejected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgHandled
            // 
            this.lblAgHandled.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAgHandled.ForeColor = System.Drawing.Color.Navy;
            this.lblAgHandled.Location = new System.Drawing.Point(195, 172);
            this.lblAgHandled.Name = "lblAgHandled";
            this.lblAgHandled.Size = new System.Drawing.Size(171, 30);
            this.lblAgHandled.TabIndex = 115;
            this.lblAgHandled.Text = "0";
            this.lblAgHandled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgFCR
            // 
            this.lblAgFCR.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAgFCR.ForeColor = System.Drawing.Color.Navy;
            this.lblAgFCR.Location = new System.Drawing.Point(195, 133);
            this.lblAgFCR.Name = "lblAgFCR";
            this.lblAgFCR.Size = new System.Drawing.Size(171, 30);
            this.lblAgFCR.TabIndex = 114;
            this.lblAgFCR.Text = "0";
            this.lblAgFCR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgSR
            // 
            this.lblAgSR.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAgSR.ForeColor = System.Drawing.Color.Navy;
            this.lblAgSR.Location = new System.Drawing.Point(195, 94);
            this.lblAgSR.Name = "lblAgSR";
            this.lblAgSR.Size = new System.Drawing.Size(171, 30);
            this.lblAgSR.TabIndex = 113;
            this.lblAgSR.Text = "0";
            this.lblAgSR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(26, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 26);
            this.label9.TabIndex = 112;
            this.label9.Text = "Total Rejected : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(26, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 26);
            this.label8.TabIndex = 110;
            this.label8.Text = "Total Handled : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(26, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 26);
            this.label7.TabIndex = 108;
            this.label7.Text = "Count of FCR\'s : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 26);
            this.label2.TabIndex = 106;
            this.label2.Text = "Count of SR\'s : ";
            // 
            // lblAgentName
            // 
            this.lblAgentName.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentName.ForeColor = System.Drawing.Color.Black;
            this.lblAgentName.Location = new System.Drawing.Point(26, 44);
            this.lblAgentName.Name = "lblAgentName";
            this.lblAgentName.Size = new System.Drawing.Size(377, 30);
            this.lblAgentName.TabIndex = 105;
            this.lblAgentName.Text = "Agent Name";
            this.lblAgentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalRate
            // 
            this.lblTotalRate.AutoSize = true;
            this.lblTotalRate.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTotalRate.ForeColor = System.Drawing.Color.Teal;
            this.lblTotalRate.Location = new System.Drawing.Point(841, 89);
            this.lblTotalRate.Name = "lblTotalRate";
            this.lblTotalRate.Size = new System.Drawing.Size(82, 30);
            this.lblTotalRate.TabIndex = 105;
            this.lblTotalRate.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(669, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 30);
            this.label6.TabIndex = 104;
            this.label6.Text = "Total Rate : ";
            // 
            // lblTotalSR
            // 
            this.lblTotalSR.AutoSize = true;
            this.lblTotalSR.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTotalSR.ForeColor = System.Drawing.Color.Navy;
            this.lblTotalSR.Location = new System.Drawing.Point(550, 89);
            this.lblTotalSR.Name = "lblTotalSR";
            this.lblTotalSR.Size = new System.Drawing.Size(82, 30);
            this.lblTotalSR.TabIndex = 103;
            this.lblTotalSR.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(377, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 30);
            this.label5.TabIndex = 102;
            this.label5.Text = "Total SR\'s : ";
            // 
            // lblTotalFCR
            // 
            this.lblTotalFCR.AutoSize = true;
            this.lblTotalFCR.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTotalFCR.ForeColor = System.Drawing.Color.Navy;
            this.lblTotalFCR.Location = new System.Drawing.Point(550, 20);
            this.lblTotalFCR.Name = "lblTotalFCR";
            this.lblTotalFCR.Size = new System.Drawing.Size(82, 30);
            this.lblTotalFCR.TabIndex = 101;
            this.lblTotalFCR.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(377, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 30);
            this.label4.TabIndex = 100;
            this.label4.Text = "Total FCR\'s : ";
            // 
            // lblTotalRejected
            // 
            this.lblTotalRejected.AutoSize = true;
            this.lblTotalRejected.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTotalRejected.ForeColor = System.Drawing.Color.Navy;
            this.lblTotalRejected.Location = new System.Drawing.Point(267, 89);
            this.lblTotalRejected.Name = "lblTotalRejected";
            this.lblTotalRejected.Size = new System.Drawing.Size(82, 30);
            this.lblTotalRejected.TabIndex = 99;
            this.lblTotalRejected.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 30);
            this.label3.TabIndex = 98;
            this.label3.Text = "Total Rejected SR\'s : ";
            // 
            // lblTotalHandled
            // 
            this.lblTotalHandled.AutoSize = true;
            this.lblTotalHandled.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTotalHandled.ForeColor = System.Drawing.Color.Navy;
            this.lblTotalHandled.Location = new System.Drawing.Point(267, 20);
            this.lblTotalHandled.Name = "lblTotalHandled";
            this.lblTotalHandled.Size = new System.Drawing.Size(82, 30);
            this.lblTotalHandled.TabIndex = 97;
            this.lblTotalHandled.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 30);
            this.label1.TabIndex = 96;
            this.label1.Text = "Total Handled SR\'s : ";
            // 
            // dgvPivotRejection
            // 
            this.dgvPivotRejection.AllowUserToAddRows = false;
            this.dgvPivotRejection.AllowUserToDeleteRows = false;
            this.dgvPivotRejection.AllowUserToResizeColumns = false;
            this.dgvPivotRejection.AllowUserToResizeRows = false;
            this.dgvPivotRejection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPivotRejection.BackgroundColor = System.Drawing.Color.White;
            this.dgvPivotRejection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPivotRejection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("LBC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPivotRejection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvPivotRejection.ColumnHeadersHeight = 40;
            this.dgvPivotRejection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPivotRejection.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvPivotRejection.EnableHeadersVisualStyles = false;
            this.dgvPivotRejection.GridColor = System.Drawing.Color.White;
            this.dgvPivotRejection.Location = new System.Drawing.Point(17, 201);
            this.dgvPivotRejection.Name = "dgvPivotRejection";
            this.dgvPivotRejection.ReadOnly = true;
            this.dgvPivotRejection.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPivotRejection.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvPivotRejection.RowHeadersWidth = 35;
            this.dgvPivotRejection.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("LBC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPivotRejection.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvPivotRejection.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.dgvPivotRejection.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("LBC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPivotRejection.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPivotRejection.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvPivotRejection.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPivotRejection.RowTemplate.Height = 30;
            this.dgvPivotRejection.Size = new System.Drawing.Size(1036, 597);
            this.dgvPivotRejection.TabIndex = 95;
            this.dgvPivotRejection.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPivotRejection_CellClick);
            // 
            // cbxAgents
            // 
            this.cbxAgents.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxAgents.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAgents.FormattingEnabled = true;
            this.cbxAgents.Location = new System.Drawing.Point(207, 158);
            this.cbxAgents.Name = "cbxAgents";
            this.cbxAgents.Size = new System.Drawing.Size(266, 34);
            this.cbxAgents.TabIndex = 107;
            this.cbxAgents.SelectedIndexChanged += new System.EventHandler(this.cbxAgents_SelectedIndexChanged);
            // 
            // chxSelectAll
            // 
            this.chxSelectAll.AutoSize = true;
            this.chxSelectAll.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxSelectAll.Location = new System.Drawing.Point(17, 160);
            this.chxSelectAll.Name = "chxSelectAll";
            this.chxSelectAll.Size = new System.Drawing.Size(184, 30);
            this.chxSelectAll.TabIndex = 109;
            this.chxSelectAll.Text = "select All Agents";
            this.chxSelectAll.UseVisualStyleBackColor = true;
            this.chxSelectAll.CheckedChanged += new System.EventHandler(this.chxSelectAll_CheckedChanged);
            // 
            // FRMPivotRejection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1512, 903);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMPivotRejection";
            this.Text = "FRMPivotRejection";
            this.Load += new System.EventHandler(this.FRMPivotRejection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxAgentResult.ResumeLayout(false);
            this.gbxAgentResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPivotRejection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPivotRejection;
        private System.Windows.Forms.Label lblTotalHandled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalRejected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalFCR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalSR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbxAgentResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAgentName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAgRejected;
        private System.Windows.Forms.Label lblAgHandled;
        private System.Windows.Forms.Label lblAgFCR;
        private System.Windows.Forms.Label lblAgSR;
        private System.Windows.Forms.Label lblAgRate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxAgents;
        private System.Windows.Forms.CheckBox chxSelectAll;
    }
}