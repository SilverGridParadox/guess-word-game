using System.Drawing;
using System;

namespace bounce_0._0._1._1
{
    public class Logics
    {
        public Ball InGameBall;
        public Block Env;
        public Level Environment;

        int hei, wid, top, write;
        
        public Logics()
        {
            Environment = new Level();
        InGameBall = new Ball();
            Env = new Block();

        }

        bool found = false;

        void Move(int h, int w, int t, int wr)
        {
            if(!found)
            hei = h;
            wid = w;
            top = t;
            write = wr;
            found = true;
        }

        public void GameRun(int Hei, int Wid, bool ind)
        {
            Environment.Tact(Hei, Wid);
        }

        public void GameRun(int Hei, int Wid)
        {
            foreach (var bl in Environment.Field)
            {
                if (Math.Abs(bl.CoordX - InGameBall.CoordX) < 66)
                {
                    if (InGameBall.GY < bl.CoordY + 40)
                        Move((int)bl.CoordY + 40, Wid, 0, 0);
                    if (InGameBall.CoordY >= bl.Ground)
                        Move(Hei, Wid, (int)Env.Ground, 0);
                }
                else
                if (Math.Abs(InGameBall.CoordY - bl.CoordY) < 66)
                {
                    if (InGameBall.WX <= bl.CoordX + 15)
                        Move(Hei, (int)bl.CoordX + 15, 0, 0);
                    else
                    if (InGameBall.CoordX >= bl.Write)
                        Move(Hei, Wid, 0, (int)bl.Write);
                }
                else
                {
                    Move(Hei, Wid, 0, 0);
                }
            }
            InGameBall.Move(hei,wid,top,write);
            found = false;
        }   

    }
}
