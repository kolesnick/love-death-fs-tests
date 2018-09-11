using System;

namespace TLK.PortalsAndHeroes.Kernel
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
