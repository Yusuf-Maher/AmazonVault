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
        string[] items =
        {
            "Stainless steel water bottle.jpg",
            "Yoga mat.jpg",
            "Bluetooth earbuds.png",
            "Desk organizer.jpg",
            "Neck Travel Pillow.jpg",
            "Aromatherapy diffuser.jpg",
            "Portable Charger.png",
            "Resistance band.jpg",
            "Electric kettle.png",
            "Backpack.jpg",
            "Sketchbook.jpg",
            "Resistance training ropes.jpg",
            "Handheld vacuum cleaner.jpg",
            "LED desk lamp.jpg",
            "Portable speaker.jpg",
            "Laptop stand.jpg",
            "Essential oil set.jpg",
            "Smartwatch.jpg",
            "Insulated lunch box.jpg",
            "Jump rope.jpg",
            "USB flash drive.jpg",
            "Sleeping mask.jpg",
            "Wall calender.jpg",
            "Umbrella.png",
            "Travel mug.jpg",
            "Running shoes.png",
            "Mouse.jpg",
            "Sunglasses.png",
            "Plant pot.png",
            "Magnetic fridge organizer.jpg",
            "Foam roller.jpg",
            "Wireless charging pad.jpg",
            "Mason jars.jpg",
            "Fitness tracker.jpg",
            "Corkscrew.jpg",
            "Herb garden kit.jpg",
            "Hand sanitizer dispenser.jpg",
            "Rolling pin.jpg",
            "Instant pot.jpg",
            "Resistance loop bands.jpg",
            "Stainless Steal Mixing Bowl.jpg",
            "Digital kitchen scale.jpg",
            "Portable power bank.jpg",
            "Laptop sleeve.png",
            "Electric Toothbrush.png",
            "Resistance training set.jpg",
            "USB-C hub.jpg",
            "Coffee grinder.jpg",
            "Bluetooth speaker.jpg",
            "Wall clock.jpg",
            "Wireless headphones.jpg",
            "Salad spinner.jpg",
            "Travel toiletry bag.jpg",
            "Dry erase board.jpg",
            "Knife set.jpg",
            "Tea infuser.jpg",
            "Cocktail shaker set.jpg",
            "Foam mattress topper.jpg",
            "Yoga block.jpg",
            "Portable blender.jpg",
            "Wireless keyboard.jpg",
        };
        float[] prices = 
        {
            19.50f,
            24.75f,
            39.80f,
            14.25f,
            12.49f,
            29.90f,
            19.20f,
            10.85f,
            34.60f,
            49.75f,
            8.35f,
            21.45f,
            49.20f,
            39.30f,
            29.80f,
            24.40f,
            16.75f,
            99.20f,
            17.45f,
            7.80f,
            8.90f,
            6.70f,
            11.25f,
            16.80f,
            14.50f,
            59.40f,
            12.80f,
            19.60f,
            14.20f,
            21.60f,
            16.95f,
            24.30f,
            9.75f,
            39.25f,
            7.85f,
            29.50f,
            19.30f,
            12.49f,
            79.75f,
            15.89f,
            29.65f,
            19.78f,
            29.50f,
            14.95f,
            24.73f,
            39.87f,
            29.91f,
            24.57f,
            49.62f,
            19.82f,
            59.44f,
            12.36f,
            19.99f,
            9.73f,
            39.29f,
            7.55f,
            19.24f,
            49.60f,
            10.91f,
            39.35f,
            29.77f
        };
        float[][] ratings = 
        {
            new float[] { 4.9f, 2.0f, 4.8f },
            new float[] { 4.7f, 2.5f, 4.8f },
            new float[] { 4.7f, 3.5f, 2.5f },
            new float[] { 4.8f, 3.5f, 2.0f },
            new float[] { 4.7f, 3.0f, 2.5f },
            new float[] { 4.8f, 2.0f, 3.0f },
            new float[] { 4.7f, 2.5f, 3.0f },
            new float[] { 4.8f, 2.0f, 3.0f },
            new float[] { 4.7f, 3.0f, 2.5f },
            new float[] { 4.7f, 2.0f, 3.0f },
            new float[] { 4.7f, 3.0f, 4.5f },
            new float[] { 4.6f, 2.0f, 3.0f },
            new float[] { 4.7f, 2.5f, 3.0f },
            new float[] { 4.5f, 3.0f, 2.5f },
            new float[] { 4.6f, 3.0f, 2.5f },
            new float[] { 4.7f, 3.0f, 2.0f },
            new float[] { 4.5f, 2.5f, 3.0f },
            new float[] { 4.6f, 2.5f, 3.0f },
            new float[] { 4.6f, 2.0f, 3.0f },
            new float[] { 4.5f, 3.0f, 2.5f },
            new float[] { 4.6f, 2.5f, 2.0f },
            new float[] { 4.5f, 2.5f, 2.0f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.5f, 2.0f },
            new float[] { 4.5f, 2.0f, 2.5f },
            new float[] { 4.7f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.5f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.7f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.5f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.5f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.7f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.5f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.5f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.5f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.5f, 2.0f, 2.5f },
            new float[] { 4.5f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.6f, 2.0f, 2.5f },
            new float[] { 4.1f, 2.9f, 2.5f },
            new float[] { 4.1f, 2.3f, 2.5f },
            new float[] { 4.1f, 2.1f, 2.5f },
            new float[] { 4.7f, 3.0f, 2.0f }
        };
        string[][] reviews = 
        {
            new string[] { "Keeps water cold for hours, perfect for outdoor activities.", "Cap broke easily, disappointed with the durability.", "Love the wide mouth design, makes it easy to clean." },
            new string[] { "Provides excellent cushioning for yoga practice. Love the non-slip surface.", "Mat tore after a few uses, disappointed with the durability.", "Thick and comfortable, perfect for floor exercises too." },
            new string[] { "Great sound quality and comfortable fit. Love the wireless design.", "Earbuds fell out during workouts, not suitable for intense activities.", "Battery life is shorter than advertised, disappointed with the performance." },
            new string[] { "Plenty of compartments for organizing office supplies. Love the sleek design.", "Drawer gets stuck frequently, difficult to open and close. Needs smoother operation.", "Material is flimsy, disappointed with the overall quality." },
            new string[] { "Provides excellent support for long flights, love the soft fabric.", "Pillow loses shape quickly, needs better support.", "Material is itchy, uncomfortable for prolonged use." },
            new string[] { "Creates a calming atmosphere with soothing scents. Love the LED lights.", "Stopped working after a week, disappointed with the durability.", "Diffuser is too small, doesn't fill the room with scent effectively." },
            new string[] { "Charges my phone quickly and fits in my pocket. Perfect for travel.", "Charging cable frayed easily, disappointed with the durability.", "Battery drains quickly, doesn't hold charge well." },
            new string[] { "Versatile for different workouts, durable material. Love the variety of resistance levels.", "Bands snapped during use, safety concern.", "Anchors are too small, bands slip out easily. Needs better design." },
            new string[] { "Boils water quickly and looks stylish on the kitchen counter. Love the convenience.", "Difficult to clean, water stains are hard to remove.", "Kettle leaked from the bottom, disappointed with the quality." },
            new string[] { "Spacious and comfortable to wear. Love the padded straps.", "Zippers broke after a month, disappointed with the durability.", "Material is too thin, not suitable for heavy loads." },
            new string[] { "Perfect for artists of all levels, sturdy cover and good paper quality.", "Pages are too thin, markers bleed through easily. Needs thicker paper.", "Love the portable size, great for sketching on the go." },
            new string[] { "Effective for full-body workouts, durable construction. Love the versatility.", "Ropes frayed quickly, disappointed with the durability.", "Anchors don't hold well, ropes slip out during use. Needs better grip." },
            new string[] { "Compact and powerful, perfect for cleaning small messes. Love the portability.", "Suction power is weak, struggles with picking up debris. Disappointing performance.", "Battery life is short, needs frequent recharging." },
            new string[] { "Versatile lighting options and energy-efficient. Helps reduce eye strain.", "Lamp flickers occasionally, inconsistent performance. Needs better quality control.", "Base is unstable, lamp tips over easily. Needs a sturdier design." },
            new string[] { "Impressive sound output for its size, great for outdoor gatherings.", "Speaker distorts at high volumes, disappointing audio quality.", "Battery drains quickly, doesn't last as long as advertised. Needs better battery life." },
            new string[] { "Ergonomic design and sturdy build, provides better posture. Love the adjustability.", "Stand is wobbly, doesn't feel secure. Needs better stability.", "Plastic clips broke easily, disappointed with the durability." },
            new string[] { "Variety of fragrances and good quality oils. Perfect for relaxation.", "Oils have a strong chemical smell, not natural. Disappointing scent.", "Bottles leaked during shipping, packaging needs improvement." },
            new string[] { "Sleek design and intuitive interface. Tracks fitness metrics accurately.", "Battery life is short, needs frequent charging.", "Heart rate monitor is inaccurate, disappointing performance." },
            new string[] { "Keeps food fresh and well-insulated, perfect for on-the-go meals. Love the spaciousness.", "Lunch box arrived dented, disappointed with the packaging.", "Insulation doesn't work well, food doesn't stay warm. Needs better heat retention." },
            new string[] { "Durable and adjustable length, great for cardio workouts. Love the smooth rotation.", "Rope tangles easily, frustrating to use. Needs better tangle resistance.", "Handles are uncomfortable to grip, needs better ergonomic design." },
            new string[] { "Large storage capacity and reliable performance. Perfect for storing files.", "Data transfer speed is slow, takes too long to copy files. Needs faster performance.", "Flash drive corrupted after a few uses, disappointed with the reliability." },
            new string[] { "Soft and lightweight material, blocks out light effectively for better sleep.", "Mask feels too tight, uncomfortable to wear. Needs better fit.", "Elastic band snapped after a few uses, poor durability." },
            new string[] { "Large and easy-to-read dates, great for organizing schedules.", "Calendar arrived damaged, disappointed with the packaging.", "Dates are not aligned properly, printing quality needs improvement." },
            new string[] { "Durable construction and wind-resistant design. Keeps you dry on rainy days.", "Umbrella flipped inside out in the wind, not as wind-resistant as claimed.", "Handle broke after minimal use, disappointed with the durability." },
            new string[] { "Keeps beverages hot for hours, fits in most cup holders. Ideal for commuting.", "Mug leaks when tilted, disappointed with the poor sealing.", "Lid broke easily, needs better quality materials." },
            new string[] { "Great support and cushioning, perfect for running and workouts.", "Shoes caused blisters, uncomfortable fit. Needs better sizing.", "Outsole wore out quickly, disappointed with the durability." },
            new string[] { "Responsive and ergonomic design, works well for everyday use.", "Scroll wheel stopped working after a week, disappointed with the durability.", "Mouse cursor jumps erratically, needs better tracking." },
            new string[] { "Stylish and affordable, provides good UV protection.", "Lenses scratched easily, disappointed with the durability.", "Frame broke after minimal use, poor build quality." },
            new string[] { "Modern design and sturdy construction, perfect for indoor plants.", "Pot arrived cracked, disappointed with the packaging.", "Paint chipped off easily, poor quality finish." },
            new string[] { "Convenient organization for the fridge, holds various items securely.", "Magnets are weak, organizer falls off easily. Needs stronger magnets.", "Plastic compartments broke after minimal use, poor durability." },
            new string[] { "Relieves muscle tension and soreness effectively. Durable material and compact size.", "Foam is too soft, doesn't provide enough pressure. Needs firmer density.", "Roller lost shape quickly, disappointed with the durability." },
            new string[] { "Convenient and easy to use. Charges devices quickly with no hassle of cords.", "Charging is slow and inconsistent. Needs faster and more reliable performance.", "Pad stopped working after a few weeks, disappointed with the durability." },
            new string[] { "Versatile and durable jars, perfect for storing food and beverages.", "Lids don't seal properly, liquids leaked. Needs better quality lids.", "Glass broke easily, disappointed with the fragility." },
            new string[] { "Tracks activity and sleep patterns accurately. Easy to use and sync with the app.", "Step count and heart rate monitor are inaccurate. Needs better precision.", "Tracker stopped syncing with the app, disappointed with the reliability." },
            new string[] { "Efficient and easy-to-use corkscrew. Removes corks quickly without much effort.", "Corkscrew broke after a few uses, disappointed with the durability.", "Not suitable for synthetic corks, disappointed with the performance." },
            new string[] { "Comes with everything needed to start an herb garden. Easy to use and maintain.", "Seeds didn't sprout, disappointed with the quality. Needs better seed selection.", "Pots cracked easily, disappointed with the durability." },
            new string[] { "Convenient and touch-free dispenser. Perfect for home or office use.", "Dispenser leaked, wasted sanitizer. Needs better sealing.", "Stopped dispensing after minimal use, disappointed with the reliability." },
            new string[] { "Sturdy and lightweight rolling pin. Rolls dough evenly for baking.", "Dough sticks to the surface, needs smoother finish.", "Handle broke easily, disappointed with the durability." },
            new string[] { "Versatile and time-saving kitchen appliance. Cooks meals quickly and efficiently.", "Pressure release valve malfunctioned, unsafe. Needs better quality control.", "Pot stopped working after minimal use, disappointed with the durability." },
            new string[] { "Versatile and durable bands. Ideal for toning and strengthening exercises.", "Bands are too tight, uncomfortable to use. Needs better elasticity.", "Bands snapped after minimal use, disappointed with the durability." },
            new string[] { "Durable and versatile mixing bowls. Perfect for cooking and baking tasks.", "Scratched easily and lost shine. Needs better quality steel.", "Bowls dented easily, disappointed with the durability." },
            new string[] { "Accurate and easy-to-use scale. Perfect for precise cooking and baking.", "Measurements are inconsistent. Needs better calibration.", "Scale malfunctioned after minimal use, disappointed with the reliability." },
            new string[] { "Reliable power bank with fast charging capabilities. Great for charging devices on the go.", "Failed to hold a charge after a few weeks. Needs longer-lasting battery.", "Bank stopped charging devices after minimal use, disappointed with the reliability." },
            new string[] { "Slim and protective sleeve. Fits my laptop perfectly and provides good cushioning.", "Too tight for my laptop, didn't fit. Needs larger size options.", "Sleeve tore easily, disappointed with the durability." },
            new string[] { "Versatile set for full-body workouts. Durable bands and comfortable handles.", "Handles broke easily, poor quality. Needs sturdier construction.", "Set missing components upon arrival, disappointed with the packaging." },
            new string[] { "Effective cleaning and long battery life. Leaves teeth feeling fresh and clean.", "Stopped working after a week. Needs better durability.", "Brush head fell off easily, disappointed with the attachment mechanism." },
            new string[] { "Convenient hub for expanding USB-C ports. Works well with my laptop and other devices.", "Ports stopped working after a month. Needs better durability.", "Hub failed to connect to devices consistently, disappointed with the reliability." },
            new string[] { "Compact and efficient grinder. Grinds coffee beans to perfection for a fresh brew.", "Inconsistent grind size, doesn't work well. Needs better performance.", "Grinder motor burned out quickly, disappointed with the durability." },
            new string[] { "Impressive sound output and long battery life. Perfect for indoor and outdoor use.", "Poor sound quality, lacks bass. Needs better audio performance.", "Speaker stopped charging after minimal use, disappointed with the reliability." },
            new string[] { "Stylish and easy-to-read clock. Adds a decorative touch to any room.", "Stopped working after a month. Needs better durability.", "Clock hands fell off easily, disappointed with the construction." },
            new string[] { "Clear sound quality and comfortable fit. Blocks out external noise effectively.", "Poor Bluetooth connectivity, frequently drops. Needs better connection stability.", "Headphones stopped charging after minimal use, disappointed with the reliability." },
            new string[] { "Efficient and easy-to-use salad spinner. Dries greens quickly and thoroughly.", "Plastic cracked after a few uses. Needs better durability.", "Spinner broke easily, disappointed with the construction." },
            new string[] { "Durable and spacious toiletry bag. Fits all my essentials for travel.", "Zipper broke on the first trip. Needs better zipper quality.", "Bag tore easily, disappointed with the durability." },
            new string[] { "Smooth writing surface and easy to erase. Perfect for home or office use.", "Markers dried out quickly, poor quality. Needs better marker performance.", "Board arrived damaged, disappointed with the packaging." },
            new string[] { "Sharp and durable knives. Comes with a variety of blades for different tasks.", "Blades dulled after a few uses. Needs better blade quality.", "Knives rusted easily, disappointed with the material." },
            new string[] { "Convenient and easy-to-clean tea infuser. Perfect for loose leaf tea lovers.", "Mesh broke loose, leaves got into my tea. Needs better mesh quality.", "Infuser leaked, disappointed with the design." },
            new string[] { "High-quality and stylish shaker set. Perfect for crafting cocktails at home.", "Lid leaked, made a mess. Needs better seal.", "Shaker dented easily, disappointed with the durability." },
            new string[] { "Provides excellent cushioning and support. Improves the comfort of my mattress.", "Too thin, didn't add much comfort. Needs better thickness.", "Topper tore easily, disappointed with the durability." },
            new string[] { "Sturdy and lightweight block. Helps with yoga poses and stretches.", "Not firm enough, didn't provide support. Needs better density.", "Block warped easily, disappointed with the material." },
            new string[] { "Powerful blender for smoothies on the go. Portable and easy to clean.", "Blades got stuck, couldn't blend properly. Needs better blade design.", "Blender motor burned out quickly, disappointed with the reliability." },
            new string[] { "Quiet and responsive typing experience. Ergonomic design for comfortable use.", "Keys are not responsive. Needs better key quality.", "Keyboard stopped connecting to devices after a few weeks. Disappointed with reliability." }
        };

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
            e.Graphics.FillRectangle(myBrush, new Rectangle { Location = new Point(0, 0), Height = 165, Width = this.Width });
            myBrush = new SolidBrush(Color.SlateGray);
            //Display the products
            int start = 40;
            Point p1 = new Point(40, 200);
            int spacing = 150;
            for (int i = 0; i < 10; i++) {
                if (p1.X + spacing > this.Width) {
                    p1.X = start;
                    p1.Y += 200;
                }
                
                Rectangle productCover = new Rectangle { Location = new Point(p1.X - 14, p1.Y - 14), Height = 165, Width = 122};
                e.Graphics.FillRectangle(myBrush, productCover);
                Image productImage = Image.FromFile(@"..\..\Resources\" + items[i]);
                productImage = (Image)(new Bitmap(productImage, new Size(productCover.Width-30, productCover.Height-74)));
                //fix
                Label productName = new Label {AutoSize = true, Text = items[i].Substring(0, items[i].Length-4), Font = new Font("Arial", 12) };
                productName.Location = new Point(productCover.X+5, p1.Y + productImage.Height + 35);
                productName.Click += (s, args) => product(productName, e, i);
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
                    e.Graphics.DrawImage(starImage, productCover.X + currX - 4, p1.Y + productImage.Height + 10);
                }
                e.Graphics.DrawImage(productImage, p1);
                /*Button productClick = new Button {Location = productCover.Location, Height = productCover.Height, Width = productCover.Width, BackColor = Color.Transparent};
                productClick.FlatStyle = FlatStyle.Flat;
                productClick.FlatAppearance.MouseDownBackColor = Color.Transparent;
                productClick.FlatAppearance.MouseOverBackColor = Color.Transparent;
                productClick.Click += (s, args) => product(productClick, e, i);
                Controls.Add(productClick);*/
                p1.X += spacing;
            }
        }

        private void product(object sender, PaintEventArgs e, int productNum) {
            textBox1.Text = "";
            
            //Display product
        }

        private void cart() {
            //Show cart
        }

        private float findAverageRating(int productNumber) {
            float average = 0;
            for (int i = 0; i < ratings[productNumber].Length; i++) {
                average += ratings[productNumber][i];
            }
            average /= ratings[productNumber].Length;
            return (float)(Math.Round(average, MidpointRounding.AwayFromZero) + Math.Floor(average))/2;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Invalidate();
            //Sort function
        }
    }
}
