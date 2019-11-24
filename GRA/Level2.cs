using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace GRA
{
    public partial class Level2 : Form
    {

        Graphics g;
        Shooter shooter = new Shooter();
        Bullet bullet = new Bullet();
        Target target = new Target(431, 251, 60, 60, 1, "marchewka");
        Target target1 = new Target(731, 151, 60, 60, 0, "broccoli");
        Target target2 = new Target(131, 251, 60, 60, 1, "garlic");
        Target target3 = new Target(431, 151, 60, 60, 1, "pasta");
        Target target4 = new Target(231, 151, 60, 60, 0, "broccoli");
        Target target5 = new Target(231, 251, 60, 60, 1, "onion");
        Target target6 = new Target(531, 251, 60, 60, -1, "salt");
        Target target7 = new Target(531, 151, 60, 60, 0, "broccoli");
        Target target8 = new Target(631, 151, 60, 60, -1, "salt");
        Target target9 = new Target(631, 251, 60, 60, 1, "leek");
        Target target10 = new Target(331, 251, 60, 60, 0, "broccoli");
        Target target11 = new Target(31, 251, 60, 60, 1, "tomato");
        Target target12 = new Target(31, 151, 60, 60, -1, "salt");
        Target target13 = new Target(331, 151, 60, 60, 0, "broccoli");
        Target target14 = new Target(831, 251, 60, 60, -1, "salt");
        Target target15 = new Target(731, 251, 60, 60, 0, "broccoli");
        Target target16 = new Target(831, 151, 60, 60, 0, "broccoli");
        Target target17 = new Target(131, 151, 60, 60, -1, "salt");
        Target targetNo1 = new Target(51, 51, 60, 60, 1, "marchewka");
        Target targetNo2 = new Target(531, 51, 60, 60, 1, "tomato");
        Target targetNo3 = new Target(131, 51, 60, 60, 1, "leek");
        Target targetNo4 = new Target(231, 51, 60, 60, 1, "garlic");
        Target targetNo5 = new Target(331, 51, 60, 60, 1, "pasta");
        Target targetNo6 = new Target(431, 51, 60, 60, 1, "onion");


        List<Target> targety = new List<Target>();
        List<Target> targetyNo = new List<Target>();
        Pen Black = new Pen(Color.Black, 2);
        Pen White = new Pen(Color.AliceBlue, 1);
        Pen Hit = new Pen(Color.Gold, 5);
        Pen NotHit = new Pen(Color.Gray, 5);

        System.Drawing.SolidBrush Red = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        System.Drawing.SolidBrush Green = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
        System.Drawing.SolidBrush Yellow = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);

        public Level2()
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
            targety.Add(target14);
            targety.Add(target15);
            targety.Add(target16);
            targety.Add(target17);
            targetyNo.Add(targetNo1);
            targetyNo.Add(targetNo2);
            targetyNo.Add(targetNo3);
            targetyNo.Add(targetNo4);
            targetyNo.Add(targetNo5);
            targetyNo.Add(targetNo6);
            countHealthies(targety);
        }

        private void Level2_Load(object sender, EventArgs e)
        {

        }

        private void Level2_Paint(object sender, PaintEventArgs e)
        {
            {
                e.Graphics.DrawRectangle(Black, 30, 30, 701, 100);                      //drawing rectangle for the targets that has to be shot
                e.Graphics.DrawRectangle(Black, 30, 150, 901, 610);                     //drawing a rectangle for the map 
                e.Graphics.DrawImage(new Bitmap("Resources/fork.png"), shooter.x, shooter.y, shooter.width, shooter.height);  //drawing a shooter

                foreach (Target target in targety)                   //drawing targets on the standard map
                {
                    if (target != null)
                    {
                        if (target.healthy == -1)
                            e.Graphics.DrawImage(new Bitmap("Resources/"+target.name+".bmp"), target.x, target.y, target.width, target.height);
                        else if (target.healthy == 1)
                            e.Graphics.DrawImage(new Bitmap("Resources/"+target.name+".bmp"), target.x, target.y, target.width, target.height);
                        else
                            e.Graphics.DrawImage(new Bitmap("Resources/"+target.name+".bmp"), target.x, target.y, target.width, target.height);
                    }
                }

                foreach (Target targetNo in targetyNo)                                              //drawing healthy targets that user has to shot
                {
                    e.Graphics.DrawImage(new Bitmap("Resources/" + targetNo.name + ".bmp"), targetNo.x, targetNo.y, targetNo.width, targetNo.height);

                    if (targetNo.hit == false)
                    {
                        e.Graphics.DrawRectangle(NotHit, targetNo.x, targetNo.y, targetNo.width, targetNo.height);
                    }
                    else
                        e.Graphics.DrawRectangle(Hit, targetNo.x, targetNo.y, targetNo.width, targetNo.height); //changing color when user shot the right target
                }


                if (bullet.shoot == true)
                    e.Graphics.DrawImage(new Bitmap("Resources/peas.png"), bullet.x, bullet.y, bullet.width, bullet.height); //drawing a bullet when being shot


                if (bullet.healthies == 0)                                            // winning condition
                {
                    e.Graphics.DrawImage(new Bitmap("win.png"), 30, 150, 901, 610);
                }
            }
        }

            private void timer_Tick(object sender, EventArgs e)
            {
                updating();
                Invalidate();
            }

            private void Level2_FormClosing(object sender, FormClosingEventArgs e)
            {
                Application.Exit();
            }

            private void Level2_shot(object sender, KeyEventArgs e)
            {
                int keyIndex = e.KeyValue;

                if (keyIndex == 32)
                    bullet.shoot = true;
            }
            public void updating()
            {
                shooter.move();
                bullet.collision(targety, targetyNo);                          //checking out collision
                if (bullet.shoot == true)
                    bullet.move();

                else
                {
                    bullet.x = shooter.x;
                    bullet.y = 660;
                }

                users_score.Text = bullet.points;                                //updating points

                int e = (targety.FindIndex(t => t.hit == true));            //finding out which object was shot

                if (e != -1)                                                //removing object from the list that was shot
                    targety.RemoveAt(e);
            }

            private void countHealthies(List<Target> targety)       //counting healthy targets
            {
                int i = 0;
                foreach (Target target in targety)
                {
                    if (target.healthy == 1)
                        i++;
                }
                bullet.healthies = i;
            }

        private void Menu_button_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            menu.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }
    }  
}
