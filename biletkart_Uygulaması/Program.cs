using System;

namespace biletkart_Uygulaması
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Akıllı BiletKart Uygulamasına Hoşgeldiniz");
            Console.WriteLine("NORMAL TARİFE İÇİN 1 İ TUŞLAYIN");
            Console.WriteLine(" ÖĞRENCİ VE 30 YAŞINDAN KÜÇÜKSENİZ (30DA KABUL EDİLİR) 2 Yİ TUŞLAYIN");
            Console.WriteLine(" ÖĞRENCİ VE 30 YAŞINDAN BÜYÜKSENİZ 3 Ü TUŞLAYIN");
            Console.WriteLine(" 60 YAŞINDAN BÜYÜKSENİZ (60DA KABUL EDİLİR) 4Ü TUŞLAYINIZ");
            Console.WriteLine("EĞER ÜSTTEKİ KATEGORİLERDEN BİRDEN FAZLASINA GİRİYORSANIZ 5İ TUŞLAYIN");
            Console.Write("Lütfen Kartınızı Okutunuz veya Girdiğiniz Kategoriyi tuşlayınız: ");

            int secim = int.Parse(Console.ReadLine());





                double para = 0;

            switch (secim)
            {
                case 1:
                    para = (3);
                    Console.Write("Ücretiniz {0} TL dir", para);
                    break;

                case 2:
                    para = (2.5);
                    Console.Write("Ücretiniz {0} TL dir", para);
                    break;

                case 3:
                    para = (2.75);
                    Console.Write("Ücretiniz {0} TL dir", para);
                    break;

                case 4: Console.Write("Sizden Ücret Alınmamaktadır");
                    break;

                case 5: Console.Write("Sizden Ücret Alınmamaktadır");
                    break;

                default: Console.Write("Lütfen 1-5 Tuşlarını Kullanınız");
                    break;

            }
            Console.ReadKey();



        }
    }
}
