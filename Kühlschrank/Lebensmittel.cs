namespace Kühlschrank
{
    internal class Lebensmittel
    {
        public int KCal { get; set; }
        public string Bezeichnung { get; set; }
        public string Art { get; set; }

        public Lebensmittel()
        {
            Art = "Lebensmittel";
            KCal = 0;
            Bezeichnung = string.Empty;
        }
        public Lebensmittel(int brennwert, string bezeichnung)
        {
            Art = "Lebensmittel";
            KCal = brennwert;
            Bezeichnung = bezeichnung;
        }

        public override string ToString()
        {
            return $"Bezeichnung: {Bezeichnung} ({Art}), Brennwert: {KCal}kcal";
        }

    }
}
