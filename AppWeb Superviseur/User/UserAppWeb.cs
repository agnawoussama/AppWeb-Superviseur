using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWeb_Superviseur.User
{
    public partial class UserAppWeb : UserControl
    {
        //Form1 form1;
        public UserAppWeb()
        {
            InitializeComponent();
            //form1 = new Form1();
        }

        bool stopThread = false;
        public DataTable AppWebs;

        //Variable Static qui stocke le login d'un utilisateur pour acceder a ses applications web
        public static string loginn;


        //Obtenir des données de SQL DB et écrire dans la table AppWebs
        public void GetData()
        {
            //Instanciation d'un objet AppWebs
            AppWebs = new System.Data.DataTable();
            AdoClass ado = new AdoClass();
            ado.Connecter();
            //Si un utilisateur voudrait superviser ses applications web
            if (loginn != null)
            {
                ado.command = new System.Data.SqlClient.SqlCommand("select * from AppWeb where idSite IN (SELECT idSite FROM AppWeb_User where loginn = @login)", ado.connection);
                ado.command.Parameters.AddWithValue("@login", loginn);
            }
            else //Si l'admin voudrait superviser tous les applications web
            {
                ado.command = new System.Data.SqlClient.SqlCommand("select * from AppWeb", ado.connection);
            }
            //Remplissez la table AppWebs
            AppWebs.Load(ado.command.ExecuteReader());
            ado.Deconnecter();
        }

        //Fonction qui remplie la dataGridView
        private void fillGridView()
        {
            dataGridView1.Rows.Clear(); 
            //Pour chaque ligne de la table AppWebs
            for (int i = 0; i < AppWebs.Rows.Count; i++)
            {
                //On ajoute un nouveau ligne dans note dataGridView
                int n = dataGridView1.Rows.Add();
                //Et on remplie les champs de ce ligne par le ligne de la table AppWebs
                dataGridView1.Rows[n].Cells[0].Value = AppWebs.Rows[i]["idSite"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = AppWebs.Rows[i]["nomSite"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = AppWebs.Rows[i]["urlSite"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = AppWebs.Rows[i]["interval"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = AppWebs.Rows[i]["dernierCheck"].ToString();
                //On verifie
                //si le statut de site egual 1 (le site fonctionne bien ) => Coleur Vert
                if (int.Parse(AppWebs.Rows[i]["statut"].ToString()) == 1)
                    dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Green;
                //si le statut de site egual 0 (le site ne fonctionne pas bien ) => Coleur Rouge
                else if (int.Parse(AppWebs.Rows[i]["statut"].ToString()) == 0)
                    dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Red;
                //si le statut de site egual -1 (le site en cours de verification bien ) => Coleur Jaune
                else
                    dataGridView1.Rows[i].Cells[5].Style.BackColor = Color.Yellow;
            }
        }

        //lOAD
        private void UserAppWeb_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Control.CheckForIllegalCrossThreadCalls = false;
            //On ajoute 6 Columns Pour la dataGridView
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Id WebApp";
            dataGridView1.Columns[1].Name = "Nom WebApp";
            dataGridView1.Columns[2].Name = "Url WebApp";
            dataGridView1.Columns[3].Name = "Interval";
            dataGridView1.Columns[4].Name = "Dernier Check";
            dataGridView1.Columns[5].Name = "Statut";
            //On appele la fonction GetData pour remplir la table AppWebs
            GetData();
            //On appele la fonction GetData pour remplir la DataGridView
            fillGridView();
            //Créer un nouveau thread pour la fonction CheckSiteApp
            Thread checkThread = new Thread(new ThreadStart(CheckSiteApp));
            //Démarrage de thread
            checkThread.Start();
        }

        //Mettre à jour de l'enregistrement avec le idSite
        public void UpdateRow(int idSite, string nomsite, string urlSite, int interval, int statut)
        {
            AdoClass ado = new AdoClass();
            try
            {
                //On mis a jour les nouveau informations de AppWeb
                ado.command = new System.Data.SqlClient.SqlCommand("UPDATE AppWeb SET " +
                                                                   "nomSite = @nomSite, " +
                                                                   "urlSite = @urlSite, " +
                                                                   "interval = @interval, " +
                                                                   "dernierCheck = @dernierCheck, " +
                                                                   "statut = @statut " +
                                                                   "WHERE idSite = @idSite", ado.connection);
                ado.command.Parameters.AddWithValue("@idSite", idSite.ToString());
                ado.command.Parameters.AddWithValue("@nomSite", nomsite);
                ado.command.Parameters.AddWithValue("@urlSite", urlSite);
                ado.command.Parameters.AddWithValue("@interval", interval.ToString());
                ado.command.Parameters.AddWithValue("@dernierCheck", DateTime.Now);
                ado.command.Parameters.AddWithValue("@statut", statut.ToString());
                ado.Connecter();
                ado.command.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                ado.Deconnecter();
            }
        }

        //Fonction CheckSite qui verifie les Applications Web
        public void CheckSite()
        {     
            //Pour chaque ligne de DataGridView
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //Calculer le temps écoulé depuis la dernière vérification
                System.TimeSpan diferent = DateTime.Now - (DateTime)AppWebs.Rows[i]["dernierCheck"];
                if (diferent.Seconds > (int)AppWebs.Rows[i]["interval"])
                {
                    bool result = false;
                    try
                    {
                        HttpWebRequest urlReq = (HttpWebRequest)WebRequest.Create(AppWebs.Rows[i]["urlSite"].ToString().TrimEnd());
                        HttpWebResponse urlRes = (HttpWebResponse)urlReq.GetResponse();
                        Stream sStream = urlRes.GetResponseStream();
                        string read = new StreamReader(sStream).ReadToEnd();
                        //Tout va bien, le site fonctionne
                        result = true;
                    }
                    catch (Exception ex)
                    {
                        //Erreur de site
                    }
                    int res = (result ? 1 : 0);
                    //heure actuelle
                    DateTime curentTime = DateTime.Now;
                    //Mise a jour 
                    UpdateRow((int)AppWebs.Rows[i]["idSite"],
                              AppWebs.Rows[i]["nomSite"].ToString().TrimEnd(),
                              AppWebs.Rows[i]["urlSite"].ToString().TrimEnd(),           
                              (int)AppWebs.Rows[i]["interval"],                      
                              //curentTime.ToString("yyyy-MM-dd HH:mm:ss.fff"),      
                              res);
                    //Mise a jour des dernierCheck et Statut
                    AppWebs.Rows[i]["dernierCheck"] = curentTime;
                    AppWebs.Rows[i]["statut"] = res;
                    GetData();
                    fillGridView();
                }
            }
        }

        //Stop the flow
        public void StopCheck(bool val)
        {
            stopThread = val;
        }

        //Fonction CheckSiteApp
        public void CheckSiteApp()
        {
            while (!stopThread)
            {
                Thread.Sleep(100);
                CheckSite();              
            }
        }

        //Bouton Ajouter Application Web
        private void btnAddApp_Click(object sender, EventArgs e)
        {
            AdoClass ado = new AdoClass();
            int newid = 1;
            //Trouver la valeur maximale de idSite + 1
            string query = "SELECT MAX(idSite) as max FROM AppWeb";
            ado.Connecter();
            ado.command = new System.Data.SqlClient.SqlCommand(query, ado.connection);
            object count = ado.command.ExecuteScalar();
            if (count is int)            
                newid = (int)count + 1; 
            ado.Deconnecter();

            try
            {
                //On ajoute le nouveau AppWeb
                ado.command = new System.Data.SqlClient.SqlCommand("INSERT INTO AppWeb VALUES (@nomSite, @urlSite, @interval, @dernierCheck, @statut)", ado.connection);
                ado.command.Parameters.AddWithValue("@nomSite", txtbxNomWebApp.Text);
                ado.command.Parameters.AddWithValue("@urlSite", txtbxUrlWebApp.Text);
                ado.command.Parameters.AddWithValue("@interval", txtbxInterval.Text);
                ado.command.Parameters.AddWithValue("@dernierCheck", DateTime.Now);
                ado.command.Parameters.AddWithValue("@statut", -1);
                ado.Connecter();
                ado.command.ExecuteNonQuery();
                //Ajouter le ligne dans la table Rows
                AppWebs.Rows.Add(newid.ToString(), txtbxNomWebApp.Text, txtbxUrlWebApp.Text, txtbxInterval.Text, DateTime.Now, -1);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                ado.Deconnecter();
                fillGridView();
            }
        }

        //Bouton Supprimer
        private void btnDeleteApp_Click(object sender, EventArgs e)
        {
            //Instanciation d'un objet ado
            AdoClass ado = new AdoClass();
            try
            {
                //On Suprrimer le nouveau speaker
                ado.command = new System.Data.SqlClient.SqlCommand("DELETE FROM AppWeb WHERE idSite = @idSite", ado.connection);
                ado.command.Parameters.AddWithValue("@idSite", dataGridView1.SelectedRows[0].Cells[0].Value);
                ado.Connecter();
                ado.command.ExecuteNonQuery();               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                ado.Deconnecter(); //Deconnection
                GetData();         //Remplir Tables SitesWeb
                fillGridView();    //Remplir DatagridView
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnUpdateApp_Click(object sender, EventArgs e)
        {

        }
    }
}
