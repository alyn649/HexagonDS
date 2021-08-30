using System;

namespace HexagonDS
{
    public class Hexagon
    {
        private int content;

        public Hexagon[] sides;

        public Hexagon()
        {
            this.sides = new Hexagon[6];
        }


        public void connectSide(ref Hexagon hex, int side, int targetSide)
        {
            // thisSide: the side on the hex that this function is called on
            // targetSide: the side on the hex thats ref being passed 
            this.sides[thisSide] = hex;

        }

        // getter and setter for content
        public int getContent()
        {
            return this.content;
        }
        public void setContent(int content)
        {
            this.content = content;
        }
    }
}
