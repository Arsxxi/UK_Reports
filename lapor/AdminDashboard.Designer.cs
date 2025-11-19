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
            this.lblInfo = new System.Windows.Forms.Label();
            this.pbBukti = new System.Windows.Forms.PictureBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtFeed = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
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
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSimpan);
            this.splitContainer1.Panel2.Controls.Add(this.txtFeed);
            this.splitContainer1.Panel2.Controls.Add(this.cmbStatus);
            this.splitContainer1.Panel2.Controls.Add(this.pbBukti);
            this.splitContainer1.Panel2.Controls.Add(this.lblInfo);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 482;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(482, 450);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(3, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(40, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Detail..";
            // 
            // pbBukti
            // 
            this.pbBukti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBukti.Location = new System.Drawing.Point(24, 25);
            this.pbBukti.Name = "pbBukti";
            this.pbBukti.Size = new System.Drawing.Size(265, 145);
            this.pbBukti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBukti.TabIndex = 1;
            this.pbBukti.TabStop = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Menunggu",
            "Proses",
            "Selesai"});
            this.cmbStatus.Location = new System.Drawing.Point(24, 176);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 2;
            // 
            // txtFeed
            // 
            this.txtFeed.Location = new System.Drawing.Point(24, 203);
            this.txtFeed.Name = "txtFeed";
            this.txtFeed.Size = new System.Drawing.Size(100, 20);
            this.txtFeed.TabIndex = 3;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(24, 229);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(113, 23);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan Perubahan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
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