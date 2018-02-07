using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class quoteForm : Form
    {
        public quoteForm()
        {
            InitializeComponent();
            this.Text = "View Quote";
            fillDatatable();
            dataGridView1.Enabled = false;
        }

        public void fillDatatable()
        {
            String line;
            try
            {
                StreamReader file = new StreamReader(@"quotes.txt");
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    String[] rowData = line.Split(',');
                    dataGridView1.Rows.Add(rowData);
                }
                file.Close();
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
            
        }
    }
}
