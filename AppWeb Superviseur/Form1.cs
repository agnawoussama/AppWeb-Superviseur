using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppWeb_Superviseur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdoClass ado = new AdoClass();
            try
            {
                ado.command = new System.Data.SqlClient.SqlCommand("Select * from utilisateur where loginn = @login and motDePass = @mdp", ado.connection);
                ado.command.Parameters.AddWithValue("@login", txtbxLogin.Text);
                ado.command.Parameters.AddWithValue("@mdp", txtbxMdp.Text);
                ado.Connecter();
                ado.reader = ado.command.ExecuteReader();
                if (ado.reader.HasRows)
                {
                    ado.reader.Read();
                    //Si il est admin =>
                    if (Convert.ToBoolean(ado.reader[9]) == true)
                    {
                        pageAdmin pageAdmin = new pageAdmin();
                        panel1.Controls.Add(pageAdmin);
                        pageAdmin.Dock = DockStyle.Fill;
                        pageAdmin.BringToFront();
                        pageAdmin.Show();
                    }
                    else //Sinon Si un normal utilisateur
                    {
                        User.UserAppWeb.loginn = txtbxLogin.Text;
                        User.UserAppWeb userAppWeb = new User.UserAppWeb();
                        panel1.Controls.Add(userAppWeb);
                        userAppWeb.Dock = DockStyle.Fill;
                        userAppWeb.BringToFront();
                        userAppWeb.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Test");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            User.UserAppWeb us = new User.UserAppWeb();
            us.StopCheck(true);
        }
    }
}
