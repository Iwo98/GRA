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
    public partial class Level1 : Form
    {

        Graphics g;
        Shooter shooter = new Shooter();
        Bullet bullet = new Bullet();
        Target target = new Target(431, 251, 100, 100, 1, "1");
        Target target1 = new Target(131, 251, 100, 100, 0, "2");
        Target target2 = new Target(131, 151, 100, 100, 1, "3");
        Target target3 = new Target(431, 151, 100, 100, 1, "4");
        Target target4 = new Target(231, 151, 100, 100, 0, "5");
        Target target5 = new Target(231, 251, 100, 100, 1, "6");
        Target target6 = new Target(531, 251, 100, 100, -1, "7");
        Target target7 = new Target(531, 151, 100, 100, 0, "8");
        Target target8 = new Target(631, 151, 100, 100, -1, "9");
        Target target9 = new Target(631, 251, 100, 100, 1, "10");
        Target target10 = new Target(331, 251, 100, 100, 0, "11");
        Target target11 = new Target(31, 251, 100, 100, 1, "12");
        Target target12 = new Target(31, 151, 100, 100, -1, "13");
        Target target13 = new Target(331, 151, 100, 100, 0, "14");
        Target targetNo1 = new Target(41, 41, 80, 80, 1, "1");
        Target targetNo2 = new Target(541, 41, 80, 80, 1, "3");
        Target targetNo3 = new Target(141, 41, 80, 80, 1, "4");
        Target targetNo4 = new Target(241, 41, 80, 80, 1, "6");
        Target targetNo5 = new Target(341, 41, 80, 80, 1, "10");
        Target targetNo6 = new Target(441, 41, 80, 80, 1, "12");


        List<Target> targety = new List<Target>();
        List<Target> targetyNo = new List<Target>();
        Pen Black = new Pen(Color.Black, 2);
        Pen White = new Pen(Color.AliceBlue, 1);
        Pen Hit = new Pen(Color.Gold, 5);
        Pen NotHit = new Pen(Color.Gray, 5);

        System.Drawing.SolidBrush Red = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        System.Drawing.SolidBrush Green = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
        private System.Windows.Forms.Timer timer1;
        private IContainer components;
        System.Drawing.SolidBrush Yellow = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);

       

        public Level1()
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
            targetyNo.Add(targetNo1);
            targetyNo.Add(targetNo2);
            targetyNo.Add(targetNo3);
            targetyNo.Add(targetNo4);
            targetyNo.Add(targetNo5);
            targetyNo.Add(targetNo6);
            
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Level1
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.DoubleBuffered = true;
            this.Name = "Level1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Level1_FormClosing_1);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Level1_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyUp);
            this.ResumeLayout(false);

        }
        public void drawing()
        {
            shooter.move();
            bullet.hitbox(targety, targetyNo);                          //checking out collision
            if (bullet.shoot == true)
                bullet.move();

            else
            {
                bullet.x = shooter.x;
                bullet.y = 660;
            }

            //label2.Text = bullet.points;                                //updating points

            int e = (targety.FindIndex(t => t.hit == true));            //finding out which object was shot

            if (e != -1)                                                //removing object from the list that was shot
                targety.RemoveAt(e);
        }

        private void Level1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Black, 30, 30, 701, 100);                      //drawing rectangle for the targets that has to be shot
            e.Graphics.DrawRectangle(Black, 30, 150, 701, 610);                     //drawing a rectangle for the map 
            e.Graphics.DrawImage(new Bitmap("fork.png"), shooter.x, shooter.y, shooter.width, shooter.height);  //drawing a shooter

            foreach (Target target in targety)                   //drawing targets on the standard map
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

            foreach (Target targetNo in targetyNo)                                              //drawing healthy targets that user has to shot
            {
                e.Graphics.FillRectangle(Green, targetNo.x, targetNo.y, targetNo.width, targetNo.height);

                if (targetNo.hit == false)
                {
                    e.Graphics.DrawRectangle(NotHit, targetNo.x, targetNo.y, targetNo.width, targetNo.height);
                }
                else
                    e.Graphics.DrawRectangle(Hit, targetNo.x, targetNo.y, targetNo.width, targetNo.height); //changing color when user shot the right target
            }


            if (bullet.shoot == true)
                e.Graphics.DrawImage(new Bitmap("peas.png"), bullet.x, bullet.y, bullet.width, bullet.height); //drawing a bullet when being shot


           
        }

        private void Level1_KeyUp(object sender, KeyEventArgs e)
        {
            int keyIndex = e.KeyValue;

            if (keyIndex == 32)
                bullet.shoot = true;
        }
      

        private void Level1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            drawing();
            Invalidate();
        }
    }
}