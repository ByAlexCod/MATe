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

namespace MATeUI{
    public partial class memberManagerForm : Form
    {
        public memberManagerForm()
        {
           /* ICollection<Employee> employees = new List<Employee>();
            for (int i = 0; i < 5; i++)
            {
                Employee e = new Employee("A", i.ToString(), string.Concat("A", i.ToString(), "@"), i.ToString());
                employees.Add(e);
            }
            InitializeComponent();
            memberList.DataSource = employees;
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
