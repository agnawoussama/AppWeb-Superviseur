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
    public partial class pageAdmin : UserControl
    {
        public pageAdmin()
        {
            InitializeComponent();
        }

        private void pageAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User.UserAppWeb userAppWeb = new User.UserAppWeb();
            panel1.Controls.Add(userAppWeb);
            userAppWeb.Dock = DockStyle.Fill;
            userAppWeb.BringToFront();
            userAppWeb.Show();
        }

        private void btnGereUsers_Click(object sender, EventArgs e)
        {
            Admin.GereUsers gereUsers = new Admin.GereUsers();
            panel1.Controls.Add(gereUsers);
            gereUsers.Dock = DockStyle.Fill;
            gereUsers.BringToFront();
            gereUsers.Show();
        }
    }
}
