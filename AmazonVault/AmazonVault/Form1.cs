using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AmazonVault
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] names = { };
        string[] images = { "download.png" };
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Image newImage = Image.FromFile(@"..\..\Resources\" + images[0]);
            Point p1 = new Point(10, 10);
            e.Graphics.DrawImage(newImage, p1);
        }
    }
}
