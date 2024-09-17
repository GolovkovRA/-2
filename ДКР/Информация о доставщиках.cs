using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДКР
{
    public partial class задание_3 : Form
    {
        public задание_3()
        {
            InitializeComponent();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            Close();
        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void задание_3_Load(object sender, EventArgs e)
        {

        }
    }
}
