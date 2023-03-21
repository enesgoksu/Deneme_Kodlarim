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

            // Console.WriteLine("Email: ");
            // string email = Console.ReadLine();
            // Console.WriteLine("Password: ");
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

            // 10 tane sayı gir ve bu sayıların en büyüğü bana yazdır.
           int[] numbers = new int[10];

           Console.WriteLine("10 adet sayı giriniz: ");

           for (int i = 0; i < numbers.Length; i++)
           {
                Console.Write("{0}. sayıyı girin: ", i+1);
                numbers[i] = int.Parse(Console.ReadLine());
           }

                int maxnumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                {
                    if(numbers[i] > maxnumber)
                    maxnumber = numbers[i];
                }
                    Console.WriteLine(maxnumber);


            


            

        }
    }
}