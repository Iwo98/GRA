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
        Target target = new Target(30, 305, 100, 100, false, "makaron");
        Target target1 = new Target(130, 305, 100, 100, true, "makaron");
        Target target2 = new Target(130, 205, 100, 100, true, "makaron");
        Target target3 = new Target(230, 205, 100, 100, false, "cukier");


        List<Target> targety = new List<Target>();
        Pen Black = new Pen(Color.Black, 1);
        Pen White = new Pen(Color.AliceBlue, 1);
        System.Drawing.SolidBrush Red = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        System.Drawing.SolidBrush Green = new System.Drawing.SolidBrush(System.Drawing.Color.Green);


        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            g = CreateGraphics();
            targety.Add(target);
            targety.Add(target1);
            targety.Add(target2);
            targety.Add(target3);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void drawing()
        {
            shooter.move();
            bullet.hitbox(targety);
            if (bullet.shoot == true)
            {
                bullet.move();
            }
            else
            {
                bullet.x = shooter.x;
                bullet.y = 660;
            }
            label2.Text = bullet.points;
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

            e.Graphics.DrawRectangle(Black, 30, 150, 700, 610);
            e.Graphics.DrawImage(new Bitmap("fork.png"), shooter.x, shooter.y, shooter.width, shooter.height);  
            foreach(Target target in targety)
            {
                if(target.healthy==false)
                e.Graphics.FillRectangle(Red, target.x, target.y, target.width, target.height);
                else
                    e.Graphics.FillRectangle(Green, target.x, target.y, target.width, target.height);
            }

            if (bullet.shoot == true )
            {
                e.Graphics.DrawImage(new Bitmap("peas.png"), bullet.x, bullet.y, bullet.width, bullet.height);

            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
