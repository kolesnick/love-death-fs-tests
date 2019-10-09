using System.Collections.Generic;

namespace TLK.LoveDeathFSharp.Kernel
{
    public class Wormhole
    {
        private readonly ICollection<Spacecraft> origin;
        private readonly ICollection<Spacecraft> destination;

        public Wormhole(ICollection<Spacecraft> origin, ICollection<Spacecraft> destination)
        {
            this.origin = origin;
            this.destination = destination;
        }

        public void Displace(Spacecraft spaceship)
        {
            origin.Remove(spaceship);
            destination.Add(spaceship);
        }
    }
}
