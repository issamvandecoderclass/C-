namespace lesbrief8
{
    class Mobiel
    {
        const float btw = 0.21f;
        public float prijs = 3.95f;
        private string Type;
        private string Model;
        private string OS;

        public Mobiel(string nType, string nModel, string nOS)
        {
            type = nType;
            model = nModel;
            os = nOS;
        }

        public float Btw(int aantal)
        {
            return aantal * prijs + ((aantal * prijs) * btw);
        }

        public void SetPrijs(float nPrijs)
        {
            prijs = nPrijs;
        }
    }
}
