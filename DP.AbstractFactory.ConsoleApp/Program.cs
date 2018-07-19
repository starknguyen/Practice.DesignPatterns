using System;

namespace DP.AbstractFactory.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factory in Asia creates phone and tablet
            Console.WriteLine("----------- ASIA MOBILE DEVICE FACTORY -----------");
            Console.WriteLine();
            MobileDeviceAbstractFactory abstractASIAFactory = new MobileDeviceAsiaConcreteFactory();
            
            PhoneProduct phoneAsia = abstractASIAFactory.CreatePhone();
            phoneAsia.CreatePhoneProduct();
            TabletProduct tabletAsia = abstractASIAFactory.CreateTablet();
            tabletAsia.CreateTabletProduct();
            
            Console.WriteLine();
            Console.WriteLine();

            // Factory in US creates phone and tablet
            Console.WriteLine("----------- US MOBILE DEVICE FACTORY -----------");
            Console.WriteLine();
            MobileDeviceAbstractFactory abstractUSFactory = new MobileDeviceUSConcreteFactory();

            PhoneProduct phoneUS = abstractUSFactory.CreatePhone();
            phoneUS.CreatePhoneProduct();
            TabletProduct tabletUS = abstractUSFactory.CreateTablet();
            tabletUS.CreateTabletProduct();
        }
    }
}
