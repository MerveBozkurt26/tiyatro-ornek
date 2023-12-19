using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiyatro_ornek
{
    internal class Tiyatro
    {
        int id;
        int sure;
        string ad;
        DateTime tarih;
        string sahne;
        double fiyat;
        bool muzikal;

        public int Id { get => id; set => id = value; }
        public int Sure { get => sure; set => sure = value; }
        public string Ad { get => ad; set => ad = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public string Sahne { get => sahne; set => sahne = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
        public bool Muzikal { get => muzikal; set => muzikal = value; }

        public Tiyatro(int id, int sure, string ad, DateTime tarih, string sahne, double fiyat, bool muzikal)
        {
            this.id = id;
            this.sure = sure;
            this.ad = ad;
            this.tarih = tarih;
            this.sahne = sahne;
            this.fiyat = fiyat;
            this.muzikal = muzikal;
        }
    }
}
