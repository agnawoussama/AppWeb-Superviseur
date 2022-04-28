namespace AppWeb_Superviseur
{
    partial class pageAdmin
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
            this.btnGereUsers = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGereUsers
            // 
            this.btnGereUsers.Font = new System.Drawing.Font("Source Sans Pro Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGereUsers.Location = new System.Drawing.Point(168, 200);
            this.btnGereUsers.Name = "btnGereUsers";
            this.btnGereUsers.Size = new System.Drawing.Size(224, 84);
            this.btnGereUsers.TabIndex = 0;
            this.btnGereUsers.Text = "Gerer Utilisateurs";
            this.btnGereUsers.UseVisualStyleBackColor = true;
            this.btnGereUsers.Click += new System.EventHandler(this.btnGereUsers_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Source Sans Pro Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(614, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "Superviser Les WebApps";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGereUsers);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 547);
            this.panel1.TabIndex = 2;
            // 
            // pageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.Controls.Add(this.panel1);
            this.Name = "pageAdmin";
            this.Size = new System.Drawing.Size(1022, 547);
            this.Load += new System.EventHandler(this.pageAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGereUsers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}
