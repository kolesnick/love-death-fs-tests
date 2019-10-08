using System;

namespace TLK.LoveDeathFSharp.Kernel
{
    public class Bifrost
    {
        public Bifrost(IWeapon weapon)
        {
            if (!(weapon is IKey))
                throw new ArgumentException();
        }

        internal interface IKey { }
    }
}
