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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            задание_1 newForm = new задание_1();
            newForm.Show();
            this.Visible = false;
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            задание_2 newForm = new задание_2();
            newForm.Show();
            this.Visible = false;
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            задание_3 newForm = new задание_3();
            newForm.Show();
            this.Visible = false;
        }

        


        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
