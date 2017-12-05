using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bounce_0._0._1._1
{
   public class Level
   {
        public Block[] Field;

        public Ball mainOb;

        public void Tact(int height,int width)
        {
            int closestLeft = 0;
            int closestWrite = height;
            int closestTop = 0;
            int closestBottom = width;
            foreach (var side in Field)
            {
                //write
                if (side.CoordX < closestWrite)
                {
                    if (side.CoordX >= mainOb.WX)
                        closestWrite = side.CoordX;
                }
                //bottom
                if (side.CoordY < closestBottom)
                {
                    if (side.CoordY >= mainOb.GY)
                        closestBottom = side.CoordY;
                }
                //top
                if (side.Ground > closestTop)
                {
                    if (side.Ground <= mainOb.CoordY)
                        closestTop = side.Ground;
                }
                //left
                if (side.Write > closestLeft)
                {
                    if (side.Write <= mainOb.WX)
                        closestLeft = side.Write;
                }
            }
            mainOb.Move(closestWrite, closestBottom, closestTop, closestLeft);
        }


        public Level(int num)
        {
         
        }
        public Level()
        {
            mainOb = new Ball(600, 600);
            Field = new Block[5];
            int h = 0;
            int w = 0;
            for (int cou = 0; cou<Field.Length; cou++)
            {
                Field[cou] = new Block(h, w);
                h += 100;
                w += 100;
            }
        }


        
    }
}
