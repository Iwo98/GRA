using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace GRA
{
    public partial class Level2 : Form
    {

        
        Shooter shooter = new Shooter(12);
        Bullet bullet = new Bullet(15);

        Target target = new Target(45, 152, 60, 60, -1, "salt");
        Target target1 = new Target(145, 152, 60, 60, 1, "broccoli");
        Target target2 = new Target(245, 152, 60, 60, -1, "sugar");
        Target target3 = new Target(345, 152, 60, 60, 0, "cherry");
        Target target4 = new Target(445, 152, 60, 60, -1, "salt");
        Target target5 = new Target(545, 152, 60, 60, 0, "cucumber");
        Target target6 = new Target(645, 152, 60, 60, 0, "eggplant");
        Target target7 = new Target(745, 152, 60, 60, 0, "leek");
        Target target8 = new Target(845, 152, 60, 60, -1, "sugar");
        Target target9 = new Target(95, 252, 60, 60, 0, "banana");
        Target target10 = new Target(195, 252, 60, 60, -1, "salt");
        Target target11 = new Target(295, 252, 60, 60, 1, "carrot");
        Target target12 = new Target(395, 252, 60, 60, 0, "rice");
        Target target13 = new Target(495, 252, 60, 60, 1, "olive_oil");
        Target target14 = new Target(595, 252, 60, 60, -1, "sugar");
        Target target15 = new Target(695, 252, 60, 60, 1, "yellow_pepper");
        Target target16 = new Target(795, 252, 60, 60, 0, "pasta");
        Target target17 = new Target(45, 352, 60, 60, -1, "salt");
        Target target18 = new Target(145, 352, 60, 60, 1, "pepper");
        Target target19 = new Target(245, 352, 60, 60, 0, "chicken");
        Target target20 = new Target(345, 352, 60, 60, -1, "sugar");
        Target target21 = new Target(445, 352, 60, 60, 0, "salmon");
        Target target22 = new Target(545, 352, 60, 60, -1, "salt");
        Target target23 = new Target(645, 352, 60, 60, 1, "onion");
        Target target24 = new Target(745, 352, 60, 60, -1, "sugar");
        Target target25 = new Target(845, 352, 60, 60, 0, "beans");




        Target targetNo1 = new Target(51, 51, 60, 60, 1, "broccoli");
        Target targetNo2 = new Target(171, 51, 60, 60, 1, "carrot");
        Target targetNo3 = new Target(291, 51, 60, 60, 1, "olive_oil");
        Target targetNo4 = new Target(411, 51, 60, 60, 1, "yellow_pepper");
        Target targetNo5 = new Target(531, 51, 60, 60, 1, "pepper");
        Target targetNo6 = new Target(651, 51, 60, 60, 1, "onion");




        List<Target> targety = new List<Target>();
        List<Target> targetyNo = new List<Target>();

        Pen Black = new Pen(Color.Black, 2);
        Pen White = new Pen(Color.AliceBlue, 1);
        Pen Hit = new Pen(Color.Gold, 5);
        Pen NotHit = new Pen(Color.Silver, 5);
        Font font = new Font("Lucida Sans", 40, FontStyle.Bold);
        SolidBrush brush = new SolidBrush(Color.Black);

        private bool win = false;


        public Level2()
        {
            InitializeComponent();
            DoubleBuffered = true;
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
            targety.Add(target18);
            targety.Add(target19);
            targety.Add(target20);
            targety.Add(target21);
            targety.Add(target22);
            targety.Add(target23);
            targety.Add(target24);
            targety.Add(target25);

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
                e.Graphics.DrawRectangle(Black, 30, 30, 701, 100);                     
                e.Graphics.DrawRectangle(Black, 30, 150, 901, 610);                    
                e.Graphics.DrawImage(new Bitmap("Resources/fork.bmp"), shooter.x, shooter.y, shooter.width, shooter.height);  

                foreach (Target target in targety)                  
                {
                    if (target != null)
                    {                 
                            e.Graphics.DrawImage(new Bitmap("Resources/"+target.name+".bmp"), target.x, target.y, target.width, target.height);                      
                    }
                }

                foreach (Target targetNo in targetyNo)                                              
                {
                    e.Graphics.DrawImage(new Bitmap("Resources/" + targetNo.name + ".bmp"), targetNo.x, targetNo.y, targetNo.width, targetNo.height);

                    if (targetNo.hit == false)
                    {
                        e.Graphics.DrawRectangle(NotHit, targetNo.x-5, targetNo.y-5, targetNo.width +10, targetNo.height+10);
                    }
                    else
                        e.Graphics.DrawRectangle(Hit, targetNo.x-5, targetNo.y-5, targetNo.width +10, targetNo.height +10); 
                }


                if (bullet.shoot == true)
                    e.Graphics.DrawImage(new Bitmap("Resources/peas.png"), bullet.x, bullet.y, bullet.width, bullet.height); 


                if (bullet.healthies == 0)                                            
                {
                    win = true;
                    e.Graphics.DrawImage(new Bitmap("Resources/cup.png"), 30, 94, 901, 610);
                    e.Graphics.DrawString("Twój wynik to: " + users_score.Text, font, brush, 220, 410);
                    restart.Visible = true;
                    restart.Enabled = true;
                }
            }
        }

            private void timer_Tick(object sender, EventArgs e)
            {
                if(win == false)
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

            if (bullet.shoot == true)
            {
                bullet.move();
                bullet.collision(targety, targetyNo);
            }

            else
            {
                bullet.x = shooter.x;
                bullet.y = 640;
            }

                users_score.Text = bullet.points;                               

                int e = (targety.FindIndex(t => t.hit == true));          

                if (e != -1)                                              
                    targety.RemoveAt(e);
            }

            private void countHealthies(List<Target> targety)      
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

        private void restart_Click(object sender, EventArgs e)
        {
            Level2 lvl2 = new Level2();
            lvl2.Show();
            lvl2.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        
    }  
}
