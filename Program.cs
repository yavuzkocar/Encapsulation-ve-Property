using System;

namespace Encapsulation_ve_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim="Ayşe";
            ogrenci.Soyisim="Yılmaz";
            ogrenci.OgrenciNo=328;
            ogrenci.Sinif=3;

            ogrenci.OgrenciBilgileriniGetir();
            
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("deniz","arda",256,1);
            ogrenci1.SinifDusur();//sıfırın altına inmeyeceği için uyarıcak
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
      private string isim; // ctrl + . alanı kapsülle yi seç alttakiler gelsin
      private string soyisim;
      private int ogrenciNo;
      private int sinif;

        public string Isim 
        { 
            get {return isim;} // alttaki soyisim gösterimi ile bu gösterim aynı
            set {isim = value;}
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif; 
            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("sınıf en az 1 olabilir");
                    sinif=1;
                }
                else
                sinif=value;
            } 
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci()
        {
        }
        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("******öğrenci bilgileri*****");
            Console.WriteLine("Öğrenci Adı     :{0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı  :{0}", this.Soyisim);
            Console.WriteLine("Öğrenci No      :{0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıf   :{0}", this.Sinif);

        }

        public void SinifAtlat()
        {
            this.Sinif= this.Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif= this.Sinif - 1;
        }
    }
}
