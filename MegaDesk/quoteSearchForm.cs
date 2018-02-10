using Newtonsoft.Json;
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
    public partial class QuoteSearchForm : Form
    {
        public QuoteSearchForm()
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
            dataGridView1.Rows.Clear();
            String line;
            try
            {

                StreamReader file = new StreamReader(@"quotes.json");
                Quotes q = null;
                while ((line = file.ReadLine()) != null)
                {
                    q = JsonConvert.DeserializeObject<Quotes>(line); 
                }
                file.Close();


                //add lines to datagrid

                foreach (Desk d in q.quotes)
                {
                    String[] rowData = new String[8];
                    rowData[0] = d.date;
                    rowData[1] = d.name;
                    rowData[2] = d.rushOrder;
                    rowData[3] = d.surfaceType;
                    rowData[4] = d.width.ToString();
                    rowData[5] = d.depth.ToString();
                    rowData[6] = d.drawers.ToString();
                    rowData[7] = d.price.ToString();
                    dataGridView1.Rows.Add(rowData);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }

        public void fillDatatable(String search)
        {
            dataGridView1.Rows.Clear();
            String line;
            try
            {

                StreamReader file = new StreamReader(@"quotes.json");
                Quotes q = null;
                while ((line = file.ReadLine()) != null)
                {
                    
                    q = JsonConvert.DeserializeObject<Quotes>(line);
                    
                }
                file.Close();


                //add lines to datagrid

                foreach (Desk d in q.quotes)
                {
                    String[] rowData = new String[8];
                    rowData[0] = d.date;
                    rowData[1] = d.name;
                    rowData[2] = d.rushOrder;
                    rowData[3] = d.surfaceType;
                    rowData[4] = d.width.ToString();
                    rowData[5] = d.depth.ToString();
                    rowData[6] = d.drawers.ToString();
                    rowData[7] = d.price.ToString();
                    if (rowData[3].Contains(search))
                    {
                        dataGridView1.Rows.Add(rowData);
                    }

                }

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
