using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitaplik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> kitaplik = new List<string>();
            bool cikis = true;
           while (true)
            {
                Console.WriteLine("_________Kİtap Listesi_________");
                Console.WriteLine("1-Kitap Ekle\n2-Kitap Sil\n3-Kİtap Listele\n4-Çıkış Yap");
                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Ekle(kitaplik);
                        break;
                    case 2:
                        Sil(kitaplik);
                        break;
                    case 3:
                        Console.WriteLine("__________Yeni Liste__________");
                        Listele(kitaplik);
                        break;
                    case 4:
                        cikis = false;
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim yaptınız tekrar deneyin !!!");
                        break;
                }
            }
        }

                static void Ekle(List<string>kitaplik)
                {
                    Console.WriteLine("Eklemek istediğiniz kitabın adını yazınız: ");
                    string kitap = Console.ReadLine();
                    kitaplik.Add(kitap);
                    Console.WriteLine(kitap + " adlı kitap listeye eklendi.");
                }
                
                static void Sil(List<string> kitaplik)
                {
                    for(int i = 0; i < kitaplik.Count; i++)
                    {
                        Console.WriteLine(i + 1 + ".kitabınız: " + kitaplik[i]);
                    }
                    Console.WriteLine("Silmek istediğiniz kitabın numarasını giriniz: ");
                    int kitapNo = Convert.ToInt32(Console.ReadLine());
                    kitaplik.RemoveAt(kitapNo-1);
                    Console.WriteLine(kitapNo + ".kitap silindi.");
                }

                static void Listele(List<string> kitaplik)
                {
                    for(int j = 0; j < kitaplik.Count; j++)
                    {
                        Console.WriteLine(kitaplik[j]);
                    }
                }
    }
}
