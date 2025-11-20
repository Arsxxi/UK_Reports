namespace lapor
{
    partial class FormRegist
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtFac = new System.Windows.Forms.TextBox();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.Nama = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(525, 186);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 26);
            this.txtName.TabIndex = 0;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(525, 306);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(176, 26);
            this.txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(525, 352);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(176, 26);
            this.txtPass.TabIndex = 3;
            // 
            // txtFac
            // 
            this.txtFac.Location = new System.Drawing.Point(525, 266);
            this.txtFac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFac.Name = "txtFac";
            this.txtFac.Size = new System.Drawing.Size(176, 26);
            this.txtFac.TabIndex = 4;
            // 
            // txtNim
            // 
            this.txtNim.Location = new System.Drawing.Point(525, 226);
            this.txtNim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(176, 26);
            this.txtNim.TabIndex = 5;
            // 
            // btnDaftar
            // 
            this.btnDaftar.BackColor = System.Drawing.Color.Gold;
            this.btnDaftar.Location = new System.Drawing.Point(525, 411);
            this.btnDaftar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(112, 35);
            this.btnDaftar.TabIndex = 6;
            this.btnDaftar.Text = "Register";
            this.btnDaftar.UseVisualStyleBackColor = false;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(394, 191);
            this.Nama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(117, 20);
            this.Nama.TabIndex = 7;
            this.Nama.Text = "Nama Lengkap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 352);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "FAKULTAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "NIM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Register Akun";
            // 
            // FormRegist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.txtFac);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRegist";
            this.Text = "FormRegist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtFac;
        private System.Windows.Forms.TextBox txtNim;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}