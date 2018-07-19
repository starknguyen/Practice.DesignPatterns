using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.AbstractFactory
{
    public abstract class PhoneProduct
    {
        public virtual void CreatePhoneProduct()
        {
            Console.WriteLine("Create a phone product");
        }
    }

    public class NokiaPhone : PhoneProduct
    {
        public override void CreatePhoneProduct()
        {
            base.CreatePhoneProduct();
            Console.WriteLine("NOKIA phone was created!");
        }
    }

    public class ApplePhone : PhoneProduct
    {
        public override void CreatePhoneProduct()
        {
            base.CreatePhoneProduct();
            Console.WriteLine("APPLE iPHONE was created!");
        }
    }
}
