using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace GRA
{
    public partial class Form1 : Form
    {
        Boolean win = false;
        Graphics g;
        Shooter shooter = new Shooter();
        Bullet bullet = new Bullet();
        Pen Pen = new Pen(Color.Black, 3);
        

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            g = CreateGraphics();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void drawing()
        {
            shooter.move();
            if (bullet.shoot == true)
            {
               
                bullet.move();
            }
            else
            {
                bullet.x = shooter.x;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            drawing();
            Invalidate();
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

     

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            bullet.shoot = true;
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("fork.png"), shooter.x, shooter.y, shooter.width, shooter.height);
            e.Graphics.DrawRectangle(Pen, 10,105, 567, 465);
            if (bullet.shoot == true)
            {
                e.Graphics.DrawImage(new Bitmap("peas.png"), bullet.x, bullet.y, bullet.width, bullet.height);
            }
        }
    }
}
