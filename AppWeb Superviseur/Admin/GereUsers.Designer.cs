namespace AppWeb_Superviseur.Admin
{
    partial class GereUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxLogin = new System.Windows.Forms.TextBox();
            this.txtbxMdp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxPre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxTel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAjt = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.cmbxSexe = new System.Windows.Forms.ComboBox();
            this.rchTxtbxAdr = new System.Windows.Forms.RichTextBox();
            this.dtmPicker = new System.Windows.Forms.DateTimePicker();
            this.btnVider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(233, 0);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(775, 469);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // txtbxLogin
            // 
            this.txtbxLogin.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxLogin.Location = new System.Drawing.Point(90, 13);
            this.txtbxLogin.Name = "txtbxLogin";
            this.txtbxLogin.Size = new System.Drawing.Size(137, 28);
            this.txtbxLogin.TabIndex = 2;
            // 
            // txtbxMdp
            // 
            this.txtbxMdp.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMdp.Location = new System.Drawing.Point(90, 65);
            this.txtbxMdp.Name = "txtbxMdp";
            this.txtbxMdp.Size = new System.Drawing.Size(137, 28);
            this.txtbxMdp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de Passe";
            // 
            // txtbxPre
            // 
            this.txtbxPre.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPre.Location = new System.Drawing.Point(90, 166);
            this.txtbxPre.Name = "txtbxPre";
            this.txtbxPre.Size = new System.Drawing.Size(137, 28);
            this.txtbxPre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prenom";
            // 
            // txtbxNom
            // 
            this.txtbxNom.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNom.Location = new System.Drawing.Point(90, 114);
            this.txtbxNom.Name = "txtbxNom";
            this.txtbxNom.Size = new System.Drawing.Size(137, 28);
            this.txtbxNom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nom";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEmail.Location = new System.Drawing.Point(90, 441);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(137, 28);
            this.txtbxEmail.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "DateNaiss";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sexe";
            // 
            // txtbxTel
            // 
            this.txtbxTel.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTel.Location = new System.Drawing.Point(90, 493);
            this.txtbxTel.Name = "txtbxTel";
            this.txtbxTel.Size = new System.Drawing.Size(137, 28);
            this.txtbxTel.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Telephone";
            // 
            // btnAjt
            // 
            this.btnAjt.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAjt.Font = new System.Drawing.Font("Source Sans Pro Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjt.Location = new System.Drawing.Point(431, 483);
            this.btnAjt.Name = "btnAjt";
            this.btnAjt.Size = new System.Drawing.Size(185, 46);
            this.btnAjt.TabIndex = 19;
            this.btnAjt.Text = "Ajouter";
            this.btnAjt.UseVisualStyleBackColor = false;
            this.btnAjt.Click += new System.EventHandler(this.btnAjt_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnMod.Font = new System.Drawing.Font("Source Sans Pro Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(628, 483);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(185, 46);
            this.btnMod.TabIndex = 20;
            this.btnMod.Text = "Modifier";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSupp.Font = new System.Drawing.Font("Source Sans Pro Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.Location = new System.Drawing.Point(823, 483);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(185, 46);
            this.btnSupp.TabIndex = 21;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = false;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // cmbxSexe
            // 
            this.cmbxSexe.Font = new System.Drawing.Font("Source Sans Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxSexe.FormattingEnabled = true;
            this.cmbxSexe.Items.AddRange(new object[] {
            "homme",
            "femme"});
            this.cmbxSexe.Location = new System.Drawing.Point(90, 221);
            this.cmbxSexe.Name = "cmbxSexe";
            this.cmbxSexe.Size = new System.Drawing.Size(137, 28);
            this.cmbxSexe.TabIndex = 22;
            // 
            // rchTxtbxAdr
            // 
            this.rchTxtbxAdr.Font = new System.Drawing.Font("Source Sans Pro Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTxtbxAdr.Location = new System.Drawing.Point(90, 325);
            this.rchTxtbxAdr.Name = "rchTxtbxAdr";
            this.rchTxtbxAdr.Size = new System.Drawing.Size(137, 98);
            this.rchTxtbxAdr.TabIndex = 23;
            this.rchTxtbxAdr.Text = "";
            // 
            // dtmPicker
            // 
            this.dtmPicker.CustomFormat = "yyyy-MM-dd";
            this.dtmPicker.Font = new System.Drawing.Font("Source Sans Pro Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmPicker.Location = new System.Drawing.Point(90, 273);
            this.dtmPicker.Name = "dtmPicker";
            this.dtmPicker.Size = new System.Drawing.Size(137, 24);
            this.dtmPicker.TabIndex = 24;
            // 
            // btnVider
            // 
            this.btnVider.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnVider.Font = new System.Drawing.Font("Source Sans Pro Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.Location = new System.Drawing.Point(233, 483);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(185, 46);
            this.btnVider.TabIndex = 25;
            this.btnVider.Text = "Vider Champs";
            this.btnVider.UseVisualStyleBackColor = false;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // GereUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.dtmPicker);
            this.Controls.Add(this.rchTxtbxAdr);
            this.Controls.Add(this.cmbxSexe);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnAjt);
            this.Controls.Add(this.txtbxTel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbxPre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxMdp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUsers);
            this.Name = "GereUsers";
            this.Size = new System.Drawing.Size(1022, 547);
            this.Load += new System.EventHandler(this.GereUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxLogin;
        private System.Windows.Forms.TextBox txtbxMdp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxPre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbxTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAjt;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.ComboBox cmbxSexe;
        private System.Windows.Forms.RichTextBox rchTxtbxAdr;
        private System.Windows.Forms.DateTimePicker dtmPicker;
        private System.Windows.Forms.Button btnVider;
    }
}
