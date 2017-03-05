using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Networks_Implementations
{
    public partial class Form1 : Form
    {
        DataReader Data;
        Graphics ThePanelGraphics;
        Brush BlueBrush = (Brush)Brushes.Blue;
        Brush RedBrush = (Brush)Brushes.Red;
        Brush GreenBrush = (Brush)Brushes.Green;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data = new DataReader();

            ThePanelGraphics = panel1.CreateGraphics();

            comboBox1.Items.Add("Feature 1");
            comboBox1.Items.Add("Feature 2");
            comboBox1.Items.Add("Feature 3");
            comboBox1.Items.Add("Feature 4");

            comboBox2.Items.Add("Feature 1");
            comboBox2.Items.Add("Feature 2");
            comboBox2.Items.Add("Feature 3");
            comboBox2.Items.Add("Feature 4");

        }

        private void DrawDiscretePoints(object sender, EventArgs e)
        {
            ThePanelGraphics.FillRectangle(BlueBrush, 50, 50, 5, 5);          
        }


    }
}
