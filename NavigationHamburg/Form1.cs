using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationHamburg
{
    public partial class Form1 : Form
    {
        private bool Hidden;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btncloseandopen.Image = Image.FromFile(@"..\..\Images\open.jpg");
            Hidden = true;
            Spanel.Width = 0;
        }

        private void btnPage11_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestPage win = new TestPage();
            win.Show();
        }

        private void btnPage12_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestPage win = new TestPage();
            win.Show();
        }

        private void btnPage21_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestPage win = new TestPage();
            win.Show();
        }

        private void btnPage22_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestPage win = new TestPage();
            win.Show();
        }

        private void btnPage31_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestPage win = new TestPage();
            win.Show();
        }

        private void btnPage32_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestPage win = new TestPage();
            win.Show();
        }

        private void btnPage41_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestPage win = new TestPage();
            win.Show();
        }

        private void btnPage42_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestPage win = new TestPage();
            win.Show();
        }

        private void btnPage51_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestPage win = new TestPage();
            win.Show();
        }

        private void btnPage52_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestPage win = new TestPage();
            win.Show();
        }

        private void btnPage61_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestPage win = new TestPage();
            win.Show();
        }

        private void btnPage62_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestPage win = new TestPage();
            win.Show();
        }

        private void btncloseandopen_Click(object sender, EventArgs e)
        {
            if (Hidden == true)
            {
                btncloseandopen.Image = Image.FromFile(@"..\..\Images\close.jpg");
                Spanel.Width = 150;
                //panel3.Width = 700;
                Hidden = false;
            }
            else
            {
                btncloseandopen.Image = Image.FromFile(@"..\..\Images\open.jpg");
                Spanel.Width = 0;
                //panel3.Width = 0;
                Hidden = true;
            }
        }
    }
}
