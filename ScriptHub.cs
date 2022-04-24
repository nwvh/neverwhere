using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace NeverwhereInjector1
{
    public partial class ScriptHub : Form
    {
        ExploitAPI module = new ExploitAPI();
        public ScriptHub()
        {
            InitializeComponent();
        }

        Point lastPoint;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Script is currently broken and will be replaced soon!", "ERROR");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/U44fdk6c");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/PQkdFUK6");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/TRXxuSHX");
        }

        private void owl_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/vZwx3y4m");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/epgnNu91");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/jQa3tdUF");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/mDVjQWtW");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/iMSdJ4Q0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/iqUCR5Y0");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://raw.githubusercontent.com/Herrtt/Phantom-Forces-Cheat/main/Main.lua");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/n2Kjktwr");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/ZrU6j7BB");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paste-txt.com/raw/PKjf0QxOQo");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/uvhnt0xE");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/eeVCTU91");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/TTgRu1Pk");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            {
                Point lastPoint;
                lastPoint = new Point(e.X, e.Y);
            }
        }

        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            {
                Point lastPoint;
                lastPoint = new Point(e.X, e.Y);
            }
        }

        private void panel2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
