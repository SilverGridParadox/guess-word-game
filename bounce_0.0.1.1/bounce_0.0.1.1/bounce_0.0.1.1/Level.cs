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

        int top;
        int height;
        int left;
        int width;

        public Level(int num)
        {
         
        }
        public Level()
        {
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
