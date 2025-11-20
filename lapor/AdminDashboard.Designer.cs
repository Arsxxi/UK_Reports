namespace lapor
{
    partial class AdminDashboard
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtFeed = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.pbBukti = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBukti)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.btnSimpan);
            this.splitContainer1.Panel2.Controls.Add(this.txtFeed);
            this.splitContainer1.Panel2.Controls.Add(this.cmbStatus);
            this.splitContainer1.Panel2.Controls.Add(this.pbBukti);
            this.splitContainer1.Panel2.Controls.Add(this.lblInfo);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 692);
            this.splitContainer1.SplitterDistance = 723;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.Size = new System.Drawing.Size(723, 692);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Gold;
            this.btnSimpan.Location = new System.Drawing.Point(36, 531);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(170, 35);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan Perubahan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtFeed
            // 
            this.txtFeed.Location = new System.Drawing.Point(36, 459);
            this.txtFeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFeed.Name = "txtFeed";
            this.txtFeed.Size = new System.Drawing.Size(148, 26);
            this.txtFeed.TabIndex = 3;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Menunggu",
            "Proses",
            "Selesai"});
            this.cmbStatus.Location = new System.Drawing.Point(36, 421);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(180, 28);
            this.cmbStatus.TabIndex = 2;
            // 
            // pbBukti
            // 
            this.pbBukti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBukti.Location = new System.Drawing.Point(36, 176);
            this.pbBukti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbBukti.Name = "pbBukti";
            this.pbBukti.Size = new System.Drawing.Size(396, 222);
            this.pbBukti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBukti.TabIndex = 1;
            this.pbBukti.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(4, 14);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(58, 20);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Detail..";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBukti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.PictureBox pbBukti;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtFeed;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}