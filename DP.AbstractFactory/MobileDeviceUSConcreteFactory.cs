namespace DP.AbstractFactory
{
    public class MobileDeviceUSConcreteFactory : MobileDeviceAbstractFactory
    {
        public override PhoneProduct CreatePhone()
        {
            return new ApplePhone();
        }

        public override TabletProduct CreateTablet()
        {
            return new AppleTablet();
        }
    }
}
