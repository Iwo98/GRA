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
       
        Graphics g;
        Shooter shooter = new Shooter();
        Bullet bullet = new Bullet();
        Target target = new Target(431, 251, 100, 100, 1, "makaron");
        Target target1 = new Target(131, 251, 100, 100, 0, "pomidor");
        Target target2 = new Target(131, 151, 100, 100, 1, "brokuł");
        Target target3 = new Target(431, 151, 100, 100, 1, "cukier");
        Target target4 = new Target(231, 151, 100, 100, 0, "pomidor");
        Target target5 = new Target(231, 251, 100, 100, 1, "brokuł");
        Target target6 = new Target(531, 251, 100, 100, -1, "cukier");
        Target target7 = new Target(531, 151, 100, 100, 0, "pomidor");
        Target target8 = new Target(631, 151, 100, 100, -1, "brokuł");
        Target target9 = new Target(631, 251, 100, 100, 1, "cukier");
        Target target10 = new Target(331, 251, 100, 100, 0, "pomidor");
        Target target11= new Target(31, 251, 100, 100, 1, "brokuł");
        Target target12= new Target(31, 151, 100, 100, -1, "cukier");
        Target target13 = new Target(331, 151, 100, 100, 0, "pomidor");


        List<Target> targety = new List<Target>();
        Pen Black = new Pen(Color.Black, 1);
        Pen White = new Pen(Color.AliceBlue, 1);

        System.Drawing.SolidBrush Red = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        System.Drawing.SolidBrush Green = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
        System.Drawing.SolidBrush Yellow = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);


        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            g = CreateGraphics();
            targety.Add(target);
            targety.Add(target1);
            targety.Add(target2);
            targety.Add(target3);
            targety.Add(target4);
            targety.Add(target5);
            targety.Add(target6);
            targety.Add(target7);
            targety.Add(target8);
            targety.Add(target9);
            targety.Add(target10);
            targety.Add(target11);
            targety.Add(target12);
            targety.Add(target13);
            countHealthy(targety);
            




        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void drawing()
        {
            int i = 0;
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
            foreach (Target target in targety)
            {
                i++;

            }
            int e = (targety.FindIndex(t => t.hit == true));
            if (e != -1)
            {
                targety.RemoveAt(e);         
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
            Shooter xxx = new Shooter();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawRectangle(Black, 30, 150, 701, 610);
            e.Graphics.DrawImage(new Bitmap("fork.png"), shooter.x, shooter.y, shooter.width, shooter.height);  
            foreach(Target target in targety)
            {
                if (target != null)
                {
                    if (target.healthy == -1)
                        e.Graphics.FillRectangle(Red, target.x, target.y, target.width, target.height);
                    else if (target.healthy == 1)
                        e.Graphics.FillRectangle(Green, target.x, target.y, target.width, target.height);
                    else
                        e.Graphics.FillRectangle(Yellow, target.x, target.y, target.width, target.height);
                }
            }

            if (bullet.shoot == true)
            {
                e.Graphics.DrawImage(new Bitmap("peas.png"), bullet.x, bullet.y, bullet.width, bullet.height);

            }

            if( bullet.healthies ==0)
            {
                e.Graphics.DrawImage(new Bitmap("win.png"), 30, 150, 703, 611);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void countHealthy(List<Target> targety)
        {
            int i = 0;
            foreach (Target target in targety)
            {
                
                if(target.healthy==1)
                {
                    i++;
                }
            }

            bullet.healthies = i;
        }
    }
}
