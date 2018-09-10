namespace TLK.PortalsAndHeroes.Kernel
{
    public class Hellgate
    {
        private bool closed = false;

        public string Inscription =>
            this.closed
                ? string.Empty
                : "Lasciate ogni speranza, voi ch'entrate";

        public void Close() => this.closed = true;
    }
}
