namespace MegaDesk
{
    partial class newQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numberOfDrwaersCB = new System.Windows.Forms.ComboBox();
            this.errorMessageSpot = new System.Windows.Forms.Label();
            this.widthCB = new System.Windows.Forms.ComboBox();
            this.depthCB = new System.Windows.Forms.ComboBox();
            this.surfaceLB = new System.Windows.Forms.ListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.rushOrderCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cutomer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Depth ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Surface material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rush order";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 20);
            this.textBox1.TabIndex = 1;
            // 
            // numberOfDrwaersCB
            // 
            this.numberOfDrwaersCB.FormattingEnabled = true;
            this.numberOfDrwaersCB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.numberOfDrwaersCB.Location = new System.Drawing.Point(135, 103);
            this.numberOfDrwaersCB.Name = "numberOfDrwaersCB";
            this.numberOfDrwaersCB.Size = new System.Drawing.Size(121, 21);
            this.numberOfDrwaersCB.TabIndex = 4;
            this.numberOfDrwaersCB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberOfDrwaersCB_KeyDown);
            this.numberOfDrwaersCB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numberOfDrwaersCB_KeyUp);
            this.numberOfDrwaersCB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numberOfDrwaersCB_MouseClick);
            this.numberOfDrwaersCB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.numberOfDrwaersCB_MouseClick);
            // 
            // errorMessageSpot
            // 
            this.errorMessageSpot.AutoSize = true;
            this.errorMessageSpot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageSpot.ForeColor = System.Drawing.Color.Red;
            this.errorMessageSpot.Location = new System.Drawing.Point(13, 282);
            this.errorMessageSpot.Name = "errorMessageSpot";
            this.errorMessageSpot.Size = new System.Drawing.Size(59, 24);
            this.errorMessageSpot.TabIndex = 10;
            this.errorMessageSpot.Text = "errors";
            // 
            // widthCB
            // 
            this.widthCB.FormattingEnabled = true;
            this.widthCB.Location = new System.Drawing.Point(135, 42);
            this.widthCB.Name = "widthCB";
            this.widthCB.Size = new System.Drawing.Size(121, 21);
            this.widthCB.TabIndex = 2;
            this.widthCB.SelectedValueChanged += new System.EventHandler(this.widthCB_SelectedIndexChanged);
            this.widthCB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.widthCB_KeyDown);
            this.widthCB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.widthCB_KeyUp);
            this.widthCB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.widthCB_MouseUp);
            // 
            // depthCB
            // 
            this.depthCB.FormattingEnabled = true;
            this.depthCB.Location = new System.Drawing.Point(135, 70);
            this.depthCB.Name = "depthCB";
            this.depthCB.Size = new System.Drawing.Size(121, 21);
            this.depthCB.TabIndex = 3;
            this.depthCB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.depthCB_KeyDown);
            this.depthCB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.depthCB_KeyUp);
            this.depthCB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.depthCB_MouseUp);
            // 
            // surfaceLB
            // 
            this.surfaceLB.FormattingEnabled = true;
            this.surfaceLB.Location = new System.Drawing.Point(135, 141);
            this.surfaceLB.Name = "surfaceLB";
            this.surfaceLB.Size = new System.Drawing.Size(120, 82);
            this.surfaceLB.TabIndex = 5;
            this.surfaceLB.SelectedIndexChanged += new System.EventHandler(this.setPicture);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::MegaDesk.Properties.Resources.laminate;
            this.pictureBox.Location = new System.Drawing.Point(263, 42);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(232, 222);
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // rushOrderCB
            // 
            this.rushOrderCB.AllowDrop = true;
            this.rushOrderCB.FormattingEnabled = true;
            this.rushOrderCB.Location = new System.Drawing.Point(134, 237);
            this.rushOrderCB.Name = "rushOrderCB";
            this.rushOrderCB.Size = new System.Drawing.Size(121, 21);
            this.rushOrderCB.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rushOrderCB);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.surfaceLB);
            this.Controls.Add(this.depthCB);
            this.Controls.Add(this.widthCB);
            this.Controls.Add(this.errorMessageSpot);
            this.Controls.Add(this.numberOfDrwaersCB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "newQuote";
            this.Text = "newQuot";
            this.Load += new System.EventHandler(this.newQuot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox numberOfDrwaersCB;
        private System.Windows.Forms.Label errorMessageSpot;
        private System.Windows.Forms.ComboBox widthCB;
        private System.Windows.Forms.ComboBox depthCB;
        private System.Windows.Forms.ListBox surfaceLB;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox rushOrderCB;
        private System.Windows.Forms.Button button1;
    }
}