using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MATeV2;

namespace MATeUI
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void connexionBtn_Click(object sender, EventArgs e)
        {
            if(userNameTbx.Text.Trim().Equals("") && passwordTbx.Text.Trim().Equals(""))
            {
                MessageBox.Show("Renseignez les champs Adresse Mail etMot de Passe");
                return;
            }
            Person person = Service.GetPersonByID(userNameTbx.Text, passwordTbx.Text);
            if ( person == null)
            {
                MessageBox.Show("username or/and password invalid ");
                return;
            }
            if (person is Boss)
            {
                ProjectManager pm = new ProjectManager();
                pm.ShowDialog();
                Close();
            }
        }
    }
}
