using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesIntro;
internal class Sqr
{
    public int Side { get; set; } = 0;

    public int Perimeter()
    {
        return 4 * Side;
    }

    public int Area()
    {
        return Side * Side;
    }

    public Sqr(int side)
    {
        Side = side;
    }

}
