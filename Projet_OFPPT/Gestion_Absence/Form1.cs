using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Absence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int statu;
        int humButton;
        private void Form1_Load(object sender, EventArgs e)
        {
            statu = 0;
            humButton = 0;
        }
        private void Close_pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maximise_pictureBox_Click(object sender, EventArgs e)
        {
            if (statu == 0)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                statu = 1;
                Maximise_pictureBox.Location = new Point(Maximise_pictureBox.Location.X + 410, Maximise_pictureBox.Location.Y);
                Close_pictureBox.Location = new Point(Close_pictureBox.Location.X + 410, Close_pictureBox.Location.Y);
                Minimise_pictureBox.Location = new Point(Minimise_pictureBox.Location.X + 410, Minimise_pictureBox.Location.Y);

            }
            else
            {
                Maximise_pictureBox.Location = new Point(892, Maximise_pictureBox.Location.Y);
                Minimise_pictureBox.Location = new Point(855, Minimise_pictureBox.Location.Y);
                Close_pictureBox.Location = new Point(924, Close_pictureBox.Location.Y);
                this.Width = 958;
                this.Height = 631;
                this.CenterToScreen();
                statu = 0;
            }
        }

        private void Humbutton_Click(object sender, EventArgs e)
        {
            if (humButton == 0)
            {
                timer1.Start();
                
                humButton = 1;
            }
            else
            {
                Tree_Menu_panel.Width = Tree_Menu_panel.Width + 80;
                humButton = 0;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Tree_Menu_panel.Width >59)
            {
                Tree_Menu_panel.Width -= 20;
                timer1.Start();
            }

        }
        private void Header_Panel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (statu == 0)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                statu = 1;
                Maximise_pictureBox.Location = new Point(Maximise_pictureBox.Location.X + 410, Maximise_pictureBox.Location.Y);
                Close_pictureBox.Location = new Point(Close_pictureBox.Location.X + 410, Close_pictureBox.Location.Y);
                Minimise_pictureBox.Location = new Point(Minimise_pictureBox.Location.X + 410, Minimise_pictureBox.Location.Y);

            }
            else
            {
                Maximise_pictureBox.Location = new Point(892, Maximise_pictureBox.Location.Y);
                Minimise_pictureBox.Location = new Point(855, Minimise_pictureBox.Location.Y);
                Close_pictureBox.Location = new Point(924, Close_pictureBox.Location.Y);
                this.Width = 958;
                this.Height = 631;
                this.CenterToScreen();
                statu = 0;
            }
        }
    }
}
