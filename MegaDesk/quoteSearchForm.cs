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
    public partial class quoteSearchForm : Form
    {
        public quoteSearchForm()
        {
            InitializeComponent();
            this.Text = "Search Quotes";
            dataGridView1.Enabled = false;

            DataTable dt1 = new DataTable();
            DataColumn dc1 = new DataColumn("Values");
            dt1.Columns.Add(dc1);

            dt1.Rows.Add("All Types");
            dt1.Rows.Add("Laminated");
            dt1.Rows.Add("Oak");
            dt1.Rows.Add("Rosewood");
            dt1.Rows.Add("Veneer");
            dt1.Rows.Add("Pine");

            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "Values";
            comboBox1.ValueMember = "Values";

        }

        public void fillDatatable()
        {
            String line;
            //clear out the data first
            dataGridView1.Rows.Clear();
            try
            {
                //
                StreamReader file = new StreamReader(@"quotes.txt");
                while ((line = file.ReadLine()) != null)
                {
                    

                    String[] rowData = line.Split(',');

                    dataGridView1.Rows.Add(rowData);
                }
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }

        public void fillDatatable(String search)
        {
            Console.WriteLine(search);
            String line;
            //clear out the data first
            dataGridView1.Rows.Clear();
            
            try
            {
                StreamReader file = new StreamReader(@"quotes.txt");
                while ((line = file.ReadLine()) != null)
                {

                    if (line.Contains(search))
                    { 

                        String[] rowData = line.Split(',');
                        dataGridView1.Rows.Add(rowData);

                    }
                }
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex > 0)
            {
                fillDatatable(comboBox1.SelectedValue.ToString());
            }
            else
            {
                fillDatatable();
            }
        }
        
    }
}
