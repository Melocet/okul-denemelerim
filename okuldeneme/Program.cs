using System;

namespace Okul
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            /*
            Console.Write("1. sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());
            int toplam = sayi1 + sayi2;
            Console.Write("sayıların toplamı= {0}", toplam.ToString());
            //Console.Write(toplam.ToString());
            Console.ReadLine();
            */
            /////////////////////////////////////////////////////////////////////
            /*

            Console.Write("1. sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("Aracı girin: ");
            char islem = char.Parse(Console.ReadLine());
            double sonuc = 0.0;
            if (islem=='+')
            {
                sonuc = sayi1 + sayi2;
            }
            if (islem== '-')
            {
                sonuc = sayi1 - sayi2;
            }
            if (islem== '%')
            {
                sonuc = sayi1 / sayi2;
            }
            if (islem== 'x')
            {
                sonuc = sayi1 * sayi2;
            }
            Console.Write("Sonuç= {0}", sonuc.ToString());

            */
            ///////////////////////////////////////////////////////////////////////
            /*
            Console.Write("1.sınav notu");
            int sinav1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sınav notu giriniz:");
            int sinav2 = int.Parse(Console.ReadLine());
            Console.Write("3. Sınav notu giriniz:");
            int sinav3 = int.Parse(Console.ReadLine());



            char degiskenadi = 'A';
            string degiskenadi4 = "Değeri";
            int degiskenismi = 11;
            float degisken_ismi2 = 22.4f;
            double degisken_ismi3 = 22.4;

            Console.Write("Char değişken değeri=");
            Console.WriteLine(degiskenadi);
            */
            /*

            Console.Write("yazı gir: ");
            string yazi = (Console.ReadLine());

            Console.Write("Yazı değeri=");
            Console.WriteLine(yazi);

            Console.ReadLine();
            */
            /*
            Console.Write("1. sayı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. sayı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("3. sayı giriniz: ");
            int sayi3 = int.Parse(Console.ReadLine());
            if (sayi1 > sayi2 && sayi1 > sayi3)
                {
                    Console.Write("En büyük 1. sayıdır");
                }
            if (sayi2 > sayi3 && sayi2 > sayi1)
            {
                Console.Write("En büyük sayı 2 dir");
            }
            if (sayi3 > sayi2 && sayi3 > sayi1)
            {
                Console.Write("En büyük sayı 3 dür");
            }
            */


            /*

            Console.Write("Sayı: ");
            int sayi;
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 5 == 0)
            {
                Console.Write("BOOM", sayi);
            }
            else
            {
                Console.Write("{0}", sayi);
            }
            */
            /*
            Console.Write("Üçgenin 1. kenarı: ");
            int kenar1 = int.Parse(Console.ReadLine());
            Console.Write("Üçgenin 2. kenarı: ");
            int kenar2 = int.Parse(Console.ReadLine());
            Console.Write("Üçgenin 3. Kenarı: ");
            int kenar3 = int.Parse(Console.ReadLine());
            if (kenar1 == kenar2 && kenar1 == kenar3)
            {
                Console.WriteLine("Eşkenar üçgen");
            }
            if (kenar1 == kenar3 || kenar1 == kenar2 || kenar3 == kenar2 || kenar3 == kenar2)
            {
                Console.WriteLine("İkizkenar üçgen");
            }
            */

            /*
            Console.Write("1. Sınav notu: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sınav notu: ");
            int sayi2 = int.Parse(Console.ReadLine());
            double sinav = (sayi1 + sayi2)/2 ;
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
            if (sinav >= 0 && sinav <= 25)
            {

                Console.WriteLine("Notunuz 0");
            }
             if (sinav >= 25 && sinav <= 44)
            {
                Console.WriteLine("Notunuz 1");
            }
             if (sinav >= 45 && sinav <=54)
            {
                Console.WriteLine("Notunuz 2");
            }
             if (sinav >= 55 && sinav <= 69)
            {
                Console.WriteLine("Notunuz: 3");
            }
            if (sinav >= 70 && sinav <= 84)
            {
                Console.WriteLine("Notununuz: 4");
            }
            if (sinav >= 85 && sinav <= 100)
            {
                Console.WriteLine("Notununuz: 5");
            }
            if (sinav >= 100 && sinav <= 1000)
            {
                Console.WriteLine("Notununuz: 5");
            }

            Console.WriteLine("Ortalamanız: " + sinav);
            */

            /*
            string yazi;
            Console.Write("Yazı: ");
            yazi = Console.ReadLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("");

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("{1}", (i + 1), yazi);
            }

            Console.WriteLine("");
            Console.WriteLine("--------------------------");

            Console.ReadLine();

            */
            /*
            Console.Write("Sayı: ");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi % 7 == 0)
            {
                Console.WriteLine("7 nin katı");
            }
            else
            {
                Console.Write("{0}", sayi);
            }
            */

            /*
            int toplam = 0;

            for (int i = 1; i <= 10; i++)
            {
                toplam += i;

            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("");    
            Console.WriteLine("toplam : " + toplam);       
            Console.WriteLine("");
            Console.WriteLine("--------------------------");
            Console.ReadLine();
            */
            /*
            int sayi;
            Console.WriteLine("Sayı: ");
            Console.WriteLine("");
            Console.WriteLine("--------------------------");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                Console.Write("Sayı pozitif: {0}", sayi);
            }
            else if (sayi < 0)
            {
                Console.Write("Sayı negatif: {0}", sayi);
            }
            else
            {
                Console.Write("Sayı 0");
            }
            Console.ReadLine();
            */
            /*

            Console.Write("Başlangıç Sayısı: ");
            int basla = int.Parse(Console.ReadLine());
            Console.Write("Bitiş Sayısı: ");
            int bitis = int.Parse(Console.ReadLine());
            for (int sayi = basla; sayi <= bitis; sayi++)
            {
                if (sayi % 5 == 0)
                {
                    Console.WriteLine("BOOM");
                }
                else
                {
                    Console.WriteLine(sayi.ToString());
                }
            */
            /*
            Console.Write("Başlangıç Sayısı: ");
            int basla = int.Parse(Console.ReadLine());
            Console.Write("Bitiş Sayısı: ");
            int bitis = int.Parse(Console.ReadLine());

            Console.WriteLine("Çift Sayılar");

                    for (int cift = basla; cift <= bitis; cift+=2)
                    {
                        Console.WriteLine(cift);
                    }
                    Console.WriteLine("Tek sayılar");

                for (int tek = basla; tek <=bitis; tek +=2)

                if (tek % 2 == 1)
                {
                Console.WriteLine(tek);
                }
            */
            /*
            Console.Write("3/5/7 sec: ");
            char secme = char.Parse(Console.ReadLine());
            if (secme == '3')
            {
                Console.WriteLine("3.ün kat sayıları");
                for (int i = 0; i <= 100; i++)
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i.ToString());
                    }
            }
            if (secme == '5')
            {
                Console.WriteLine("5.ün kat sayıları");
                for (int i = 0; i <= 100; i++)
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i.ToString());
                    }
            }
            if (secme == '7')
            {
                Console.WriteLine("7.nin kat sayıları");
                for (int i = 0; i <= 100; i++)
                    if (i % 7 == 0)
                    {
                        Console.WriteLine(i.ToString());
                    }
            }


            /*
            Console.WriteLine("Çift Sayılar");

            for (int cift = basla; cift <= bitis; cift += 2)
            {
                Console.WriteLine(cift);
            }
            Console.WriteLine("Tek sayılar");

            for (int tek = basla; tek <= bitis; tek += 2)

                if (tek % 2 == 1)
                {
                    Console.WriteLine(tek);
                }
                if (i % 5 == 0)
                {
                Console.Write(i.ToString);
                }

            */
            /*
            Console.Write("Kullanıcı adınız: ");
            string kullad = (Console.ReadLine());
            Console.Write("Şifre: ");
            string sifre = (Console.ReadLine());
            {
                for (int kullhak = 1; kullhak <= 3; kullhak++)

                    if (kullad == "admin" && sifre == "12345")

                    {
                        Console.WriteLine("Giriş Başarılı");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı adı veya şifre hatalı");
                    }
            }
            */
            /*

            for (int kullhak = 1; kullhak <= 3; kullhak++)

            {
                Console.Write("Kullanıcı adınız: ");
                string kullad = (Console.ReadLine());
                Console.Write("Şifre: ");
                string sifre = (Console.ReadLine());

                if (kullad == "admin" && sifre == "12345")
                {
                    Console.WriteLine("Giriş başarılı");
                    break;
                }
                else if (kullad != "admin" || sifre != "12345")
                {
                    Console.WriteLine("Kullanıcı adı veya şifre hatalı");
                }

            }
            */

            /*
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i.ToString());
                    continue;
                }
                else if (i % 2 == 1)
                {
                    Console.WriteLine(i.ToString());
                    break;
                }
            }

            */
            /*
            Random rastgele = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int sayi = rastgele.Next(0, 50);
                Console.WriteLine("Sayı: " + sayi.ToString());

            }
            */

            /*
            Random r = new Random();
            int  toplam = 0;            
            for (int i = 0; i < 10; i++)
            {
                int rastgele = r.Next(0, 5);
                toplam+= rastgele;

                Console.WriteLine("Sayılar: " + rastgele.ToString());
            }
            Console.WriteLine("Sayı = {0}", toplam);
            */
            /*
            int toplamteksayilar = 0;
            Random rastgele = new Random();
            for (int i = 1; i <=10; i++)
            {
                int sayi = rastgele.Next(1, 10);
                Console.WriteLine("rastgele sayı: " + sayi.ToString());
                if (sayi % 2 == 1)
                {
                    toplamteksayilar += sayi;
                }
            }
            Console.WriteLine("tek Sayilar: {0} ", toplamteksayilar.ToString());
            */

            /*
            Console.Write("Başlangıç Sayısı: ");
            int basla = int.Parse(Console.ReadLine());
            Console.Write("Bitiş Sayısı: ");
            int bitis = int.Parse(Console.ReadLine());

            int toplamteksayilar = 0;
            int ciftsayilar = 0;
            Random rastgele = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int sayi = rastgele.Next(basla, bitis);
                Console.WriteLine("rastgele sayı: " + sayi.ToString());
                if (sayi % 2 == 1)
                {
                    toplamteksayilar += sayi;
                }
                if (sayi % 2 == 0)
                {
                    ciftsayilar += sayi;
                }
            }

                Console.WriteLine("tek Sayilar: {0} ", toplamteksayilar.ToString());
                Console.WriteLine("çift sayılar: {0}", ciftsayilar.ToString());

            */

            /*
            Random r = new Random();
            int rastgele = r.Next(1, 5);

            for (int i = 1; i <= 6; i++)
            {
                Console.Write("Sayı: ");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi == rastgele)
                {
                    Console.WriteLine("Sayıyı bildiniz! {0}", rastgele);
                    break;
                }
                else
                {
                    Console.WriteLine("Sayıyı Bilemediniz");
                }
            }
            Console.ReadLine();
            */
            /*
            Console.Write("Hak: ");
            int hak = int.Parse(Console.ReadLine());
            Random r = new Random();
            int rastgele = r.Next(1, 5);

            for (int i = 1; i <= hak; i++)
            {
                Console.Write("Sayı: ");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi == rastgele)
                {
                    Console.WriteLine("Sayıyı bildiniz! {0}", rastgele);
                    break;
                }
                else
                {
                    Console.WriteLine("Sayıyı Bilemediniz... ");
                }
            }
            */
            /*
            Console.Write("Başlangıç Sayısı: ");
            int basla = int.Parse(Console.ReadLine());
            Console.Write("Bitiş Sayısı: ");
            int bitis = int.Parse(Console.ReadLine());
            Console.Write("Artış: ");
            int artis = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------");
            Console.WriteLine("Çift Sayılar:");
            Random rastgele = new Random();
                for (int i = basla; i <= bitis; i+= artis)
                {
                if (i % 2 == 0)
                        Console.WriteLine(i);
                }
            Console.WriteLine("---------------------");
            Console.WriteLine("Tek Sayılar:");
            for (int i = basla; i <= bitis; i+= artis)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }
            */
            /*
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            */
            /*
            Console.Write("Laf: ");
            string deger = (Console.ReadLine());
            Console.Write("Kaç kere yazim: ");
            int kackere = int.Parse(Console.ReadLine());
            int i = 1; // Başlangıç parametresi
            while (i <= kackere) // Bitiş Parametresi
            {
                Console.WriteLine(deger); // komut
                i++; // Artış Miktarı
            }
            */
            /*
            Console.Write("Başlangıç Sayısı: ");
            int basla = int.Parse(Console.ReadLine());
            Console.Write("Bitiş Sayısı: ");
            int bitis = int.Parse(Console.ReadLine());
            Console.Write("Artış: ");
            int artis = int.Parse(Console.ReadLine());
            int i = basla
            Console.WriteLine("-------------");
            Console.WriteLine("Çift sayılar");
            int c = basla; // Başlangıç parametresi
            while (c <= bitis) // Bitiş Parametresi
            {
                if (c % 2 == 0)
                    Console.WriteLine(c); // komut
                c+= artis; // Artış Miktarı
            }
            Console.WriteLine("-------------");
            Console.WriteLine("Tek sayılar");
            int c = basla; // Başlangıç parametresi
            while (c <= bitis) // Bitiş Parametresi
            {
                if (c % 2 == 0)
                    Console.WriteLine(c); // komut
                c+= artis; // Artış Miktarı
            }

            */
            /*
            Console.Write("Taban Giriniz: ");
            int taban = int.Parse(Console.ReadLine());
            Console.Write("Kuvvet giriniz: ");
            int sonuc = 1;
            int kuvvet = int.Parse(Console.ReadLine());
            for (int i = 1; i <= kuvvet; i++)
            {
                sonuc *= taban;
            }
            Console.WriteLine(sonuc);

            Console.ReadLine();
            */
            /*
            Console.Write("Taban Giriniz: ");
            int taban = int.Parse(Console.ReadLine());
            Console.Write("Kuvvet giriniz: ");
            int kuvvet = int.Parse(Console.ReadLine());
            int sonuc = 1;
            int i = 1;
            while (i <= kuvvet)
            {
                sonuc *= taban;
                i++;
            }
            Console.WriteLine(sonuc);
            */
            /*

            for (int asama = 1; asama <= asama++;)

            {
                Console.WriteLine("[1] Kayıt Ekleme");
                Console.WriteLine("[2] Kayıt Listeleme");
                Console.WriteLine("[3] Kayıt Güncelleme");
                Console.WriteLine("[4] Kayıt Silme");
                Console.WriteLine("[5] Çıkış");

                Console.Write("Seçiniz: ");
                string secim = (Console.ReadLine());

                if (secim == "5")
                {
                    Console.WriteLine("Çıkış Yaptınız");
                    break;
                }
                else
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Seçiminiz >> {0}      |", secim);
                    Console.WriteLine("---------------------");
                }


            }
            */
            /*
            Random r = new Random();
            int rastgele = r.Next(1, 3);

            int hak = 3;
            while (hak <= 3)
            {  
                Console.Write("Sayı: ");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi == rastgele)
                {
                    Console.WriteLine("Sayıyı bildiniz! {0}", rastgele);
                    break;
                }
                if (sayi != rastgele)
                {
                    Console.WriteLine("Sayıyı Bilemediniz! Kalan hakkınız: {0}", hak);
                }
                if (hak == 0)
                {
                    Console.WriteLine("Başka hakkınız Kalmadı");
                    break;
                }
                hak = hak - 1;
            }
            */
            /*
            int kullhak = 2;
            while (kullhak <= 2)

            {
                Console.Write("Kullanıcı adınız: ");
                string kullad = (Console.ReadLine());
                Console.Write("Şifre: ");
                string sifre = (Console.ReadLine());

                if (kullad == "admin" && sifre == "12345")
                {
                    Console.WriteLine("Giriş başarılı");
                    break;
                }
                else if (kullad != "admin" || sifre != "12345")
                {
                    Console.WriteLine("Kullanıcı adı veya şifre hatalı. kalan hak: {0}", kullhak.ToString());
                }
                if (kullhak == 0)
                {                           
                    Console.WriteLine("Başka hakkınız kalmadı");
                    break;
                }
                kullhak = kullhak - 1;

            }
            */

            // WHILE //
            /*
            int toplam = 0;
            int i = 0;
            while (i <= 10)
            {
                toplam += i;
                i++;
            }
            Console.WriteLine("Sayıların toplamı: {0}", toplam);
            */
            /*
            for (int i = 0; i < 11; i++)
            {
                Console.SetCursorPosition(i,i);
                Console.WriteLine("{1}", (i + 1), "Mehmet");
            }
            */

            /*

            for (int i = 0; i < 150; i++)
            {
                Console.Clear();
                Console.Write("Mehmet ");
                Thread.Sleep(3500);
                Console.Clear();
                Console.Write("Mehmet ");
                Console.Clear();
                Console.Write("Mehmet ");
                Thread.Sleep(3500);
                Console.Write("Mehmet ");
                Thread.Sleep(250);
                Console.Write("Mehmet ");
                Thread.Sleep(250);
                Console.Write("Mehmet ");
                Thread.Sleep(250);
                Console.Clear();
                // Console.Clear();
                */

            /*
            Console.Write("1. sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("Türü girin: ");
            char islem = char.Parse(Console.ReadLine());
            int sonuc = 0;
            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    break;
                case '%':
                    sonuc = sayi1 / sayi2;
                    break;
                case 'x':
                    sonuc = sayi1 * sayi2;
                    break;
                default:
                    Console.WriteLine("Hatalı işlem");
                    break;

            }
            Console.Write("Sonuç = {0}", sonuc.ToString());
            */

            /*
            Console.Write("1. sayı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. sayı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());
            switch (sayi1 > sayi2)
            {
                case true:
                    Console.Write("Büyük sayı: {0}", sayi1.ToString());
                    break;
                case false:
                    Console.WriteLine("Büyük sayı: {0}",sayi2.ToString());
                    break;
                default:
                    Console.WriteLine("Hatalı işlem");
                    break;
            }
            */
            /*
            {
                Console.WriteLine("[1] Kayıt Ekleme");
                Console.WriteLine("[2] Kayıt Listeleme");
                Console.WriteLine("[3] Kayıt Güncelleme");
                Console.WriteLine("[4] Kayıt Silme");
                Console.WriteLine("[5] Çıkış");
                Console.Write("Seçiniz: ");
                char secim = char.Parse(Console.ReadLine());
                switch (secim)
                {           
                    case '5':
                    Console.WriteLine("Çıkış Yaptınız");
                        break;
                    case '2':
                    Console.WriteLine("Kayıt eklendi", secim);
                        break;
                    case '3':
                        Console.WriteLine("Kayıt günclenedi", secim);
                        break;
                    case '4':
                        Console.WriteLine("Kayıt silindi", secim);
                        break;
                    default:
                Console.WriteLine("İşlem hatalı");
                        break;
                }
            }
                */
            /*
            Console.Write("Gir bura sayi: ");
            int sayi = int.Parse(Console.ReadLine());
            int sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            Console.WriteLine(sonuc);
            */
            /*
            Console.Write("Gir bura sayi: ");
            int sayi = int.Parse(Console.ReadLine());
            int sonuc = 1;
            int i = 1;
            while (i <= sayi)
            {
                sonuc *= i;
                i++;
            }
            Console.WriteLine(sonuc);
            Console.ReadLine();
            */

            /*
            Console.Write("Renk ne olsun: ");
            string renk = (Console.ReadLine());
            Console.Write("Arkadaki renk ne olsun: ");
            string ark = (Console.ReadLine());
            if (ark == "Mavi")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            if (ark == "Kırmızı")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (ark == "Beyaz")
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            switch (renk)
            {
                case "Mavi":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Bak mavi oldum");
                    break;
                case "Kırmızı":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bak Kırmızı oldum");
                    break;
                case "Beyaz":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Bak beyaz oldum");
                    break;
                default:
                    Console.WriteLine("Hatalı işlem");
                    break;

            }
            */
            /*
            Console.Write("Faktöriyelmi, Kuvvetmi, Kullanıcı adımı?: ");
            string soru = (Console.ReadLine());
            switch (soru)
            {
                case "Kuv":
                    Console.Write("Taban Giriniz: ");
                    int taban = int.Parse(Console.ReadLine());
                    Console.Write("Kuvvet giriniz: ");
                    int sonuccc = 1;
                    int kuvvet = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= kuvvet; i++)
                    {
                        sonuccc *= taban;
                    }
                    Console.WriteLine("Kuvvet sonuç: {0}", sonuccc.ToString());
                    break;
                case "Fak":
                    Console.Write("Faktoriyel Sayı: ");
                    int sayi = int.Parse(Console.ReadLine());
                    int sonucc = 1;
                    for (int i = 1; i <= sayi; i++)
                    {
                        sonucc *= i;
                    }
                    Console.WriteLine("Sonuç: {0}", sonucc);
                    break;
                case "Kull":
                    Console.Write("Kullanıcı adınız: ");
                    string kullad = (Console.ReadLine());
                    Console.Write("Şifre: ");
                    string sifre = (Console.ReadLine());

                    if (kullad == "admin" && sifre == "12345")
                    {
                        Console.WriteLine("Giriş başarılı");
                    }
                    else
                    {
                        Console.WriteLine("Yanlış kullanıcı adı şifre!");
                    }
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hatalı İşlem");
                    break;
            }
            */

            /*
            string uzunluk;
            Console.Write("Kelime: ");
            string deger = Console.ReadLine();
            for (int i = deger.Length - 1; i >= 0; i--)
            {
                Console.Write(deger[i]);
                Console.WriteLine(uzunluk.Length);
            }
            
            */

            /*
            Random rastgele = new Random();
            for (int i = 1; i <= 1; i++)
            {
                int gunn = rastgele.Next(1, 30);
                int ayy = rastgele.Next(1, 12);
                Console.WriteLine("Şanslı gününüz ayın: {0} Günü, {1}' aydır", gunn, ayy);

            }
            */
            /*
            Random rastgele = new Random();
            int hafta = rastgele.Next(1, 7);
            Console.WriteLine("Hafta Günü: " + hafta);

            switch (hafta)
            {
                case 1:
                    Console.Write("Pazartesi");
                    break;
                case 2:
                    Console.Write("Salı");
                    break;
                case 3:
                    Console.Write("Çarşamba");
                    break;
                case 4:
                    Console.Write("Perşembe");
                    break;
                case 5:
                    Console.Write("Cuma");
                    break;
                case 6:
                    Console.Write("Cumartesi");
                    break;
                case 7:
                    Console.Write("Pazar");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hatalı İşlem");
                    break;
            }
            */
            /*
            Random rastgele = new Random();
            int ay = rastgele.Next(1, 12);
            Console.WriteLine("Ay günü: " + ay.ToString());
            switch (ay)
            {
                case 1:
                    int i
                    Console.Write("Ocak");
                    break;
                case 2:
                    Console.Write("Şubat");
                    break;
                case 3:
                    Console.Write("Mart");
                    break;
                case 4:
                    Console.Write("Nisan");
                    break;
                case 5:
                    Console.Write("Mayıs");
                    break;
                case 6:
                    Console.Write("Haziran");
                    break;
                case 7:
                    Console.Write("Temmuz");
                    break;
                case 8:
                    Console.Write("Ağustos");
                    break;
                case 9:
                    Console.Write("Eylül");
                    break;
                case 10:
                    Console.Write("Ekim");
                    break;
                case 11:
                    Console.Write("Kasım");
                    break;
                case 12:
                    Console.Write("Aralık");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hatalı İşlem");
                    break;
            }
            */
            ///////////////////// bozuk //////////////
            /// 
            /*
                       Console.Write("Başlangıç Sayısı: ");
                       int basla = int.Parse(Console.ReadLine());
                       Console.Write("Bitiş Sayısı: ");
                       int bitis = int.Parse(Console.ReadLine());
                       Console.WriteLine("Çift Sayılar");
                       int cift = bitis;
                       while (cift <= bitis)
                           if (cift % 2 == 2)
                           {
                               Console.WriteLine(cift);
                               cift += 2;
                           }
                       Console.WriteLine("Tek sayılar");
                       int tek = basla;
                       while (tek <= bitis)
                           if (tek % 2 == 1)
                           {
                               Console.WriteLine(tek);
                               tek -= 2;

                           }
           */
            /*

             Console.Write("Başlangıç Sayısı: ");
             int basla = int.Parse(Console.ReadLine());
             Console.Write("Bitiş Sayısı: ");
             int bitis = int.Parse(Console.ReadLine());


             Console.WriteLine("Çift sayılar");
             int c = basla;
             while (c <= bitis)
             {
                 if (c % 2 == 0)
                     Console.WriteLine(c);
                 c += 1;
             }
             Console.WriteLine("Tek sayılar");
             int d = bitis;
             while (basla <= d)
             {
                 if (d % 2 == 1)
                     Console.WriteLine(d);
                 d -= 1;

             }
             */




            Console.ReadLine();


        }
    }
}
/*
        while (i <= kackere) // Bitiş Parametresi
            {
                Console.WriteLine(deger); // komut
                i++; // Artış Miktarı
            }
*/
// 
//Console.SetCursorPosition

// Console.BackgroundColor = ConsoleColor.Blue;

//Console.ForegroundColor = ConsoleColor.DarkCyan

//2x ve y nin değerini giriniz 2 çarpı x + 5 artı y

// for (int i = deger.Length - 1; i >= 0; i--)

/*
            Console.Write("Laf: ");
            string deger = (Console.ReadLine());
            Console.Write("Kaç kere yazim: ");
            int kackere = int.Parse(Console.ReadLine());

*/
