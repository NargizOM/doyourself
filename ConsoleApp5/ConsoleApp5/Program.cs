using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var menimKassam = new Kassa();
            var menimKassam2 = new Kassa();
            
            menimKassam.BorcVer(200);
            menimKassam2.BorcAl(700);  
        }
    }

    class Kassa {
        public string KassaAdi = "Menim heyatim";
        private int PulMiqdari=1000;
        public void BorcVer(int VerilecekPulMiqdari)
        {
            Console.WriteLine("Hesabdaki pul miqdari: "+PulMiqdari );
            PulMiqdari = PulMiqdari - VerilecekPulMiqdari;
            Console.WriteLine(VerilecekPulMiqdari+"AZN borc verildikden sonra hesabdaki pul miqdari :"+ PulMiqdari);
        }

        public void BorcAl (int AlinacaqPulMiqdari)
        {
            Console.WriteLine("Hesabdaki pul miqdari;" + PulMiqdari);
            PulMiqdari = PulMiqdari + AlinacaqPulMiqdari;
            Console.WriteLine(AlinacaqPulMiqdari + "AZN borc alindiqdan sonra hesabdaki pul miqdari :" + PulMiqdari);
        }

            };


        }


           

    




