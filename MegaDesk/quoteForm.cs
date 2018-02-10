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
    public partial class QuoteForm : Form
    {
        public QuoteForm()
        {
            InitializeComponent();
            this.Text = "View Quote";
            fillDatatable();
            dataGridView1.Enabled = false;
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

                foreach(Desk d in q.quotes)
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

                


            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
            
        }
    }
}
