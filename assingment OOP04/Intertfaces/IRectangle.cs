using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment_OOP04.Intertfaces
{
    internal interface IRectangle : IShape
    {
        double Width { get;  }
        double Height { get;  }

    }
}
