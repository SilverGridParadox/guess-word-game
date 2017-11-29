using System.Drawing;
using System;

namespace bounce_0._0._1._1
{
    public class Logics
    {
        public Ball InGameBall;
        public Block Env;
        
        public Logics()
        {
        InGameBall = new Ball();
            Env = new Block();
        }

        public bool BallBetweenBlockX()
        {
           if(Math.Abs(Env.CoordX-InGameBall.CoordX)<66)
            return true;
            return false;
        }

        public bool BallBetweenBlockY()
        {
            if (Math.Abs(InGameBall.CoordY - Env.CoordY)<66)
            return true;
            return false;
        }

        public void GameRun(int Hei, int Wid)
        {
            if (BallBetweenBlockX())
            {
                if (InGameBall.GY < Env.CoordY+40)
                    InGameBall.Move((int)Env.CoordY+40, Wid, 0, 0);
                if (InGameBall.CoordY >= Env.Ground)
                    InGameBall.Move(Hei, Wid, Env.Ground, 0);
            }

            else
            if (BallBetweenBlockY())
            {
                if (InGameBall.WX <= Env.CoordX + 15)
                    InGameBall.Move(Hei, Env.CoordX + 15, 0, 0);
                else
                if (InGameBall.CoordX >= Env.Write)
                    InGameBall.Move(Hei, Wid, 0, Env.Write);            
            }
            else
                InGameBall.Move(Hei, Wid, 0, 0);
        }

    }
}
