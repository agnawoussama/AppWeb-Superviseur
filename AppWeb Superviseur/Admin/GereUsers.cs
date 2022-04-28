using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWeb_Superviseur.Admin
{
    public partial class GereUsers : UserControl
    {
        public GereUsers()
        {
            InitializeComponent();
        }

        AdoClass ado;

        //Fonction qui affiche tous les utilisateurs
        private void afficher()
        {
            ado = new AdoClass();
            try
            {
                ado.command = new System.Data.SqlClient.SqlCommand("SELECT loginn as Login," +
                                                                   "motDePass as Mot_de_Passe," +
                                                                   "nomUtilisateur as Nom," +
                                                                   "prenomUtilisateur as Prenom," +
                                                                   "sexe as Sexe," +
                                                                   "dateNaiss as Date_Naissance," +
                                                                   "adresse as Adresse," +
                                                                   "email as Email," +
                                                                   "telephone as Telephone FROM utilisateur", ado.connection);
                ado.Connecter();
                ado.reader = ado.command.ExecuteReader();
                if (ado.reader.HasRows)
                {
                    ado.bs = new BindingSource();
                    ado.bs.DataSource = ado.reader;
                    dgvUsers.DataSource = ado.bs;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { ado.Deconnecter(); }
        }

        //Fonction qui vide tous les champs apres chaque operation
        private void ViderChamps()
        {
            txtbxLogin.Text = txtbxMdp.Text = txtbxNom.Text = txtbxPre.Text = txtbxEmail.Text = txtbxTel.Text = rchTxtbxAdr.Text = "";
            dtmPicker.Value = DateTime.Now;
            cmbxSexe.SelectedIndex = 0;
        }

        //Load Event
        private void GereUsers_Load(object sender, EventArgs e)
        {
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            afficher();
        }

        //Bouton Ajouter
        private void btnAjt_Click(object sender, EventArgs e)
        {
            ado = new AdoClass();
            try
            {
                ado.command = new System.Data.SqlClient.SqlCommand("INSERT INTO utilisateur VALUES (@loginn,@motDePass,@nomUtilisateur,@prenomUtilisateur,@sexe,@dateNaiss,@adresse,@email,@telephone, @admine)", ado.connection);
                ado.command.Parameters.AddWithValue("@loginn",           txtbxLogin.Text  );
                ado.command.Parameters.AddWithValue("@motDePass",        txtbxMdp.Text    );
                ado.command.Parameters.AddWithValue("@nomUtilisateur",   txtbxNom.Text    );
                ado.command.Parameters.AddWithValue("@prenomUtilisateur",txtbxPre.Text    );
                ado.command.Parameters.AddWithValue("@sexe",             cmbxSexe.Text    );
                ado.command.Parameters.AddWithValue("@dateNaiss",        dtmPicker.Value  );
                ado.command.Parameters.AddWithValue("@adresse",          rchTxtbxAdr.Text );
                ado.command.Parameters.AddWithValue("@email",            txtbxEmail.Text  );
                ado.command.Parameters.AddWithValue("@telephone",        txtbxTel.Text    );
                ado.command.Parameters.AddWithValue("@admine",           0                );
                ado.Connecter();
                ado.command.ExecuteNonQuery();
                MessageBox.Show("Utilisateur Ajouté avec Success");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally 
            { 
                ado.Deconnecter();
                afficher();
                ViderChamps();
            }
        }

        //Evenement Cell Click
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbxLogin.Text  = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            txtbxMdp.Text    = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            txtbxNom.Text    = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            txtbxPre.Text    = dgvUsers.CurrentRow.Cells[3].Value.ToString();
            cmbxSexe.Text    = dgvUsers.CurrentRow.Cells[4].Value.ToString();
            dtmPicker.Value  = Convert.ToDateTime(dgvUsers.CurrentRow.Cells[5].Value);
            rchTxtbxAdr.Text = dgvUsers.CurrentRow.Cells[6].Value.ToString();
            txtbxEmail.Text  = dgvUsers.CurrentRow.Cells[7].Value.ToString();
            txtbxTel.Text    = dgvUsers.CurrentRow.Cells[8].Value.ToString();
        }

        //Bouton Supprimer
        private void btnSupp_Click(object sender, EventArgs e)
        {
            ado = new AdoClass();
            try
            {
                ado.command = new System.Data.SqlClient.SqlCommand("DELETE FROM utilisateur WHERE loginn = @loginn", ado.connection);
                ado.command.Parameters.AddWithValue("@loginn", txtbxLogin.Text);
                ado.Connecter();
                ado.command.ExecuteNonQuery();
                MessageBox.Show("Utilisateur Supprimé avec Success");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally 
            { 
                ado.Deconnecter();
                afficher();
                ViderChamps();
            }
        }

        //Bouton Modifier
        private void btnMod_Click(object sender, EventArgs e)
        {
            ado = new AdoClass();
            try
            {
                ado.command = new System.Data.SqlClient.SqlCommand("UPDATE utilisateur SET " +
                                                                                      "motDePass = @motDePass," +
                                                                                      "nomUtilisateur = @nomUtilisateur," +
                                                                                      "prenomUtilisateur = @prenomUtilisateur," +
                                                                                      "sexe = @sexe," +
                                                                                      "dateNaiss = @dateNaiss," +
                                                                                      "adresse = @adresse," +
                                                                                      "email = @email," +
                                                                                      "telephone = @telephone WHERE loginn = @loginn", ado.connection);
                ado.command.Parameters.AddWithValue("@loginn", txtbxLogin.Text);
                ado.command.Parameters.AddWithValue("@motDePass", txtbxMdp.Text);
                ado.command.Parameters.AddWithValue("@nomUtilisateur", txtbxNom.Text);
                ado.command.Parameters.AddWithValue("@prenomUtilisateur", txtbxPre.Text);
                ado.command.Parameters.AddWithValue("@sexe", cmbxSexe.Text);
                ado.command.Parameters.AddWithValue("@dateNaiss", dtmPicker.Value);
                ado.command.Parameters.AddWithValue("@adresse", rchTxtbxAdr.Text);
                ado.command.Parameters.AddWithValue("@email", txtbxEmail.Text);
                ado.command.Parameters.AddWithValue("@telephone", txtbxTel.Text);
                ado.Connecter();
                ado.command.ExecuteNonQuery();
                MessageBox.Show("Utilisateur Modifié avec Success");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                ado.Deconnecter();
                afficher();
                ViderChamps();
            }
        }

        //Bouton Vider
        private void btnVider_Click(object sender, EventArgs e)
        {
            ViderChamps();
        }
    }
}
