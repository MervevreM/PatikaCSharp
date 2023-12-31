﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        /* method overloading = ayni isme sahip farkli methodlar yazabiliriz. 
         * methodlar method imzalariyla unique hale gelir (method imzası  = methos adi + parametre sayisi + parametre tipi) ile olusur
         * yani toplam adinda birden fazla method olusturabiliriz fakat uniqulestirmek icin parametre sayisi ya da tipini degistirmemiz gerekir.*/
        static void Main(string[] args)
        {

            #region Method Mantigi ve olusturma

            /* ******************************* METHOd YAPISI
             * 
             *  erisimBelirteci geriDonduguVeriTipi methodAdi (arguman/parametre) {}
             *  NOTT : eger method geri bir sey donmuyorsa void yazman gerek unutma
             *  Bir not daha
             * static sinif icerisinden static methodlara erisilebilir bu sebeple ayni sinif icerisinde cagirmaya calistigin methodun static olmasina dikkat et
             * tipki benim simdi dikkat edecegim gibi 
             */


            /* ****************************** Onemli
             * methodlar icine parametre aldiklarinda degerlerinin birer kopyasiyla islem yaparlar ve method sonunda kopyalanan deger silinir yani
             * halihazirda var olan degerde hicbir degisiklik olmaz. Fonksiyon icinde islem icin deger kullanilir kendisine bir sey olmaz FAKAT
             * fonksiyona girilen parametrelerde veri tipi yazmak yerine ref keyword kullanirsak pc deger kopyasi almak yerine direkt o veri uzerinde degisiklik
             * yapmaya basliyor ve fonksiyona giren degisken ciktiginda eskisi gibi olmuyor :( Tehlikeli bir keyword imis */
            int a = 8;
            int b = 9;

            int MerveninSayisi = toplayici(a, b);
            Console.WriteLine(MerveninSayisi);
            #endregion

            #region Farkli siniftan method cagirma

            /* Oncelikle class'in ismi sonrasinda onu hangi isimle kullanmak istedigimizi yaziyoruz esittir ile atamamizi yapmamizin ardindan new keyword ile 
             * class ismimizi parantezlerle yaziyaruz ve kendimize bir instance yaratiyoruz. Bunu yapmazsak o sinifa erisemeyiz Hemen asagida yapiyorum
             */

            MerveninSinifi NumunesiAlinanSinif = new MerveninSinifi(); //yazdigin isimle cagiracaksin classi Merve unutma:(

            int MerveninYeniSayisi = NumunesiAlinanSinif.BirTaneDahaToplayici(a, b);

            #endregion

            #region OUT keyword kullanimi ve cagirma

            /* out keyword bize method icerisinde yapilan islem sonucunu cekebilmemizi saglar ama onu consola falan yazabiliyoruz
             *  return gibi isleme sokamiyoruz ya da degiskene atayamiyoruz sanirim. 
             * Su sekilde kullanilir:
             * 
             * erisimTipi void methodAdi(foksiyonİcindeKullanilanParametreler, out donenVeriTuru donenVerininAdi){}
             * 
             */

            YineTopla(a, b, out int outluSonucum);
            Console.WriteLine(outluSonucum); // void methoddan veriyi aldim. return gibi ama tam da degil biraz karisikmis degiskene atamama izin vermedi 

            #endregion

        }

        #region ayni sinif icerisinde olusturulmus method ornegi
        static int toplayici(int value1, int value2) // parametrelerin tipini yazmayi unutma az once unuttum
        {

            return (value1 + value2);
        }

        #endregion 

        #region Out keyword kullanimina ornek method olusturma

        static void YineTopla(int value1,int value2, out int outluToplam) // void dedim ama sonucu kullanabiliyoruz ama readonly gibi daha cok yukarida cagirip yapicam
        {
            outluToplam = value1 + value2;
        }

        #endregion
    }
    #region Farkli sinif icerisinde olusturulmus method
    class MerveninSinifi
    {
        // Sinif disi methodlar cagrilirken methodun public olmasi onemlidir (aksi takdirde kullanilamazlar) erisim belirteci yazilmamis methodlar default'da private'dır
        public int BirTaneDahaToplayici(int value1, int value2) 
        {
            return (value1 + value2);
        }
        
    }
    #endregion
}
