namespace TLK.LoveDeathFSharp.Kernel
{
    public abstract class Spacecraft
    {
        protected Spacecraft(string name) => this.Name = name;

        public string Name { get; }

        public override string ToString() => this.Name;
    }
}
