using System.Drawing;

namespace bounce_0._0._1._1
{
   public class Block
    {
        public Image Texture;
        public int CoordX;
        public int CoordY;
        public int Write;
        public int Ground;

        public Block()
        {
            CoordX = 0;
            CoordY = 0;

            Texture = Image.FromFile("D:\\block.png");

            Write = CoordX + 66;
            Ground = CoordY + 66;
        }

        public Block(int x, int y)
        {
            CoordX = x;
            CoordY = y;

            Texture = Image.FromFile("D:\\block.png");

            Write = CoordX + 66;
            Ground = CoordY + 66;
        }
    }
}
