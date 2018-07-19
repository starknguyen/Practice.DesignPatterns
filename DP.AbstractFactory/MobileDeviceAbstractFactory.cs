namespace DP.AbstractFactory
{
    public abstract class MobileDeviceAbstractFactory
    {
        public abstract PhoneProduct CreatePhone();

        public abstract TabletProduct CreateTablet();
    }
}
