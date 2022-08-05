using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Paint : Form
    {
        Image imgSave;
        ArrayList points;
        bool pencilDown;
        byte choose;
        int x, y;
        public Paint()
        {
            InitializeComponent();
            points = new ArrayList();
            pencilDown = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label12.BackColor = Color.Green;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label12.BackColor = Color.Blue;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label12.BackColor = Color.Red;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label12.BackColor = Color.Yellow;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label12.BackColor = Color.Brown;
        }
        private void label6_Click(object sender, EventArgs e)
        {
            label12.BackColor = Color.Gray;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label12.BackColor = Color.Purple;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label12.BackColor = Color.Pink;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            label12.BackColor = Color.Orange;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label12.BackColor = Color.Black;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label12.BackColor = Color.White;
        }
        private void label14_Click(object sender, EventArgs e)
        {
            label12.BackColor = Color.White;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X,e.Y);
            points.Add(p);
            pencilDown = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            pencilDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Point p = new Point(e.X,e.Y);
            Pen pencil = new Pen(label12.BackColor, label13.Height);
            Rectangle shape = new Rectangle(x,y,e.X-x,e.Y-y);

            if (pencilDown)
            {
                switch (choose)
                {
                    case 0:
                if (points.Count>1)
                {
                    g.DrawLine(pencil,(Point)points[points.Count-1],p);
                    points.Add(p);
                }
                 break;
                    case 1:
                        g.DrawEllipse(pencil,shape); 
                        break;
                    case 2:g.DrawRectangle(pencil, shape);; break;
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label13.Height=trackBar1.Value+1;
        }

        private void Paint_Load(object sender, EventArgs e)
        {
            label13.Height = trackBar1.Value + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            choose = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            choose = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            choose = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = imgSave;
        }
    }
}
