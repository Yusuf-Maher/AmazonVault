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

        string[] names = {"Smile"};
        string[] images = { "download.png" };
        int[] prices = {2};
        float[,] ratings = { { 3f } };
        string[,] reviews = { { "Very good" } };

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Display the products
            Point p1 = new Point(20, 100);
            int spacing = 20;
            for (int i = 0; i < images.Length; i++) {
                if (p1.X + spacing > this.Width) {
                    p1.X = 20;
                    p1.Y += spacing;
                }
                Image productImage = Image.FromFile(@"..\..\Resources\" + images[i]);
                Label productName = new Label { Location = new Point(p1.X+productImage.Width/4, p1.Y + productImage.Height + 50), AutoSize = true, Text = names[i], Font = new Font("Arial", 12) };
                float averageRating = findAverageRating(i);
                int scale = 10;
                int increment = 5;
                int starsWidth = 10*(int)(86f/(float)scale)+increment*5;
                int currX = 0;
                for (float n = 0; n < 5; n+=0.5f) {
                    string star;
                    
                    if (Math.Floor(n) == n) {
                        if (n > averageRating) {
                            star = "leftHalfEmpty.png";
                        } else {
                            MessageBox.Show(Convert.ToString(n) + "n");
                            star = "leftHalfFilled.png";
                        }
                        currX += increment;
                    } else {
                        if (n > averageRating) {
                            star = "rightHalfEmpty.png";
                        } else {
                            star = "rightHalfFilled.png";
                        }
                    }
                    currX += (int)(86f/(float)scale);
                    //here
                    Image starImage = Image.FromFile(@"..\..\Resources\" + star);
                    starImage = (Image)(new Bitmap(starImage, new Size(starImage.Width/scale, starImage.Height/scale)));
                    e.Graphics.DrawImage(starImage, productName.Location.X+currX-starsWidth/2, p1.Y + productImage.Height + 10);
                }
                e.Graphics.DrawImage(productImage, p1);
                Controls.Add(productName);
                p1.X += spacing;
            }
        }

        private float findAverageRating(int productNumber) {
            float average = 0;
            for (int i = 0; i < ratings.GetLength(productNumber); i++) {
                average += ratings[productNumber, i];
            }
            average /= ratings.GetLength(productNumber);
            return (float)(Math.Round(average) + Math.Floor(average))/2;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            this.Invalidate();
            //Sort function
        }
    }
}
