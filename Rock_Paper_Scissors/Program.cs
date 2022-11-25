using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int uzunluk = 0;
            int __Skor = 0;
            int __BilgisayarSkor = 0;
        Yeniden:
            try
            {

                Console.WriteLine("Tur İçin Seçiminizi Yapın: Taş=t, Kağıt=k, Makas=m");
                string __Rock, __Paper, __Scissors;
                char __Secim;
                int sayi = 0;
                string __BilsisayarSecim = " ";

                Random __Random = new Random();

                __Secim = Convert.ToChar(Console.ReadLine());

                if (__Secim == 't')
                {
                    Console.WriteLine("Siz Taş'ı seçtiniz");
                    sayi = __Random.Next(1, 3);
                    if (sayi == 1)
                    {
                        __BilsisayarSecim = "Taş";
                        Console.WriteLine("Bilgisayar " + __BilsisayarSecim + "'ı seçti");
                        Console.WriteLine("Oyun berabere");
                    }
                    else if (sayi == 2)
                    {
                        __BilsisayarSecim = "Kağıt";
                        Console.WriteLine("Bilgisayar " + __BilsisayarSecim + "'ı seçti");
                        Console.WriteLine("Kağıt taşı sarar bu oyunu bilgisayar kazandı!");
                        __BilgisayarSkor++;
                    }
                    else if (sayi == 3)
                    {
                        __BilsisayarSecim = "Makas";
                        Console.WriteLine("Bilgisayar " + __BilsisayarSecim + "'ı seçti");
                        Console.WriteLine("Taş makası kırar bu oyunu siz kazandınız!\n*Tebrikler*");
                        __Skor++;
                    }
                }
                else if (__Secim == 'k')
                {
                    Console.WriteLine("Siz Kağıt'ı seçtiniz");
                    sayi = __Random.Next(1, 3);
                    if (sayi == 1)
                    {
                        __BilsisayarSecim = "Taş";
                        Console.WriteLine("Bilgisayar " + __BilsisayarSecim + "'ı seçti");
                        Console.WriteLine("Kağıt taşı sarar bu oyunu siz kazandınız!\n*Tebrikler*");
                        __Skor++;
                    }
                    else if (sayi == 2)
                    {
                        __BilsisayarSecim = "Kağıt";
                        Console.WriteLine("Bilgisayar " + __BilsisayarSecim + "'ı seçti");
                        Console.WriteLine("Oyun berabere");
                    }
                    else if (sayi == 3)
                    {
                        __BilsisayarSecim = "Makas";
                        Console.WriteLine("Bilgisayar " + __BilsisayarSecim + "'ı seçti");
                        Console.WriteLine("Makas kağıdı keser bu oyunu bilgisayar kazandı!");
                        __BilgisayarSkor++;
                    }
                }

                else if (__Secim == 'm')
                {
                    Console.WriteLine("Siz Makas'ı seçtiniz");
                    sayi = __Random.Next(1, 3);
                    if (sayi == 1)
                    {
                        __BilsisayarSecim = "Taş";
                        Console.WriteLine("Bilgisayar " + __BilsisayarSecim + "'ı seçti");
                        Console.WriteLine("Taş makası kırar bu oyunu bilgisayar kazandı");
                        __BilgisayarSkor++;
                    }
                    else if (sayi == 2)
                    {
                        __BilsisayarSecim = "Kağıt";
                        Console.WriteLine("Bilgisayar " + __BilsisayarSecim + "'ı seçti");
                        Console.WriteLine("Makas kağıdı bu oyunu siz kazandınız!\n*Tebrikler*");
                        __Skor++;
                    }
                    else if (sayi == 3)
                    {
                        __BilsisayarSecim = "Makas";
                        Console.WriteLine("Bilgisayar " + __BilsisayarSecim + "'ı seçti");
                        Console.WriteLine("!Oyun berabere");
                    }
                    Console.WriteLine("Devam etmek ister misiniz");
                    char __Devam = Convert.ToChar(Console.ReadLine());
                    if (__Devam == 'E' || __Devam == 'e')
                    {
                        goto Yeniden;
                    }
                    else
                    {
                        if (__Skor > __BilgisayarSkor)
                        {
                            Console.WriteLine($"Oyunu {__Skor}-{__BilgisayarSkor} skorla siz kazandınız");
                        }
                        else if (__Skor < __BilgisayarSkor)
                        {
                            Console.WriteLine($"Oyunu {__BilgisayarSkor}-{__Skor} skorla bilgisayar kazandınız");
                        }
                        else
                        {
                            Console.WriteLine($"Oyun {__Skor}-{__BilgisayarSkor} berabere");
                        }
                    }
                }
            }
            catch (Exception __Ex)
            {
                Console.WriteLine("Hatalı giriş");
                goto Yeniden;
            }
            Console.ReadKey();
        }
    }
}
        
