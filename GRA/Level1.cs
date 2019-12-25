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

        private bool win = false; //flag of the winning conditions

        // creating objects from class Shooter and Bullet, also giving them a proper speed of movement
        Shooter shooter = new Shooter(8);   //speed of the Shooter raises with level
        Bullet bullet = new Bullet(15);

        //creating objects form class target
        Target target = new Target(45, 152, 60, 60, -1, "salt");
        Target target1 = new Target(145, 152, 60, 60, 0, "broccoli");
        Target target2 = new Target(245, 152, 60, 60, 0, "garlic");
        Target target3 = new Target(345, 152, 60, 60, -1, "sugar");
        Target target4 = new Target(445, 152, 60, 60, -1, "salt");
        Target target5 = new Target(545, 152, 60, 60, 0, "onion");
        Target target6 = new Target(645, 152, 60, 60, -1, "sugar");
        Target target7 = new Target(745, 152, 60, 60, 0, "avocado");
        Target target8 = new Target(845, 152, 60, 60, -1, "salt");
        Target target9 = new Target(95, 252, 60, 60, 1, "banana");
        Target target10 = new Target(195, 252, 60, 60, 0, "leek");
        Target target11 = new Target(295, 252, 60, 60, -1, "sugar");
        Target target12 = new Target(395, 252, 60, 60, 1, "peanuts");
        Target target13 = new Target(495, 252, 60, 60, -1, "sugar");
        Target target14 = new Target(595, 252, 60, 60, 1, "strawberry");
        Target target15 = new Target(695, 252, 60, 60, -1, "salt");
        Target target16 = new Target(795, 252, 60, 60, 1, "apple");
        Target target17 = new Target(45, 352, 60, 60, -1, "sugar");
        Target target18 = new Target(145, 352, 60, 60, 0, "chicken");
        Target target19 = new Target(245, 352, 60, 60, 1, "kiwi");
        Target target20 = new Target(345, 352, 60, 60, -1, "salt");
        Target target21 = new Target(445, 352, 60, 60, 0, "eggplant");
        Target target22 = new Target(545, 352, 60, 60, 0, "hot_pepper");
        Target target23 = new Target(645, 352, 60, 60, 0, "olive_oil");
        Target target24 = new Target(745, 352, 60, 60, -1, "sugar");
        Target target25 = new Target(845, 352, 60, 60, 0, "beans");

        //creating objects from class target - these are the objects in higher frame - they cannot be shot, they just show the user which object have to be shot in lower frame
        Target targetNo1 = new Target(51, 51, 60, 60, 1, "banana");
        Target targetNo2 = new Target(201, 51, 60, 60, 1, "peanuts");
        Target targetNo3 = new Target(351, 51, 60, 60, 1, "strawberry");
        Target targetNo4 = new Target(501, 51, 60, 60, 1, "kiwi");
        Target targetNo5 = new Target(651, 51, 60, 60, 1, "apple");
        
        //utworzenie list z obiektami
        List<Target> targety = new List<Target>(); //list with all objects
        List<Target> targetyNo = new List<Target>(); //list for objects that user has to shot
        

        Pen Black = new Pen(Color.Black, 2); //for the main frame in the game
        Pen Hit = new Pen(Color.Gold, 5);   //frame for objects that already have been shot
        Pen NotHit = new Pen(Color.Silver, 5); //frame for objects that have to be shot
        Font font = new Font("Lucida Sans", 40, FontStyle.Bold);
        SolidBrush brush = new SolidBrush(Color.Black);

        


        public Level1()
        {
            InitializeComponent();
            
            DoubleBuffered = true; // DobuleBuffered - crucial for smooth movement objects on the form

            //adding to list all objects
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

            //adding to list objects that have to be shot
            targetyNo.Add(targetNo1);
            targetyNo.Add(targetNo2);
            targetyNo.Add(targetNo3);
            targetyNo.Add(targetNo4);
            targetyNo.Add(targetNo5);
            
            countHealthies(targety);
        }


        private void Level1_Paint(object sender, PaintEventArgs e)
        {
            {
                e.Graphics.DrawRectangle(Black, 30, 30, 701, 100);                      //drawing rectangle for the targets that has to be shot
                e.Graphics.DrawRectangle(Black, 30, 150, 901, 610);                     //drawing a rectangle for the map 
                e.Graphics.DrawImage(new Bitmap("Resources/fork.bmp"), shooter.x, shooter.y, shooter.width, shooter.height);  //drawing a shooter

                foreach (Target target in targety)                   //drawing targets on the standard map (in lower frame)
                {
                    if (target != null)
                    {
                            e.Graphics.DrawImage(new Bitmap("Resources/" + target.name + ".bmp"), target.x, target.y, target.width, target.height); 
                    }
                }

                foreach (Target targetNo in targetyNo)             //drawing healthy targets that user has to shot (in higher frame)
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
                    e.Graphics.DrawImage(new Bitmap("Resources/peas.png"), bullet.x, bullet.y, bullet.width, bullet.height); //drawing a bullet when being shot (space is pressed)


                if (bullet.healthies == 0)                                            // winning condition
                {
                    win = true;        //changing the winning flag condition
                    e.Graphics.DrawImage(new Bitmap("Resources/cup.png"), 30, 94, 901, 610);
                    e.Graphics.DrawString("Twój wynik to: " + users_score.Text, font, brush, 220, 410);
                    restart.Visible = true; //showing and enabling restart icon
                    restart.Enabled = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)   //timer that refreshes the map every 3miliseconds
        {
            if (win == false)
                updating();

            Invalidate();
        }

        private void Level1_shot(object sender, KeyEventArgs e) //shot after user used space
        {
            int keyIndex = e.KeyValue;

            if (keyIndex == 32)
                bullet.shoot = true;
        }

        private void Level1_FormClosing(object sender, FormClosingEventArgs e) //clsoing the app with the standard X
        {
            Application.Exit();
        }

        private void restart_Click(object sender, EventArgs e) //restarting the level
        {
            Level1 lvl1 = new Level1();
            lvl1.Show();
            lvl1.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void Menu_button_Click(object sender, EventArgs e) //going back to menu
        {
            Menu menu = new Menu();
            menu.Show();
            menu.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void countHealthies(List<Target> targety)       //counting healthy targets -- necessary to make a winning condition -- when they hit 0 the level ends
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
            shooter.move();                                                 //moving the shooter
                                                                            //checking out collision
            if (bullet.shoot == true)
            {
                bullet.move();                                              //moving the bullet and checking the collison but only if user pressed space
                bullet.collision(targety, targetyNo);
            }

            else
            {
                bullet.x = shooter.x;                                       //when bullet "disapears" it sticks to the shooter
                bullet.y = 640;
            }

            users_score.Text = bullet.points;                             //updating points

            int e = (targety.FindIndex(t => t.hit == true));            //finding out which object was shot

            if (e != -1)                                                //removing from the list the object that was shot
                targety.RemoveAt(e);
        }
    }
}
