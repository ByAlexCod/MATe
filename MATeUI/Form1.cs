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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void connexionBtn_Click(object sender, EventArgs e)
        {
            if(!(userNameTbx.Text.Trim().Equals("boss") && passwordTbx.Text.Trim().Equals("boss")))
            {
                MessageBox.Show("username or/and password invalid ");
                return;
            }
            //AcceuilBoss boss = new AcceuilBoss();
            CreatProject cp = new CreatProject();
            cp.Show();
            Hide();
        }
    }
}
