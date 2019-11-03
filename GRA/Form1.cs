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

            if (bullet.shoot == true)
            {
                bullet.move();
               
            }
            else
            {
                bullet.x = shooter.x;
                bullet.y = 485;
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
            Console.WriteLine("co");
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Rectangle excludeRect = new Rectangle(30, 105, 50, 50);
            e.Graphics.DrawImage(new Bitmap("fork.png"), shooter.x, shooter.y, shooter.width, shooter.height);
            e.Graphics.DrawRectangle(Black, target.x, target.y, target.width, target.height);
            e.Graphics.DrawRectangle(Black, 29,104, 557, 465);
           
           
            if (bullet.shoot == true )
            {
                e.Graphics.DrawImage(new Bitmap("peas.png"), bullet.x, bullet.y, bullet.width, bullet.height);
              

            }
            if (target.hit == true)
            {
                e.Graphics.DrawRectangle(White, target.x, target.y, target.width, target.height);
                

            }

           


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
