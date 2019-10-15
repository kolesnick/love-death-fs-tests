using System;
using static TLK.LoveDeathFSharp.Kernel.Shape;

namespace TLK.LoveDeathFSharp.Kernel
{
    public class Tank
    {
        private readonly IShapeshifter pilot;

        public Tank(IShapeshifter pilot) => this.pilot = pilot;

        public void Shoot()
        {
            if (pilot.Shape == Wolf)
                throw new InvalidOperationException();
        }
    }
}
