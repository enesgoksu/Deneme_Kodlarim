namespace deneme2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            // Console.WriteLine("İsminizi girin: ");
            // string name = Console.ReadLine();
            // Console.WriteLine("Soyisminizi girin: ");
            // string surname = Console.ReadLine();
            // Console.WriteLine("Merhaba, " + name +" "+ surname);

                Console.WriteLine("***********************");

            // int vize,final;
            // decimal ort;
            // Console.WriteLine("İsminiz: ");
            // string name = Console.ReadLine();
            // Console.WriteLine("Soyisminiz: ");
            // string surname = Console.ReadLine();
            // Console.WriteLine("Numaranız: ");
            // Console.ReadLine();
            // Console.WriteLine("Vize Notu: ");
            // vize = int.Parse(Console.ReadLine());
            // Console.WriteLine("Final Notu: ");
            // final = int.Parse(Console.ReadLine());
            // ort = (vize * 30 / 100) + (final * 70 /100);
            // Console.WriteLine("İsim Soyisim,"+ name+" "+ surname +" "+ "ortalamanız: "+ ort);

                Console.WriteLine("***********************");

            // string Email = "enesgoksu@outlook.com";
            // string Password = "12345";

            // Console.Write("Email: ");
            // string email = Console.ReadLine();
            // Console.Write("Password: ");
            // string password = Console.ReadLine();

            // if((email == Email) && (password == Password))
            //     Console.WriteLine("Giriş yapıldı.");
            // else if((email != Email) && (password == Password))
            //     Console.WriteLine("Email bilginiz yanlıştır.");
            // else if((email == Email) && (password != Password))
            //     Console.WriteLine("Password bilginiz yanlıştır.");
            // else if((email != Email) && (password != Password))
            //     Console.WriteLine("Email ve password bilgileriniz yanlıştır.");

                Console.WriteLine("***********************");

            
            // Console.WriteLine("Bir sayı girin: ");
            // int sayi = int.Parse(Console.ReadLine());

            // for(int x = 1; x <= sayi; x++)

            //     if(x % 2 == 1)
            //         Console.WriteLine(x);

            // int tektoplam = 0;
            // int cifttoplam= 0;
            // int sayi = int.Parse(Console.ReadLine());

            // for(int x = 1; x <= sayi; x++)
            //     if(x % 2 == 0)
            //         cifttoplam += x;
                        
            //     else if(x % 2 == 1)
            //         tektoplam += x;
                        

            //         Console.WriteLine(cifttoplam);
            //         Console.WriteLine(tektoplam);

                Console.WriteLine("***********************");

            // int[] arr = {1,5,0,-1,-8};
            // int positivenumbers = 0;
            // int negativenumbers = 0;
            // int zeronumbers = 0;
            // int arraylength = arr.Count();

            // for (int i = 0; i < arr.Count(); i++)
            // {
            //     if(arr[i] > 0)
            //         positivenumbers ++;
            //     else if(arr[i] < 0)
            //         negativenumbers ++;
            //     else
            //         zeronumbers ++;
            // }

            //     Console.WriteLine(Math.Round((double)positivenumbers / arraylength,6));
            //     Console.WriteLine(Math.Round((double)negativenumbers / arraylength,6));
            //     Console.WriteLine(Math.Round((double)zeronumbers / arraylength,6));
            
            // Çarpım Tablosu

            // Console.WriteLine("Bir sayı giriniz: ");
            // int sayi = int.Parse(Console.ReadLine());
            
            // for (int i = 1; i <= sayi; i++)
            // {
            //     Console.WriteLine(+sayi +"*"+i+"="+ sayi * i);
            // }

                Console.WriteLine("***********************");


            // 10 tane sayı gir ve bu sayıların en büyüğü bana yazdır.
        //    int[] numbers = new int[10];

        //    Console.WriteLine("10 adet sayı giriniz: ");

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //         Console.Write("{0}. sayıyı girin: ", i+1);
        //         2
        //    }

        //         int maxnumber = numbers[0];
        //     for (int i = 1; i < numbers.Length; i++)
        //         {
        //             if(numbers[i] > maxnumber)
        //             maxnumber = numbers[i];
        //         }
        //             Console.WriteLine(maxnumber);


                Console.WriteLine("***********************");


             // Klavyeden öğrencinin 2 adet not bilgisini girildikten sonra, ortalama 50 ve üzeri ise "Geçti" değilse "Kaldı" yazdıran program.

            // Console.Write("1.sinav notu: ");
            // int sinav1 = int.Parse(Console.ReadLine());
            // Console.Write("2.sinav notu: ");
            // int sinav2 = int.Parse(Console.ReadLine());
            // double ortalama = (sinav1 + sinav2) / 2;
            // if(ortalama < 50)
            //     Console.WriteLine("Ortalamanız: "+ ortalama +" "+"Dersten Kaldınız.");
            // else
            // {
            //     Console.WriteLine("Ortalamanız: "+ ortalama+" "+" Dersten Geçtiniz.");
            // }

                
                Console.WriteLine("***********************");  


            // Klavyeden girilen sayının tek mi, çift mi olduğunu gösteren program

            // Console.Write("Sayıyı giriniz: ");
            // int sayi = int.Parse(Console.ReadLine());

            // if(sayi % 2 == 0)
            //     Console.WriteLine("Girmiş olduğunuz sayı: "+sayi+" "+" Çifttir.");
            // else
            //     Console.WriteLine("Girmiş olduğunuz sayı: "+sayi+" "+"Tektir");

            
                Console.WriteLine("***********************");
                // Bir mağazadan alınan ürünün fiyatı 100 tl ve üzerinde ise 5 tl olan kargı ücreti alınmamaktadır.Ürünün fiyatı girildiğin de toplam ödenmesi gereken tutarı gösteren program.

                double ödemetutari;
                Console.Write("Ürün Fiyatı: ");
                int ürünFiyatı = int.Parse(Console.ReadLine());

                if(ürünFiyatı >= 100)
                    ödemetutari = ürünFiyatı;
                else
                    ödemetutari = ürünFiyatı + 5;
                
                    Console.WriteLine("Toplam Ödeme Tutarınız {0} TL' dir.", ödemetutari);
                   

                Console.WriteLine("***********************");
                // Klavyeden girilen sayının negatif,pozitif veya sıfır olduğunu gösteren program.

                // Console.Write("Sayıyı giriniz: ");
                // int sayi = int.Parse(Console.ReadLine());
                // if(sayi > 0)
                //     Console.WriteLine("Girmiş olduğunuz sayı: "+sayi+" "+"Pozitiftir.");
                // else if(sayi < 0)
                //     Console.WriteLine("Girmiş olduğunuz sayı: "+sayi+" "+"Negatiftir");
                // else
                //     Console.WriteLine("Girmiş olduğunuz sayı: "+sayi+" "+"Sıfırdır");

                Console.WriteLine("***********************");
                //Kullanıcıdan girdiği iki sayı ve yapılacak işlem türü(toplama,çıkarma,çarpma,bölme) seçildiğinde sonucu hesaplayarak ekrandan gösteren program.

                // double sonuc = 0;
                // Console.Write("1.sayıyı giriniz: ");
                // int sayi1 = int.Parse(Console.ReadLine());
                // Console.Write("2.sayıyı giriniz: ");
                // int sayi2 = int.Parse(Console.ReadLine());
                // Console.WriteLine("Toplama için---> t \n Çıkarma için---> ç \n Çarpma için---> x \n");
                // string islem = Console.ReadLine();
                // if(islem == "t")
                //     sonuc = sayi1 + sayi2;
                // else if(islem == "ç")
                //     sonuc = sayi1 - sayi2;
                // else if(islem == "x")
                //     sonuc = sayi1 * sayi2;
                
                // Console.WriteLine(sonuc);


                Console.WriteLine("***********************");
                //Klavyeden iki ürünün fiyatı girildiğin de toplam fiyat 200 TL'den fazla ise, 2.üründen %25 indirim yaparak ödenecek tutarı gösteren uygulamayı yapalım.

                // Console.Write("1.ürün fiyatı: ");
                // int ürün1 = int.Parse(Console.ReadLine());
                // Console.Write("2.ürün fiyatı: ");
                // int ürün2 = int.Parse(Console.ReadLine());
                // double toplamFiyat = ürün1 + ürün2;
                // double indirimliFiyat = 0;

                
                // if(toplamFiyat > 200)
                //     indirimliFiyat = ürün1 + (ürün2 - ürün2 * 25 / 100);
                    
                // else
                //     indirimliFiyat = ürün1 + ürün2;
                //     Console.WriteLine("Ödeyeceğiniz tutar {0} TL dir.", indirimliFiyat);
                

                Console.WriteLine("***********************");
                //
                        
                    
                   
                     
                
                
                    

            

        }
    }
}