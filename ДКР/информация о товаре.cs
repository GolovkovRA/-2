using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ДКР
{
    public partial class задание_1 : Form
    {
        public задание_1()
        {
            InitializeComponent();
        }   
        private void rjButton5_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            Close();
        }
        private void rjButton4_Click(object sender, EventArgs e)
        {
            задание_2 secondForm = new задание_2 ();
            secondForm.Show();
            Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void задание_1_Load(object sender, EventArgs e)
        {

        }
    }
}

