using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public interface IProduct
    {
        decimal Price { get; set; }
        string ProductName { get; set; }
        string Code { get; set; }
    }
}
