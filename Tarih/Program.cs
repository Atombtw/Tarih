using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarih
{
    class Program
    {
        static void Main(string[] args)
        {
            string tarih;

            DateTime dt1 = DateTime.Now;

            Console.WriteLine("/gün/ay/yıl/saat/dakika/");
            Console.WriteLine("Yukarıdaki bilgileri sırası ile Giriniz = ");
            tarih = Console.ReadLine();
            string[] nameArray = tarih.Split(new char[] { '.' });

            string yild = nameArray[0];
            string ayd = nameArray[1];
            string günd = nameArray[2];
            string saatd = nameArray[3];
            string dakikad = nameArray[4];

            int yil = Convert.ToInt32(yild);
            int ay = Convert.ToInt32(ayd);
            int gün = Convert.ToInt32(günd);
            int saat = Convert.ToInt32(saatd);
            int dakika = Convert.ToInt32(dakikad);

            DateTime dt2 = new DateTime(gün, ay, yil, saat, dakika, 00);

            Console.WriteLine(dt2);

            TimeSpan sonuc = dt1.Subtract(dt2);

            Console.WriteLine("İki tarih arasındaki gün farkı = {0}", sonuc.TotalDays);

            Console.ReadKey();
        }
    }
}