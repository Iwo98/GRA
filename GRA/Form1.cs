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
        Target target11= new Target(31, 251, 100, 100, 1, "12");
        Target target12= new Target(31, 151, 100, 100, -1, "13");
        Target target13 = new Target(331, 151, 100, 100, 0, "14");
        Target targetNo1 = new Target(41, 41, 80, 80, 1, "1");
        Target targetNo2= new Target(541, 41, 80, 80, 1, "3");
        Target targetNo3= new Target(141, 41, 80, 80, 1, "4");
        Target targetNo4= new Target(241, 41, 80, 80, 1, "6");
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
            targetyNo.Add(targetNo1);
            targetyNo.Add(targetNo2);
            targetyNo.Add(targetNo3);
            targetyNo.Add(targetNo4);
            targetyNo.Add(targetNo5);
            targetyNo.Add(targetNo6);
            countHealthies(targety);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
        private void timer1_Tick(object sender, EventArgs e)            //making changes about position of the object every 3 miliseconds (timer interval set on 3);
        {
            drawing();
            Invalidate();
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {       
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void countHealthies(List<Target> targety)       //counting healthy targets
        {
            int i = 0;
            foreach (Target target in targety)
            {   
                if(target.healthy==1)
                    i++;
            }
            bullet.healthies = i;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Shot(object sender, KeyEventArgs e)      //when space is clicked then shot
        {
            int keyIndex = e.KeyValue;

            if (keyIndex == 32)
                bullet.shoot = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Level1 l1 = new Level1();
            l1.Show();
            l1.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Level1 l2 = new Level1();
            l2.Show();
            l2.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Level1 l3 = new Level1();
            l3.Show();
            l3.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }
    }
}
