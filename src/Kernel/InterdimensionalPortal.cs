using System.Collections;
using System.Collections.Generic;

namespace TLK.PortalsAndHeroes.Kernel
{
    public class InterdimensionalPortal
    {
        private readonly ICollection<Hero> currentDimension;
        private readonly ICollection<Hero> anotherDimension;

        public InterdimensionalPortal(ICollection<Hero> currentDimension, ICollection<Hero> anotherDimension)
        {
            this.currentDimension = currentDimension;
            this.anotherDimension = anotherDimension;
        }

        public void Teleport(Hero hero)
        {
            currentDimension.Remove(hero);
            anotherDimension.Add(hero);
        }
    }
}
