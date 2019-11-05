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
        Target target = new Target(30, 305, 100, 100, true, "makaron");
        Target target1 = new Target(130, 305, 100, 100, true, "makaron");

        Pen Black = new Pen(Color.Black, 1);
        Pen White = new Pen(Color.AliceBlue, 1);


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
            bullet.hitbox(target);
            bullet.hitbox(target1);

            if (bullet.shoot == true)
            {
                bullet.move();
               
            }
            else
            {
                bullet.x = shooter.x;
                bullet.y = 660;
            }

            
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            drawing();
            Invalidate();
        }

    

     

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            bullet.shoot = true;
           
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

           
            e.Graphics.DrawImage(new Bitmap("fork.png"), shooter.x, shooter.y, shooter.width, shooter.height);
            e.Graphics.DrawRectangle(Black, target.x, target.y, target.width, target.height);
            e.Graphics.DrawRectangle(Black, target1.x, target1.y, target1.width, target1.height);
            e.Graphics.DrawRectangle(Black, 30,150, 700, 610);
           
           
            if (bullet.shoot == true )
            {
                e.Graphics.DrawImage(new Bitmap("peas.png"), bullet.x, bullet.y, bullet.width, bullet.height);
              

            }
           

           


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
