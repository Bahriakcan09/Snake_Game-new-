using System;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class message : Form
    {
        public message()
        {   
            state_score = $"Your score : {Form1.score}\nDO YOU WANT TO PLAY AGAIN ?";
            InitializeComponent();
            label1.Text = state_score;
        }
        public static bool state_msg;
        public static int tab_contols=0;
        public static string state_score = $"Your score : {Form1.score}\nDO YOU WANT TO PLAY AGAIN ?";

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            state_msg = true;
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            state_msg = false;
            this.Close();
        }
        private void btn1_move(object sender, MouseEventArgs e)
        {
            guna2Button1.BorderThickness = 3;
        }

        private void btn1_leave(object sender, EventArgs e)
        {
            guna2Button1.BorderThickness = 0;
        }

        private void btn2_move(object sender, MouseEventArgs e)
        {
            guna2Button1.BorderThickness = 3;
        }

        private void btn2_leave(object sender, EventArgs e)
        {
            guna2Button1.BorderThickness = 0;
        }
    }
}
