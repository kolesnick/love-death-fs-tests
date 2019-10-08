namespace TLK.LoveDeathFSharp.Kernel
{
    public class Hero
    {
        public Hero(string @class) => this.Class = @class;

        public string Class { get; }

        public override string ToString() => this.Class;
    }
}
