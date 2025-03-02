namespace otopark
{
    internal class Program
    {
        static string tus;
        static int gun;
        static double saat, ucret;

        static void Main(string[] args)
        {
            AracSecim();
            ArabaKontrol();           
        }


        private static void AracSecim()
        {
            Console.WriteLine("***********Otopark Ücretlendirme************");
            Console.WriteLine("1.Otomobil için 1'e basınız.");
            Console.WriteLine("2.Motosiklet için 2'ye basınız.");
            Console.WriteLine("3.Minibüs için 3'e basınız.");
            Console.WriteLine("4.Kamyon (ve diğer ticari araçlar) için 4’e basınız.");
            tus = Console.ReadLine();
            switch (tus)
            {
                case "1": break;
                case "2": break;
                case "3": break;
                case "4": break;
                default:
                    Console.WriteLine("Geçerli bir seçim yapınız.");
                    AracSecim();
                        break;
                       
            }
        }


        private static void OtoparkUcretlendirme(int ucret1, int ucret2, int ucret3, int ucret4, int ucret5)
        {
            try
            {
                SaatAl();
                if (saat > 0 & saat < 2)
                {
                    ucret = ucret1;
                }
                else if (saat > 2 & saat < 6)
                {
                    ucret = ucret2;
                }
                else if (saat > 6 & saat < 12)
                {
                    ucret = ucret3;
                }
                else if (saat > 12 & saat < 24)
                {
                    ucret = ucret4;
                }
                else
                {
                    ucret = ucret4 + gun * ucret5;
                }

            }
            catch (FormatException)
            {

                Console.WriteLine("Geçersiz giriş yapıldı.");
               
            }
        }

        private static void OtomobilUcretlendirme()
        {
            OtoparkUcretlendirme(5, 10, 20, 35, 20);
            Console.WriteLine($"Ücretiniz: {ucret}TL");
        }
        private static void MotosikletUcretlendirme()
        {
            OtoparkUcretlendirme(0, 3, 6, 12, 10);
            Console.WriteLine($"Ücretiniz: {ucret}TL");
        }
        private static void MinibusUcretlendirme()
        {
            OtoparkUcretlendirme(8, 16, 32, 45, 25);
            Console.WriteLine($"Ücretiniz: {ucret}TL");
        }
        private static void KamyonUcretlendirme()
        {
            OtoparkUcretlendirme(15, 30, 60, 100, 55);
            Console.WriteLine($"Ücretiniz: {ucret}TL");
        }

        private static void SaatAl()
        {
            try
            {
                Console.WriteLine("Araç kaç saat boyunca park alanında kaldı?");
                saat = Convert.ToDouble(Console.ReadLine());

               double gun = saat / 24;
            }
            catch (FormatException)
            {

                Console.WriteLine("Lütfen doğru formatta saat giriniz.");
                SaatAl();
            }
            catch(Exception)
            {
                SaatAl();
            }
            
        }

        private static void ArabaKontrol()
        {
            if (tus == "1") OtomobilUcretlendirme();
            else if (tus == "2") MotosikletUcretlendirme();
            else if (tus == "3") MinibusUcretlendirme();
            else if (tus=="4") KamyonUcretlendirme();
        
        }
       
    }
}