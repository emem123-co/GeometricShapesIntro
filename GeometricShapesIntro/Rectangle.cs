using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesIntro;
internal class Rectangle
{
    public int Side1 { get; set; } = 0;
    public int Side2 { get; set; } = 0;
 

    public int Perimeter()
    {
        return 2 * (Side1 + Side2);
    }

    public int Area()
    {
        return Side1 * Side2;
    }

    public Rectangle(int side1, int side2)
    {
        Side1 = side1;
        Side2 = side2;
    }

}
