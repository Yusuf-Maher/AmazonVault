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
        float[,] ratings = { { 4f } };
        string[,] reviews = { { "Very good" } };

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            main(sender, e);
        }

        private void main(object sender, PaintEventArgs e)
        {
            textBox1.Location = new Point(this.Width/2-textBox1.Width/2, textBox1.Location.Y);
            SolidBrush myBrush = new SolidBrush(Color.Black);
            Rectangle top = new Rectangle { Location = new Point(0, 0), Height = 165, Width = this.Width};
            e.Graphics.FillRectangle(myBrush, top);
            myBrush = new SolidBrush(Color.SlateGray);
            //Display the products
            int start = 40;
            Point p1 = new Point(40, 200);
            int spacing = 20;
            for (int i = 0; i < images.Length; i++) {
                if (p1.X + spacing > this.Width) {
                    p1.X = start;
                    p1.Y += spacing;
                }
                Rectangle productCover = new Rectangle { Location = new Point(p1.X - 14, p1.Y - 14), Height = 165, Width = 122};
                e.Graphics.FillRectangle(myBrush, productCover);
                Image productImage = Image.FromFile(@"..\..\Resources\" + images[i]);
                productImage = (Image)(new Bitmap(productImage, new Size(productCover.Width-30, productCover.Height-74)));
                Label productName = new Label { Location = new Point(p1.X+productImage.Width/4, p1.Y + productImage.Height + 35), AutoSize = true, Text = names[i], Font = new Font("Arial", 12) };
                productName.Click += (s, args) => product(productName, args, i);
                Controls.Add(productName);
                float averageRating = findAverageRating(i);
                int scale = 10;
                int increment = 5;
                int starsWidth = 8*(int)(86f/(float)scale)+increment*5;
                int currX = 0;
                for (float n = 0.5f; n <= 5; n+=0.5f) {
                    string star;
                    if (Math.Floor(n) != n) {
                        if (n > averageRating) {
                            star = "leftHalfEmpty.png";
                        } else {
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

                    Image starImage = Image.FromFile(@"..\..\Resources\" + star);
                    starImage = (Image)(new Bitmap(starImage, new Size(starImage.Width/scale, starImage.Height/scale)));
                    e.Graphics.DrawImage(starImage, productName.Location.X+currX-starsWidth/2, p1.Y + productImage.Height + 10);
                }
                e.Graphics.DrawImage(productImage, p1);
                Button productClick = new Button {Location = productCover.Location, Height = productCover.Height, Width = productCover.Width, BackColor = Color.Transparent};
                productClick.FlatStyle = FlatStyle.Flat;
                productClick.FlatAppearance.MouseDownBackColor = Color.Transparent;
                productClick.FlatAppearance.MouseOverBackColor = Color.Transparent;
                productClick.Click += (s, args) => product(productClick, args, i);
                Controls.Add(productClick);
                p1.X += spacing;
            }
        }

        private void product(object sender, EventArgs e, int productNum) {
            //Display product
        }

        private void cart() {
            //Show cart
        }

        private float findAverageRating(int productNumber) {
            float average = 0;
            for (int i = 0; i < ratings.GetLength(productNumber); i++) {
                average += ratings[productNumber, i];
            }
            average /= ratings.GetLength(productNumber);
            return (float)(Math.Round(average, MidpointRounding.AwayFromZero) + Math.Floor(average))/2;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Invalidate();
            //Sort function
        }
    }
}
