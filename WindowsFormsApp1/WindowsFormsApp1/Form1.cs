using InputManager;
using System;
using System.Media;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int mCount = 180;
        public int mTime = 180;

        public int mouseX = 0;
        public int mouseY = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text.Insert(0, "\t start \t");
            try{
                mTime = Int32.Parse(textBox3.Text);
                mCount = mTime;
                mouseX = Int32.Parse(textBox5.Text);
                mouseY = Int32.Parse(textBox6.Text);
                textBox5.Enabled = false;
                textBox6.Enabled = false;
            }
            catch (Exception)
            {            }
            button4.Enabled = false;
            button5.Enabled = true;
            timer2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text.Insert(0, "\t stop \t");
            button4.Enabled = true;
            button5.Enabled = false;
            timer2.Enabled = false;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            mCount--;
            textBox3.Text = mCount.ToString();
            if(mCount == 1)
            {
                Mouse.Move(mouseX, mouseY);
                Mouse.PressButton(Mouse.MouseKeys.Left);
                SystemSounds.Beep.Play();
            }
            if (mCount == 0)
            {
                Mouse.Move(mouseX, mouseY);
                Mouse.PressButton(Mouse.MouseKeys.Left);
                mCount = mTime;
                SystemSounds.Hand.Play();
            }
        }
    }
}
