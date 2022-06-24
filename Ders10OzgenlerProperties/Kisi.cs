namespace Ders10OzgenlerProperties
{
    internal class Kisi
    {
        private int yas;
        private int dogumYeri;
        string meslek;
        double maas;

        public double Maas
        {
            get { return maas; }
            set
            {
                if (value <= 4250)
                {
                    maas = 4250;
                }
                else maas = value;
            }
        }
    }
}
