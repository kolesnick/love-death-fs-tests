namespace TLK.LoveDeathFSharp.Kernel
{
    public interface IWeapon { }

    public class InfinityGauntlet : IWeapon { }

    public class Stormbreaker : IWeapon, Bifrost.IKey { }

    public class Hofund : IWeapon, Bifrost.IKey { }
}
