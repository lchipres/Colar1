using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coladera
{
    public partial class Form1 : Form
    {
        Coladera c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c = new Coladera(1000);
            c.llenado();
            c.colado();
            textBox2.Text = c.ToString();
        }
    }
}
