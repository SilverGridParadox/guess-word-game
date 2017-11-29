using System.Drawing;

namespace bounce_0._0._1._1
{
    public class Ball
    {
        public float CoordX;
        public float CoordY;
        public float WX;
        public float GY;
        public int AxisX = 0;
        public int AxisY = 0;
       public Image Texture;

       public int Weight = 0;
        float boost = 0f;
        float boostVertical = 0f;
        public float slowdown = 0.25f;
        
        public Ball()
        {
            Texture = Image.FromFile("D:\\ball.png");
            CoordX = 50;
            CoordY = 50;
            WX = CoordX + 66;
            GY = CoordY + 106;

        }

        public Ball(float x, float y)
        {
            Texture = Image.FromFile("D:\\ball.png");
            CoordX = x;
            CoordY = y;
            WX = CoordX + 66;
            GY = CoordY + 106;
        }

        public void Move_Old(int hei,int wid)
        {
            int ground = hei - 106;


            if (AxisX > 0)
            {
                if(CoordX < wid- 81)
                CoordX += 6;
            }

            if (AxisX < 0)
            {
                if(CoordX > 0)
                CoordX -= 6;
            }


            if (AxisY > 0)
            {
              
                CoordY += 6;
            }


            if (AxisY < 0) 
                CoordY -= 6;

            if (CoordY < ground)
            {
                Weight++;
                if (Weight > 80)
                {
                    if(boost<25)
                    boost+=0.5f;
                    if (!(CoordY + boost > ground))
                        CoordY += boost;
                    else
                        CoordY = (ground - CoordY) + CoordY;
                }

            }
            else
            {
                Weight = 0;
                boost = 0;
            }
             
        }

        public void Move(float hei , float wid, float top , float left)
        {
            float ground = hei - 106;

            if (AxisX > 0)
            {
                Texture.RotateFlip(RotateFlipType.Rotate270FlipXY);
                if (boost < 18)
                boost++;
            }
            else
            if(AxisX < 0)
            {
                   Texture.RotateFlip(RotateFlipType.Rotate90FlipXY);
                if (boost > -18)
                    boost--;
            }

            if (AxisX == 0)
            {
                if (boost > 0)
                {
                    boost -= slowdown;
                }
                if (boost < 0)
                {
                    boost += slowdown;
                }
            }

          


            if (Weight > 7)
                AxisY = 0;


            if (CoordY < ground)
            {
                if (CoordY + boostVertical > ground)
                {
                    CoordY += ground - CoordY;
                }
                else
                {
                  CoordY += boostVertical;
                }
            }
            else
            {
                CoordY += (int)-(boostVertical / 1.5f);
                boostVertical = (int)-(boostVertical / 1.3f);
                if(boostVertical==0)
                Weight = 0;

                AxisY = (int)-AxisY / 2;
               // boostVertical = 0;
            }

            

            //gravy
            if (AxisY < 0)
            {
                Weight++;
                CoordY += AxisY;
                boostVertical -= 2;
               
            }
            else
            {
                if (boostVertical < 0)
                    boostVertical += 0.4f;
                else
                    boostVertical += 0.3f;
            }




            if (CoordX <= wid - 81 & CoordX >= left)
            {
                if (CoordX + AxisX + boost > wid - 81)
                {
                    CoordX += (wid - 81) - CoordX;
                }
                else
                {
                    CoordX += AxisX + boost;
                }
                if (CoordX + AxisX + boost < left)
                {
                    CoordX -= CoordX-left;
                }
            }
            else
            {
                if (CoordX >= wid - 81)
                    CoordX = wid - 81;
               // CoordinateX = wid / 2;
            }

            if(CoordY>ground)
            {
                CoordY = ground;
            }

            if (CoordY <= top)
            {
                CoordY = top;
                boostVertical = System.Math.Abs(boostVertical);
                AxisY = System.Math.Abs(AxisY);
            }



            WX = CoordX + 66;
            GY = CoordY + 66;
        }

    }
}
