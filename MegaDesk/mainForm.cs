using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainForm : Form
    {
        NewQuote nq;
        QuoteForm vq;
        QuoteSearchForm sq;
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Mega Desk";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            nq = new NewQuote();
            nq.ShowDialog();
            this.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            vq = new QuoteForm();
            vq.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            sq = new QuoteSearchForm();
            sq.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
