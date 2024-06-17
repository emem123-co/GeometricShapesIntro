using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesIntro;
internal class Rectangle : Quad
{
    //public int Side1 { get; set; } = 0; removing these because we inherited these from the quad class and they are not needed (duplicates)
    //public int Side2 { get; set; } = 0;
 

    //public int Perimeter()
    //{
      //  return 2 * (Side1 + Side2);
    //}

    public int Area()
    {
        return Side1 * Side2;
    }

    public Rectangle(int side1, int side2) : base(side1, side2, side1, side2) //taking two sides from retangle class (aka the base) because we know that side 1 and side 1 , side 2 and side 2, have to be the same value)
    {
        //Side1 = side1; you can remove these due to inheriting quad class 
        //Side2 = side2;
    }

}
