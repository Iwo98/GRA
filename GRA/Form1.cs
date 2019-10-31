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
        Pen shooterPen = new Pen(Color.White, 1);

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            
        }

            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Tick += new EventHandler(timer1_Tick);
            t.Start();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void drawing()
        { 
            g.Clear(Color.Black);
            g.DrawRectangle(shooterPen, shooter.x, shooter.y, shooter.width, shooter.height);
            shooter.move();
            if (bullet.shoot == true)
            {
                g.DrawRectangle(shooterPen, bullet.x, bullet.y, bullet.width, bullet.height);
                bullet.move();
            }
            else
            {
                bullet.x = shooter.x;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            drawing();
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            bullet.shoot = true;
        }
    }
}
