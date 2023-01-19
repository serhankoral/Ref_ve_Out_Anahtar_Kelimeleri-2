using System;

namespace Ref_ve_Out_Anahtar_Kelimeleri_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bölme işleminde bölüm ve kalanı bulma
            int bolunen = 13;
            int x = bolunen;
            int bolen = 4;
            int kalan=0;
            int bolum=0;
            
            for(int i = 0; i < int.MaxValue; i++)
            {
                if(bolunen>=bolen)
                {
                    bolunen = bolunen - bolen;
                    bolum++;
                }
                else
                {
                    kalan = (x - bolum * bolen);
                    break;
                }
            }
            Console.WriteLine("Bolünen={0}", x);
            Console.WriteLine("Bölen={0}", bolen);
            Console.WriteLine("Bolüm={0}", bolum);
            Console.WriteLine("Kalan={0}", kalan);
        }
        static void bol(int bolunen,int bolen, ref int bolum, ref int kalan)
        {

        }
    }
}
