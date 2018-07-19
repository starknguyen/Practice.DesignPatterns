namespace DP.AbstractFactory
{
    public class MobileDeviceAsiaConcreteFactory : MobileDeviceAbstractFactory
    {
        public override PhoneProduct CreatePhone()
        {
            return new NokiaPhone();
        }

        public override TabletProduct CreateTablet()
        {
            return new AsusTablet();
        }
    }
}
