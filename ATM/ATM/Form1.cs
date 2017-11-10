using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNhnh1 f = new FormNhnh1();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNhanh2_Click(object sender, EventArgs e)
        {
            FormNhanh2 f = new FormNhanh2();
            f.Show();
        }
    }
}
