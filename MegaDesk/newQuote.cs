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
    public partial class newQuote : Form
    {
       
        public newQuote()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void newQuot_Load(object sender, EventArgs e)
        {


            //make error message box not show anything
            errorMessageSpot.Text = "";

            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("Number");
            dt.Columns.Add(dc1);

            dt.Rows.Add("0");
            dt.Rows.Add("1");
            dt.Rows.Add("2");
            dt.Rows.Add("3");
            dt.Rows.Add("4");
            dt.Rows.Add("5");
            dt.Rows.Add("6");
            dt.Rows.Add("7");

            numberOfDrwaersCB.DataSource = dt;
            numberOfDrwaersCB.DisplayMember = "Number";
            numberOfDrwaersCB.ValueMember = "Number";

            //set this to show only DATA not be able to type
            numberOfDrwaersCB.DropDownStyle = ComboBoxStyle.DropDownList;

            //add more datatables for combo boxes
            DataTable dt2 = new DataTable();
            DataColumn dc2 = new DataColumn("Numbers");
            dt2.Columns.Add(dc2);

            for(int i = 24; i < 97; i = i + 6)
            {
                dt2.Rows.Add(i);
            }
            

            widthCB.DataSource = dt2;
            widthCB.DisplayMember = "Number";
            widthCB.ValueMember = "Numbers";

            //add more databsel tof combo boxes
            DataTable dt3 = new DataTable();
            DataColumn dc3 = new DataColumn("Numbers");
            dt3.Columns.Add(dc3);

            for (int i = 12; i < 49; i = i + 2)
            {
                dt3.Rows.Add(i);
            }


            depthCB.DataSource = dt3;
            depthCB.DisplayMember = "Number";
            depthCB.ValueMember = "Numbers";

            //surface combobox
            DataTable dt4 = new DataTable();
            DataColumn dc4 = new DataColumn("Values");
            dt4.Columns.Add(dc4);

            dt4.Rows.Add("Laminated");
            dt4.Rows.Add("Oak");
            dt4.Rows.Add("Rosewood");
            dt4.Rows.Add("Veneer");
            dt4.Rows.Add("Pine");

            surfaceLB.DataSource = dt4;
            surfaceLB.DisplayMember = "Values";
            surfaceLB.ValueMember = "Values";

            //add the info for rush drop box
            DataTable dt5 = new DataTable();
            DataColumn dc5 = new DataColumn("Values");
            dt5.Columns.Add(dc5);

            dt5.Rows.Add("No Rush");
            dt5.Rows.Add("3 Day");
            dt5.Rows.Add("5 Day");
            dt5.Rows.Add("7 Day");

            rushOrderCB.DataSource = dt5;
            rushOrderCB.DisplayMember = "Values";
            rushOrderCB.ValueMember = "Values";
            //set so can't type into this combo box
            rushOrderCB.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void numberOfDrwaersCB_KeyUp(object sender, KeyEventArgs e)
        {
            
            try
            {
                int testing = int.Parse(numberOfDrwaersCB.Text);
                if(testing < 0 || testing > 7)
                {
                    errorMessageSpot.Text = "Incorrect Value Entered: \n Values Must be Between 0 AND 7";
                    numberOfDrwaersCB.BackColor = Color.Red;
                    numberOfDrwaersCB.Focus();
                    pictureBox.Image = Properties.Resources.error;
                    pictureBox.Refresh();
                    pictureBox.Visible = true;
                }
            } catch (Exception ex)
            {
                errorMessageSpot.Text = "ERROR: ID 10 t  \nOnly Whole Numbers";
                
                numberOfDrwaersCB.BackColor = Color.Red;
                numberOfDrwaersCB.Focus();

            }  

        }

        private void numberOfDrwaersCB_KeyDown(object sender, KeyEventArgs e)
        {
            errorMessageSpot.Text = "";
            numberOfDrwaersCB.BackColor = default(Color);
            setPicture();
        }

        private void numberOfDrwaersCB_MouseClick(object sender, MouseEventArgs e)
        {
            errorMessageSpot.Text = "";
            numberOfDrwaersCB.BackColor = default(Color);
        }

        private void widthCB_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double testing = double.Parse(widthCB.Text);
                if (testing < 24 || testing > 96)
                {
                    errorMessageSpot.Text = "Incorrect Value Entered: \n Values Must be Between 24 AND 96";
                    widthCB.BackColor = Color.Red;
                    pictureBox.Image = Properties.Resources.error;
                    pictureBox.Refresh();
                    pictureBox.Visible = true;

                }
            }
            catch (Exception ex)
            {
                errorMessageSpot.Text = "ERROR: ID 10 t  \nOnly Numbers";
                widthCB.BackColor = Color.Red;
                pictureBox.Image = Properties.Resources.error;
                pictureBox.Refresh();
                pictureBox.Visible = true;


            }
        }

        private void widthCB_KeyDown(object sender, KeyEventArgs e)
        {
            errorMessageSpot.Text = "";
            widthCB.BackColor = default(Color);
            setPicture();
        }

        private void depthCB_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double testing = double.Parse(depthCB.Text);
                if (testing < 12 || testing > 48)
                {
                    errorMessageSpot.Text = "Incorrect Value Entered: \n Values Must be Between 12 AND 48";
                    depthCB.BackColor = Color.Red;
                    pictureBox.Image = Properties.Resources.error;
                    pictureBox.Refresh();
                    pictureBox.Visible = true;

                }
            }
            catch (Exception ex)
            {
                errorMessageSpot.Text = "ERROR: ID 10 t  \nOnly Numbers";
                depthCB.BackColor = Color.Red;
                pictureBox.Image = Properties.Resources.error;
                pictureBox.Refresh();
                pictureBox.Visible = true;

            }
        }

        private void depthCB_KeyDown(object sender, KeyEventArgs e)
        {
            errorMessageSpot.Text = "";
            depthCB.BackColor = default(Color);
            setPicture();


        }

        private void setPicture()
        {
            String tmp = surfaceLB.GetItemText(surfaceLB.SelectedItem);
            switch (tmp)
            {
                case "Oak":
                    pictureBox.Image = Properties.Resources.oak;
                    break;
                case "Laminated":
                    pictureBox.Image = Properties.Resources.laminate;
                    break;

                case "Rosewood":
                    pictureBox.Image = Properties.Resources.rosewood;
                    break;
                case "Veneer":
                    pictureBox.Image = Properties.Resources.veneer;
                    break;
                case "Pine":
                    pictureBox.Image = Properties.Resources.pinewood;
                    break;


            }
        }

        private void setPicture(object sender, EventArgs e)
        {
            setPicture();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
