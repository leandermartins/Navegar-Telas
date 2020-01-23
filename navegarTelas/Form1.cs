using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace navegarTelas
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSegundatela frmSegundatela = new frmSegundatela(textBox1.Text);
            frmSegundatela.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("friends.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("got.jpg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("vikings.png");
        }
    }
}
