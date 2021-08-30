using System;

namespace HexagonDS
{
    public class Hexagon
    {
        private int content;

        private Hexagon[] sides;

        public Hexagon()
        {
            this.sides = new Hexagon[6];
        }

        public Hexagon this[int key]
        {
            get => getSide(key);
            set => setSideMaster(key, value);
        }

        // Getter for hexagons connected.
        public Hexagon getSide(int key)
        {
            return this.sides[key];
        }
    
        // Setter for hexagon on LHS (calls on RHS back to self)
        public void setSideMaster(int key, Hexagon hex)
        {
            // Set target hex to be connected on given side
            this.sides[key] = hex;

            // Connect target hex back to this hex on opposite side
            hex.setSideSlave(5 - key, this);
        }

        // Setter for hexagon on RHS
        private void setSideSlave(int key, Hexagon hex)
        {
            // Just sets hex, only even 
            this.sides[key] = hex;
        }

        // getter and setter for content
        public int val()
        {
            return this.content;
        }
        public void val(int content)
        {
            this.content = content;
        }
    }
}
