using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Size size = new Size(20,20);
        Random random = new Random();
        Label bait = new Label();
        Label[] snake = new Label[1];
        int locationX, locationY;
        bool state;
        message msg = new message();
        Yon yon;
        public static int score = 0;
        int count=0,high=Properties.Settings.Default.high_score;
        enum Yon
        {
            n,up,down,left,right
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            highScoreLabel.Text=$"HIGH SCORE : {high}";
            create_piece(panel1.Width/2, panel1.Height/2);
            bait_create();
            timer1.Start();
        }
        void create_piece(int _x,int _y)
        {
            Label a = new Label();
            a.BackColor=Color.White;
            a.Size = size;
            a.Location = new Point(_x,_y);
            snake[count] = a;
            count++;
            Array.Resize(ref snake,count+1);
            panel1.Controls.Add(a);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            state_limit();            
            state_bait();
            state_snake();
            fallow();

            if (yon == Yon.up)
            {
                snake[0].Location=new Point(snake[0].Location.X,snake[0].Location.Y-20);
            }
            else if(yon == Yon.down)
            {
                snake[0].Location = new Point(snake[0].Location.X, snake[0].Location.Y + 20);
            }
            else if (yon == Yon.left)
            {
                snake[0].Location = new Point(snake[0].Location.X-20, snake[0].Location.Y);
            }
            else if (yon == Yon.right)
            {
                snake[0].Location = new Point(snake[0].Location.X+20, snake[0].Location.Y);
            }
        }
        private void state_limit()
        {
            Rectangle limit = new Rectangle(panel1.Location.X,panel1.Location.Y-80,panel1.Width,panel1.Height);
            Rectangle snk = new Rectangle(snake[0].Location, size);
            if (!snk.IntersectsWith(limit))
            {
                game_over();
            }
        }
        void reset_game()
        {
            timer1.Interval = 130;
            score = 0;
            count = 0;
            yon = Yon.n;
            panel1.Controls.Clear();
            Array.Resize(ref snake, 1);
            highScoreLabel.Text = $"HIGH SCORE : {high}";
            scorLabel.Text = $"SCOR : {score}";
            create_piece(panel1.Width / 2, panel1.Height / 2);
            bait_create();
            timer1.Start();

        }
        void game_over()
        {
            timer1.Stop();
            message msg = new message();
            msg.ShowDialog();
            if (score > high) Properties.Settings.Default.high_score = score;
            Properties.Settings.Default.Save();
            if (message.state_msg) reset_game();
            else this.Close();
        }
        private void fallow()
        {
            if (count < 2) { return; }
            for (int i = snake.Length-2; i >0; i--)
            {
                snake[i].Location = snake[i-1].Location;
            }
        }
        private void state_bait()
        {
            Rectangle r1 = new Rectangle(snake[0].Location, size);
            Rectangle r2 = new Rectangle(bait.Location, size);
            if (r1.IntersectsWith(r2))
            {
                panel1.Controls.Remove(bait);
                score += 10;
                scorLabel.Text = $"SCOR : {score}";
                if (timer1.Interval >30)
                {
                    timer1.Interval -= 2;
                }
                create_piece(-50,-50);
                bait_create();
            }
        }
        void state_snake()
        {
            Rectangle r1 = new Rectangle(snake[0].Location.X, snake[0].Location.Y, 20, 20);
            for (int i = 1; i < snake.Length - 1; i++)
            {
                Rectangle r2 = new Rectangle(snake[i].Location.X, snake[i].Location.Y, 20, 20);
                if (r1.IntersectsWith(r2))
                {
                    game_over();
                    break;
                }
            }
        }
        private void key_down(object sender, KeyEventArgs e)
        {
            
            if ((e.KeyCode==Keys.Up||e.KeyCode==Keys.W)&&(yon!=Yon.down))
            {
                yon = Yon.up;
                state = true;
            }
            else if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A)&& (yon != Yon.right))
            {
                yon = Yon.left;
                state = true;
            }
            else if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S)&& (yon != Yon.up))
            { 
                yon= Yon.down;
                state = true;
            }            
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D)&& (yon != Yon.left))
            {
                yon=Yon.right;
                state = true;
            }
            else if(e.KeyCode == Keys.P)
            {
                timer1.Stop();
                state = false;
                yon = Yon.n;
            }
            if (state)timer1.Start();
        }
        void bait_create()
        {
            bool bait_state=true;

            do
            {
                locationX = random.Next(0, 40) * 20;
                locationY = random.Next(0, 22) * 20 + panel1.Location.Y;
                Rectangle r1 = new Rectangle(locationX, locationY, 20, 20);
                for (int i = 0; i < snake.Length - 1; i++)
                {
                    Rectangle r2 = new Rectangle(snake[i].Location.X, snake[i].Location.Y, 20, 20);
                    if (r1.IntersectsWith(r2))
                    {
                        bait_state = true;
                        break;
                    }
                    else
                    {
                        bait_state = false;
                    }
                }
            } while (bait_state);
            bait.Location = new Point(locationX, locationY);
            bait.Size = size;
            bait.BackColor = Color.Yellow;
            panel1.Controls.Add(bait);
        }
    }
}