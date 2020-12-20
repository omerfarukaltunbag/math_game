using System;
using System.Media;
using System.IO;
namespace onlukbirlik
{
    class oyun
    {
        string soyad()
        {
            StreamReader srsoyad = new StreamReader(@"soyad");
            string soyadg = srsoyad.ReadToEnd();
            srsoyad.Close();
            return soyadg;
        }
        string ad()
        {
            StreamReader srad = new StreamReader(@"ad");
            string adg = srad.ReadToEnd();
            srad.Close();
            
            return adg;
        }
        static void Main(string[] args)
        {
            try
            {
                StreamReader srad = new StreamReader(@"ad");
                string ad = srad.ReadToEnd();
                srad.Close();
                StreamReader srsoyad = new StreamReader(@"soyad");
                string soyad = srsoyad.ReadToEnd();
                srsoyad.Close();
                Random rmd = new Random();
                SoundPlayer play = new SoundPlayer();
                play.SoundLocation = @"alkıs.mp3";
                while (true)
                {
                    
                
                Console.ForegroundColor = ConsoleColor.Black;
                int backcolor1 = rmd.Next(1,6);
                if (backcolor1 == 1)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                }
                if (backcolor1 == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                }
                if (backcolor1 == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                }
                if (backcolor1 == 4)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                }
                if (backcolor1 == 5)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                }
            System.Console.WriteLine("1:sayıdan onluk ve birlik");
            System.Console.WriteLine("2:onluk ve birlikten sayı");
            System.Console.WriteLine("3:kullanıcı ayarları");
            int secim = int.Parse(Console.ReadLine());
            if (secim == 1)
            {
                while (true)
                {
                    Console.Clear();
                int backcolor = rmd.Next(1,6);
                int sayi = rmd.Next(100);
                int onda = sayi / 10;
                int birlik = sayi % 10;
                if (backcolor == 1)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                }
                if (backcolor == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                }
                if (backcolor == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                }
                if (backcolor == 4)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                }
                if (backcolor == 5)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                }
                
                System.Console.WriteLine("                  **********             ");
                System.Console.WriteLine("                  *   " + sayi + "   *");
                System.Console.WriteLine("                  *        *             ");
                System.Console.WriteLine("                  **********             ");
                System.Console.WriteLine("                  ");
                System.Console.WriteLine("                  Bu sayıda kaç onluk var?" + ad + " " + soyad);
                System.Console.Write("                  ");
                int onlukc = int.Parse(Console.ReadLine());
                if (onlukc == onda)
                {
                    System.Console.WriteLine("                  afferin" + ad + " " + soyad);
                    play.Play();
                    System.Threading.Thread.Sleep(2000);
                }
                else
                {
                    System.Console.WriteLine("                  aa yanlış" + ad + " " + soyad);
                    System.Threading.Thread.Sleep(1000);
                }
                System.Console.WriteLine("                 peki kaç birlik var" + ad + " " + soyad);
                int birlikc = int.Parse(Console.ReadLine());
                if (birlikc == birlik)
                {
                    System.Console.WriteLine("afferin" + ad + " " + soyad);
                    System.Threading.Thread.Sleep(2000);
                }
                else
                {
                    System.Console.WriteLine("aa yanlış" + ad + " " + soyad);
                    System.Threading.Thread.Sleep(1000);
                }
                Console.Clear();
                }
            }
            if (secim == 2)
            {
                Console.Clear();
                int backcolor2 = rmd.Next(1,6);
                int ondas = rmd.Next(10);
                int birliks = rmd.Next(10);
                int sayıo = ondas * 10 + birliks * 1;
                if (backcolor2 == 1)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                }
                if (backcolor2 == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                }
                if (backcolor2 == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                }
                if (backcolor2 == 4)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                }
                if (backcolor2 == 5)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                }
                
                System.Console.WriteLine("                  **********             ");
                System.Console.WriteLine("                  * onda " + ondas + " *");
                System.Console.WriteLine("                  *        *             ");
                System.Console.WriteLine("                  **********             ");
                System.Console.WriteLine("                  ");
                System.Console.WriteLine("                  **********             ");
                System.Console.WriteLine("                  *birlik " + birliks + "*");
                System.Console.WriteLine("                  *        *             ");
                System.Console.WriteLine("                  **********             ");
                System.Console.WriteLine("                  Bu sayı kaç ? " + ad + " " + soyad);
                System.Console.Write("                  ");
                int sayıc = int.Parse(Console.ReadLine());
                if (sayıc == sayıo)
                {
                    System.Console.WriteLine("                  afferin " + ad + " " + soyad);
                    play.Play();
                    System.Threading.Thread.Sleep(2000);
                }
                else
                {
                    System.Console.WriteLine("                  aa yanlış" + ad + " " + soyad) ;
                    System.Threading.Thread.Sleep(1000);
                }
                
                Console.Clear();
                }
                if (secim == 3)
                {
                Console.Clear();
                StreamWriter swad1 = new StreamWriter(@"ad");   
                StreamWriter swsoyad1 = new StreamWriter(@"soyad"); 
                System.Console.WriteLine("ismin ne?");
                ad = Console.ReadLine();
                System.Console.WriteLine("soyadın ne?");
                soyad = Console.ReadLine();
                swad1.Write(ad);
                swsoyad1.Write(soyad);
                swad1.Close();
                swsoyad1.Close();
                Console.Clear();
                }
            }
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("hata!");
                return;
            }
            
        }
            
        

    }
}