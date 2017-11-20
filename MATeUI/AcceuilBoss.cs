using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATeUI
{
    public partial class AcceuilBoss : Form
    {
        public AcceuilBoss()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void memberBtn_Click(object sender, EventArgs e)
        {
            memberManagerForm memberForm = new memberManagerForm();
            memberForm.Show();

        }

        private void projetBtn_Click(object sender, EventArgs e)
        {
            ListeDesProjets lp = new ListeDesProjets();
            lp.Show();
        }
    }
}
