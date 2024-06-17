using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesIntro;
internal class Sqr : Rectangle
{
    /*public int Side { get; set; } = 0;
    */
    /*public int Perimeter()
    {
        return 4 * Side;
    }*/

    /*public int Area()
    {
        return Side * Side;
    }*/

    public Sqr(int side) : base(side, side) //this is a constructor and the only piece needed to do the same thing we did before (because of use of class inheritence).
    {
        //Side = side; can remove this because we inherited rectangle
    }

}
