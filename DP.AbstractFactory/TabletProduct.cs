using System;

namespace DP.AbstractFactory
{
    public abstract class TabletProduct
    {
        public virtual void CreateTabletProduct()
        {
            Console.WriteLine("Create a tablet product");
        }
    }

    public class AsusTablet : TabletProduct
    {
        public override void CreateTabletProduct()
        {
            base.CreateTabletProduct();
            Console.WriteLine("ASUS tablet was created!");
        }
    }

    public class AppleTablet : TabletProduct
    {
        public override void CreateTabletProduct()
        {
            base.CreateTabletProduct();
            Console.WriteLine("Apple iPAD was created!");
        }
    }
}
