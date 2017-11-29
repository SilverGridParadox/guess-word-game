using System;
using System.Windows.Forms;
using System.Drawing;

namespace bounce_0._0._1._1
{
    public partial class Form1 : Form
    {
        public Ball ball;
        //public Ball ball1;
        public Logics game ;
        public Form1()
        {
            this.DoubleBuffered = true;


            game = new Logics();
            game.Env = new Block(400, 400);
           // ball = new Ball();
           // ball1 = new Ball();
            //ball1.Texture = Image.FromFile("D:\\ball1.png");
 
            InitializeComponent();
          
            this.KeyDown += new KeyEventHandler(keydown);
            this.KeyPress += new KeyPressEventHandler(keypress);
            this.KeyUp += new KeyEventHandler(keyup);


        }

        #region KeyHandlers

        private void keydown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode.ToString() == "U")
            //    ball1.AxisY = -10;
            //if (e.KeyCode.ToString() == "J")
            //    ball1.AxisY = 10;
            //if (e.KeyCode.ToString() == "H")
            //    ball1.AxisX = -10;
            //if (e.KeyCode.ToString() == "K")
            //    ball1.AxisX = 10;



            if (e.KeyCode.ToString() == "W")
                game.InGameBall.AxisY = -10;
            if (e.KeyCode.ToString() == "S")
                game.InGameBall.AxisY = 10;
            if (e.KeyCode.ToString() == "A")
                game.InGameBall.AxisX = -10;
            if (e.KeyCode.ToString() == "D")
                game.InGameBall.AxisX = 10;
         
        }


        private void keypress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar.ToString() == "W")
                game.InGameBall.AxisY = -10;
            if (e.KeyChar.ToString() == "S")
                game.InGameBall.AxisY = 10;
            if (e.KeyChar.ToString() == "A")
                game.InGameBall.AxisX = -10;
            if (e.KeyChar.ToString() == "D")
                game.InGameBall.AxisX = 10;

        }


        private void keyup(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode.ToString() == "U")
            //{
            //    ball1.AxisY = 0;
            //    ball1.Weight = 8;
            //}
            //if (e.KeyCode.ToString() == "J")
            //    ball1.AxisY = 0;
            //if (e.KeyCode.ToString() == "H")
            //    ball1.AxisX = 0;
            //if (e.KeyCode.ToString() == "K")
            //    ball1.AxisX = 0;





            if (e.KeyCode.ToString() == "W")
            {
                game.InGameBall.AxisY = 0;
                game.InGameBall.Weight = 8;
            }
            
            if (e.KeyCode.ToString() == "S")
                game.InGameBall.AxisY = 0;
            if (e.KeyCode.ToString() == "A")
                game.InGameBall.AxisX = 0;
            if (e.KeyCode.ToString() == "D")
                game.InGameBall.AxisX = 0;

        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
           // spotting ball
            //e.Graphics.DrawLine(new Pen(Color.Black), game.InGameBall.CoordX, 0, game.InGameBall.CoordX, Height);
            //e.Graphics.DrawLine(new Pen(Color.Black), game.InGameBall.WX, 0, game.InGameBall.WX, Height);
            //e.Graphics.DrawLine(new Pen(Color.Black), 0, game.InGameBall.GY, Width, game.InGameBall.GY);
            //e.Graphics.DrawLine(new Pen(Color.Black), 0, game.InGameBall.CoordY, Width, game.InGameBall.CoordY);

            ////spotting block
            //e.Graphics.DrawLine(new Pen(Color.Black), game.Env.CoordX, 0, game.Env.CoordX, Height);
            //e.Graphics.DrawLine(new Pen(Color.Black), game.Env.Write, 0, game.Env.Write, Height);
            //e.Graphics.DrawLine(new Pen(Color.Black), 0, game.Env.Ground, Width, game.Env.Ground);
            //e.Graphics.DrawLine(new Pen(Color.Black), 0, game.Env.CoordY, Width, game.Env.CoordY);

            //e.Graphics.DrawImage(ball1.Texture, ball1.CoordinateX, ball1.CoordinateY);
            e.Graphics.DrawImage(game.Env.Texture, game.Env.CoordX, game.Env.CoordY);
            e.Graphics.DrawImage(game.InGameBall.Texture,game.InGameBall.CoordX, game.InGameBall.CoordY);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           


            //game.InGameBall = ball;
            game.GameRun(Height, Width);
            //ball = game.InGameBall;
            //ball.Move(Height, Width,40,20);
           // ball1.Move(Height, Width, 40, 40);
            Refresh();
        }



    }
}
