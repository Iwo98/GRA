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
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
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
            countHealthies(targety);

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(770, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Twój wynik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(768, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(775, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 83);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Location = new System.Drawing.Point(775, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 73);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox3.Location = new System.Drawing.Point(775, 157);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 83);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Level1
            // 
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Level1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Level1_FormClosing_1);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Level1_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

            label2.Text = bullet.points;                                //updating points

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


            if (bullet.healthies == 0)                                            // winning condition
            {
                e.Graphics.DrawImage(new Bitmap("win.png"), 30, 150, 703, 611);
            }

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 l1 = new Form1();
            l1.Show();
            l1.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Level1 l2 = new Level1();
            l2.Show();
            l2.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Level1 l3= new Level1();
            l3.Show();
            l3.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }
    }
}