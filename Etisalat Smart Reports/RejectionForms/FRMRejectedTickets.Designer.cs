namespace Etisalat_Smart_Reports.RejectionForms
{
    partial class FRMRejectedTickets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxJustificationFilter = new System.Windows.Forms.ComboBox();
            this.btnAutoJustify = new System.Windows.Forms.Button();
            this.chxSelectAllSubArea = new System.Windows.Forms.CheckBox();
            this.cbxSubArea = new System.Windows.Forms.ComboBox();
            this.chxSelectAllAgents = new System.Windows.Forms.CheckBox();
            this.cbxAgents = new System.Windows.Forms.ComboBox();
            this.dgvRejectedSR = new System.Windows.Forms.DataGridView();
            this.btnJustification = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRejectedSR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnJustification);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxJustificationFilter);
            this.panel1.Controls.Add(this.btnAutoJustify);
            this.panel1.Controls.Add(this.chxSelectAllSubArea);
            this.panel1.Controls.Add(this.cbxSubArea);
            this.panel1.Controls.Add(this.chxSelectAllAgents);
            this.panel1.Controls.Add(this.cbxAgents);
            this.panel1.Controls.Add(this.dgvRejectedSR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1512, 903);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(999, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 116;
            this.label1.Text = "Justification Filter";
            // 
            // cbxJustificationFilter
            // 
            this.cbxJustificationFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxJustificationFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxJustificationFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxJustificationFilter.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxJustificationFilter.FormattingEnabled = true;
            this.cbxJustificationFilter.Items.AddRange(new object[] {
            "All",
            "Justified",
            "Not Justified"});
            this.cbxJustificationFilter.Location = new System.Drawing.Point(1004, 57);
            this.cbxJustificationFilter.Name = "cbxJustificationFilter";
            this.cbxJustificationFilter.Size = new System.Drawing.Size(170, 34);
            this.cbxJustificationFilter.TabIndex = 115;
            this.cbxJustificationFilter.Text = "All";
            this.cbxJustificationFilter.SelectedIndexChanged += new System.EventHandler(this.cbxJustificationFilter_SelectedIndexChanged);
            // 
            // btnAutoJustify
            // 
            this.btnAutoJustify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoJustify.BackColor = System.Drawing.Color.Black;
            this.btnAutoJustify.Font = new System.Drawing.Font("LBC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoJustify.ForeColor = System.Drawing.Color.White;
            this.btnAutoJustify.Location = new System.Drawing.Point(1180, 28);
            this.btnAutoJustify.Name = "btnAutoJustify";
            this.btnAutoJustify.Size = new System.Drawing.Size(320, 65);
            this.btnAutoJustify.TabIndex = 114;
            this.btnAutoJustify.Text = "Justify All HV And IT Rejected SR\'s";
            this.btnAutoJustify.UseVisualStyleBackColor = false;
            this.btnAutoJustify.Click += new System.EventHandler(this.btnAutoJustify_Click);
            // 
            // chxSelectAllSubArea
            // 
            this.chxSelectAllSubArea.AutoSize = true;
            this.chxSelectAllSubArea.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxSelectAllSubArea.Location = new System.Drawing.Point(12, 61);
            this.chxSelectAllSubArea.Name = "chxSelectAllSubArea";
            this.chxSelectAllSubArea.Size = new System.Drawing.Size(197, 30);
            this.chxSelectAllSubArea.TabIndex = 113;
            this.chxSelectAllSubArea.Text = "select All SubArea";
            this.chxSelectAllSubArea.UseVisualStyleBackColor = true;
            this.chxSelectAllSubArea.CheckedChanged += new System.EventHandler(this.chxSelectAllSubArea_CheckedChanged);
            // 
            // cbxSubArea
            // 
            this.cbxSubArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSubArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSubArea.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSubArea.FormattingEnabled = true;
            this.cbxSubArea.Location = new System.Drawing.Point(236, 59);
            this.cbxSubArea.Name = "cbxSubArea";
            this.cbxSubArea.Size = new System.Drawing.Size(266, 34);
            this.cbxSubArea.TabIndex = 112;
            this.cbxSubArea.SelectedIndexChanged += new System.EventHandler(this.cbxSubArea_SelectedIndexChanged);
            // 
            // chxSelectAllAgents
            // 
            this.chxSelectAllAgents.AutoSize = true;
            this.chxSelectAllAgents.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxSelectAllAgents.Location = new System.Drawing.Point(12, 12);
            this.chxSelectAllAgents.Name = "chxSelectAllAgents";
            this.chxSelectAllAgents.Size = new System.Drawing.Size(184, 30);
            this.chxSelectAllAgents.TabIndex = 111;
            this.chxSelectAllAgents.Text = "select All Agents";
            this.chxSelectAllAgents.UseVisualStyleBackColor = true;
            this.chxSelectAllAgents.CheckedChanged += new System.EventHandler(this.chxSelectAll_CheckedChanged);
            // 
            // cbxAgents
            // 
            this.cbxAgents.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxAgents.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxAgents.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAgents.FormattingEnabled = true;
            this.cbxAgents.Location = new System.Drawing.Point(236, 10);
            this.cbxAgents.Name = "cbxAgents";
            this.cbxAgents.Size = new System.Drawing.Size(266, 34);
            this.cbxAgents.TabIndex = 110;
            this.cbxAgents.SelectedIndexChanged += new System.EventHandler(this.cbxAgents_SelectedIndexChanged);
            // 
            // dgvRejectedSR
            // 
            this.dgvRejectedSR.AllowUserToAddRows = false;
            this.dgvRejectedSR.AllowUserToDeleteRows = false;
            this.dgvRejectedSR.AllowUserToResizeColumns = false;
            this.dgvRejectedSR.AllowUserToResizeRows = false;
            this.dgvRejectedSR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRejectedSR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRejectedSR.BackgroundColor = System.Drawing.Color.White;
            this.dgvRejectedSR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRejectedSR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("LBC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRejectedSR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRejectedSR.ColumnHeadersHeight = 40;
            this.dgvRejectedSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRejectedSR.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRejectedSR.EnableHeadersVisualStyles = false;
            this.dgvRejectedSR.GridColor = System.Drawing.Color.White;
            this.dgvRejectedSR.Location = new System.Drawing.Point(12, 99);
            this.dgvRejectedSR.Name = "dgvRejectedSR";
            this.dgvRejectedSR.ReadOnly = true;
            this.dgvRejectedSR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRejectedSR.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRejectedSR.RowHeadersWidth = 35;
            this.dgvRejectedSR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("LBC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRejectedSR.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRejectedSR.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.dgvRejectedSR.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("LBC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRejectedSR.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRejectedSR.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvRejectedSR.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRejectedSR.RowTemplate.Height = 30;
            this.dgvRejectedSR.Size = new System.Drawing.Size(1488, 684);
            this.dgvRejectedSR.TabIndex = 96;
            // 
            // btnJustification
            // 
            this.btnJustification.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnJustification.BackColor = System.Drawing.Color.Black;
            this.btnJustification.Font = new System.Drawing.Font("LBC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJustification.ForeColor = System.Drawing.Color.White;
            this.btnJustification.Location = new System.Drawing.Point(596, 803);
            this.btnJustification.Name = "btnJustification";
            this.btnJustification.Size = new System.Drawing.Size(320, 47);
            this.btnJustification.TabIndex = 117;
            this.btnJustification.Text = "Start Justification";
            this.btnJustification.UseVisualStyleBackColor = false;
            this.btnJustification.Click += new System.EventHandler(this.btnJustification_Click);
            // 
            // FRMRejectedTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1512, 903);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMRejectedTickets";
            this.Text = "FRMRejectedTickets";
            this.Load += new System.EventHandler(this.FRMRejectedTickets_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRejectedSR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRejectedSR;
        private System.Windows.Forms.CheckBox chxSelectAllAgents;
        private System.Windows.Forms.ComboBox cbxAgents;
        private System.Windows.Forms.ComboBox cbxSubArea;
        private System.Windows.Forms.CheckBox chxSelectAllSubArea;
        private System.Windows.Forms.Button btnAutoJustify;
        private System.Windows.Forms.ComboBox cbxJustificationFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJustification;
    }
}