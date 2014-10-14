using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLib;

namespace ProductAdapterLib
{
    public class ExternalProductAdapterLib : IProduct
    {
        decimal _price;
        string _productName;
        string _code;

        public ExternalProductAdapterLib(ExternalProduct exProduct)
        {
            _price = exProduct.Price;
            _code = exProduct.EANCode;
            _productName = exProduct.Title;
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
            }
        }

        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
    }
}
