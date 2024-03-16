namespace Kühlschrank
{
    internal class PflanzlLM : Lebensmittel
    {
        public bool Wachstumsbereich { get; set; }

        public PflanzlLM() : base()
        {
            Art = "pflanzliches Lebensmittel";
            Wachstumsbereich = true;
        }

        public PflanzlLM(int brennwert, string bezeichnung, bool oberird) : base(brennwert, bezeichnung)
        {
            Art = "pflanzliches Lebensmittel";
            Wachstumsbereich = oberird;
        }

        public override string ToString()
        {
            if (Wachstumsbereich == true)
                return base.ToString() + "; pflanzliches Lebensmittel wächst oberirdisch.";
            else
                return base.ToString() + "; pflanzliches Lebensmittel wächst unterirdisch.";
        }
    }
}
