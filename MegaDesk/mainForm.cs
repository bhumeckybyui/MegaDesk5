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
    public partial class mainForm : Form
    {
        newQuote nq;
        quoteForm vq;
        quoteSearchForm sq;
        public mainForm()
        {
            InitializeComponent();
            this.Text = "Mega Desk";
            nq = new newQuote();
            vq = new quoteForm();
            sq = new quoteSearchForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            vq.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            sq.ShowDialog();
            this.Show();
        }
    }
}
