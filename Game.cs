using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Snake
{
    public partial class Game : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle Food = new Circle();
        public Game()
        {
            InitializeComponent();

            //Set settings to default
            new Settings();

            //Set game speed and start timer
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            //Start New game
            StartGame();
        }
        private void StartGame()
        {
            lblGameOver.Visible = false;
            snake_color.Visible = false;
            check_rgb.Visible = false;
            trackspeed.Visible = false;
            speedoption.Visible = false;
            autospeed.Visible = false;
            rr_btn.Visible = false;
            //Set settings to default
            new Settings();
            //Create new player object
            Snake.Clear();
            Circle head = new Circle {X = 10, Y = 5};
            Snake.Add(head);
            GenerateFood();
        }
        //Place random food object
        private void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;
            Random random = new Random();
            Food = new Circle {X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos)};
        }
        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for Game Over
            if (Settings.GameOver)
            {
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;
                ChangePosition();
            }
            pbCanvas.Invalidate();
        }
        Brush LastColor = Brushes.Transparent;
        private Brush Romania()
        {
            
            Brush color = Brushes.Transparent;
            if(LastColor == Brushes.Transparent)
            {
                color = Brushes.Red;
            }
            else if(LastColor == Brushes.Red)
            {
                color = Brushes.Yellow;
            }
            else if(LastColor == Brushes.Yellow)
            {
                color = Brushes.Blue;
            }
            else
            {
                color = Brushes.Red;
            }
            LastColor = color;
            return color;
        }
        private Brush RGB()
        {
            StepBack:
            Brush color = Brushes.Transparent;

            Random rnd = new Random();

            Type brushesType = typeof(Brushes);

            PropertyInfo[] properties = brushesType.GetProperties();

            int random = rnd.Next(properties.Length);
            color = (Brush)properties[random].GetValue(null, null);
            if (color == Brushes.HotPink || color == Brushes.Black || color== Brushes.White || color==Brushes.Green)
            {
                goto StepBack;
            }

            return color;
        }
        private void Draw(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (!Settings.GameOver)
            {
                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                    { 
                    snakeColour = Brushes.HotPink;//Head
                    }
                    else
                    {
                        if (check_rgb.Checked)
                            snakeColour = RGB();//Body
                        else
                            snakeColour = Romania();
                    }

                    //Draw Snake
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));
                    //Draw Food
                    canvas.FillEllipse(Brushes.Green,
                        new Rectangle(Food.X * Settings.Width,
                             Food.Y * Settings.Height, Settings.Width, Settings.Height));

                }
            }
            else
            {
                string gameOver = "Game over \nYour final score is: " + Settings.Score + "";
                lblGameOver.Text = gameOver;
            }
        }
        private void ChangePosition()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
                //Move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }


                    //Get maximum X and Y Pos
                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;

                    //Detect collission with game borders.
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }


                    //Detect collission with body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }

                    //Detect collision with food piece
                    if (Snake[0].X == Food.X && Snake[0].Y == Food.Y)
                    {
                        Eat();
                    }

                }
                else
                {
                    //Move body
                    Console.WriteLine("Pos:{0} Next:{1} X", Snake[i].X, Snake[i-1].X);
                    Snake[i].X = Snake[i - 1].X;
                  
                    Console.WriteLine("Pos:{0} Next:{1} X", Snake[i].Y, Snake[i - 1].Y);
                    Snake[i].Y = Snake[i - 1].Y;
                    
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
        private void Eat()
        {
            //Add circle to body
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);

            //Update Score
            Settings.Score += Settings.Points;
            Score.Visible = true;
            Score.Text = "Score:" + Settings.Score;
            if(autospeed.Checked==true && Settings.Speed<=50)
            {
                Settings.Speed++;
            }
            if(autospeed.Checked==false)
            {
                Settings.Speed = trackspeed.Value;
            }
            gameTimer.Interval = 1000 / Settings.Speed;
            GenerateFood();
        }
        private void Die()
        {
            Settings.GameOver = true;
            Score.Visible = false;
            lblGameOver.Visible = true;
            snake_color.Visible = true;
            check_rgb.Visible = true;
            trackspeed.Visible = true;
            speedoption.Visible = true;
            autospeed.Visible = true;
            rr_btn.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int Y = Convert.ToInt32(this.Size.Width - (this.Size.Width / 4));
            Size size = new Size(Y, this.Size.Height);
            pbCanvas.Size = size;
            Point p = new Point(Y, this.Size.Height - (this.Size.Height / 5));
            lblGameOver.Location = p;
            Point Scor = new Point(Y, this.Size.Height-(this.Size.Height / 1));
            Score.Location = Scor;
            Point Snake_pos = new Point(Y, this.Size.Height - Convert.ToInt32(this.Size.Height / 1.1));
            snake_color.Location = Snake_pos;
            Point checkrgb = new Point(Y, this.Size.Height - Convert.ToInt32(this.Size.Height / 1.2));
            check_rgb.Location = checkrgb;
            Point setspeeds = new Point(Y, this.Size.Height - Convert.ToInt32(this.Size.Height / 1.3));
            speedoption.Location = setspeeds;
            Point track = new Point(Y, this.Size.Height - Convert.ToInt32(this.Size.Height / 1.4));
            trackspeed.Location = track;
            Point auspeed = new Point(Y, this.Size.Height - Convert.ToInt32(this.Size.Height / 1.5));
            autospeed.Location = auspeed;
            Point retry = new Point(Y, this.Size.Height - Convert.ToInt32(this.Size.Height / 1.6));
            rr_btn.Location = retry;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Settings.GameOver = true;
            StartGame();
            Focus();
        }
    }
}
