namespace Kühlschrank
{
    internal class TierLM : Lebensmittel
    {
        public float Fettgehalt { get; set; }

        public TierLM(int brennwert, string bezeichnung, float fettgehalt) : base(brennwert, bezeichnung)
        {
            Fettgehalt = fettgehalt;
        }

        public override string ToString()
        {
            return base.ToString() + $"; Fettgehalt: ({Fettgehalt})";
        }
    }
}
