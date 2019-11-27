using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRA
{
    public partial class Level1 : Form
    {
        Shooter shooter = new Shooter(5);
        Bullet bullet = new Bullet(15);

        Target target = new Target(81, 151, 60, 60, 0, "marchewka");
        Target target1 = new Target(181, 151, 60, 60, 1, "broccoli");
        Target target2 = new Target(281, 151, 60, 60, 0, "garlic");
        Target target3 = new Target(381, 151, 60, 60, 0, "pasta");
        Target target4 = new Target(481, 151, 60, 60, 1, "apple");
        Target target5 = new Target(681, 151, 60, 60, 1, "onion");
        Target target6 = new Target(581, 151, 60, 60, -1, "sugar");
        Target target7 = new Target(781, 151, 60, 60, 0, "avocado");
        Target target8 = new Target(31, 251, 60, 60, -1, "salt");
        Target target9 = new Target(131, 251, 60, 60, 0, "leek");
        Target target10 = new Target(231, 251, 60, 60, 1, "banana");
        Target target11 = new Target(331, 251, 60, 60, 1, "tomato");
        Target target12 = new Target(431, 251, 60, 60, -1, "sugar");
        Target target13 = new Target(531, 251, 60, 60, 1, "beans");
        Target target14 = new Target(631, 251, 60, 60, -1, "salt");
        Target target15 = new Target(731, 251, 60, 60, 0, "cherry");
        Target target16 = new Target(831, 251, 60, 60, 0, "chicken");
        Target target17 = new Target(181, 351, 60, 60, -1, "sugar");
        Target target18 = new Target(81, 351, 60, 60, 0, "corn");
        Target target19 = new Target(281, 351, 60, 60, 0, "eggplant");
        Target target20 = new Target(481, 351, 60, 60, 0, "hot_pepper");
        Target target21 = new Target(581, 351, 60, 60, 0, "kiwi");
        Target target22 = new Target(681, 351, 60, 60, 0, "olive_oil");
        Target target23 = new Target(781, 351, 60, 60, 0, "peanuts");
        Target target24 = new Target(381, 351, 60, 60, -1, "salt");



        Target targetNo1 = new Target(51, 51, 60, 60, 1, "broccoli");
        Target targetNo2 = new Target(151, 51, 60, 60, 1, "apple");
        Target targetNo3 = new Target(251, 51, 60, 60, 1, "banana");
        Target targetNo4 = new Target(351, 51, 60, 60, 1, "tomato");
        Target targetNo5 = new Target(451, 51, 60, 60, 1, "beans");
        Target targetNo6 = new Target(551, 51, 60, 60, 1, "onion");




        List<Target> targety = new List<Target>();
        List<Target> targetyNo = new List<Target>();

        Pen Black = new Pen(Color.Black, 2);
        Pen White = new Pen(Color.AliceBlue, 1);
        Pen Hit = new Pen(Color.Gold, 5);
        Pen NotHit = new Pen(Color.Silver, 5);
        Font font = new Font("Lucida Sans", 40, FontStyle.Bold);
        SolidBrush brush = new SolidBrush(Color.Black);

        private bool win = false;


        public Level1()
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

            targetyNo.Add(targetNo1);
            targetyNo.Add(targetNo2);
            targetyNo.Add(targetNo3);
            targetyNo.Add(targetNo4);
            targetyNo.Add(targetNo5);
            targetyNo.Add(targetNo6);


            countHealthies(targety);
        }

        private void Level1_Load(object sender, EventArgs e)
        {

        }

        private void Level1_Paint(object sender, PaintEventArgs e)
        {
            {
                e.Graphics.DrawRectangle(Black, 30, 30, 701, 100);                      //drawing rectangle for the targets that has to be shot
                e.Graphics.DrawRectangle(Black, 30, 150, 901, 610);                     //drawing a rectangle for the map 
                e.Graphics.DrawImage(new Bitmap("Resources/fork.bmp"), shooter.x, shooter.y, shooter.width, shooter.height);  //drawing a shooter

                foreach (Target target in targety)                   //drawing targets on the standard map
                {
                    if (target != null)
                    {
                        if (target.healthy == -1)
                            e.Graphics.DrawImage(new Bitmap("Resources/" + target.name + ".bmp"), target.x, target.y, target.width, target.height);
                        else if (target.healthy == 1)
                            e.Graphics.DrawImage(new Bitmap("Resources/" + target.name + ".bmp"), target.x, target.y, target.width, target.height);
                        else
                            e.Graphics.DrawImage(new Bitmap("Resources/" + target.name + ".bmp"), target.x, target.y, target.width, target.height);
                    }
                }

                foreach (Target targetNo in targetyNo)                                              //drawing healthy targets that user has to shot
                {
                    e.Graphics.DrawImage(new Bitmap("Resources/" + targetNo.name + ".bmp"), targetNo.x, targetNo.y, targetNo.width, targetNo.height);

                    if (targetNo.hit == false)
                    {
                        e.Graphics.DrawRectangle(NotHit, targetNo.x - 5, targetNo.y - 5, targetNo.width + 10, targetNo.height + 10);
                    }
                    else
                        e.Graphics.DrawRectangle(Hit, targetNo.x - 5, targetNo.y - 5, targetNo.width + 10, targetNo.height + 10); //changing color when user shot the right target
                }


                if (bullet.shoot == true)
                    e.Graphics.DrawImage(new Bitmap("Resources/peas.png"), bullet.x, bullet.y, bullet.width, bullet.height); //drawing a bullet when being shot


                if (bullet.healthies == 0)                                            // winning condition
                {
                    win = true;
                    e.Graphics.DrawImage(new Bitmap("Resources/cup.png"), 30, 94, 901, 610);
                    e.Graphics.DrawString("Twój wynik to: " + users_score.Text, font, brush, 220, 410);
                    restart.Visible = true;
                    restart.Enabled = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (win == false)
                updating();

            Invalidate();
        }

        private void Level1_shot(object sender, KeyEventArgs e)
        {
            int keyIndex = e.KeyValue;

            if (keyIndex == 32)
                bullet.shoot = true;
        }

        private void Level1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Level1 lvl1 = new Level1();
            lvl1.Show();
            lvl1.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void Menu_button_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            menu.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
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

        public void updating()
        {
            shooter.move();
            bullet.collision(targety, targetyNo);                          //checking out collision
            if (bullet.shoot == true)
                bullet.move();

            else
            {
                bullet.x = shooter.x;
                bullet.y = 640;
            }

            users_score.Text = bullet.points;                                //updating points

            int e = (targety.FindIndex(t => t.hit == true));            //finding out which object was shot

            if (e != -1)                                                //removing object from the list that was shot
                targety.RemoveAt(e);
        }

       
    }
}
