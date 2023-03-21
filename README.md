# Deneme_Kodlarim
Deneme Kodlamalar Yaptığım Uygulamalar

## Proje -1
### İsim ve Soyisim bilgileri alınarak konsolda yazdırma işlemi.
```

             Console.WriteLine("İsminizi girin: ");
             string name = Console.ReadLine();
             Console.WriteLine("Soyisminizi girin: ");
             string surname = Console.ReadLine();
             Console.WriteLine("Merhaba, " + name +" "+ surname);
```
## Proje -2
### Vize bilgisinin alınarak %30'u ve Final bilgisinin alınarak %70'i hesaplanıp toplamlarının ortalamayı verme işlemi
```
            int vize,final;
            decimal ort;
            Console.WriteLine("İsminiz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminiz: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Numaranız: ");
            Console.ReadLine();
            Console.WriteLine("Vize Notu: ");
            vize = int.Parse(Console.ReadLine());
            Console.WriteLine("Final Notu: ");
            final = int.Parse(Console.ReadLine());
            ort = (vize * 30 / 100) + (final * 70 /100);
            Console.WriteLine("İsim Soyisim,"+ name+" "+ surname +" "+ "ortalamanız: "+ ort);
```
## Proje -3
### Email ve Password bilgileri alınarak databasedeki bilgiler ile uyuşup kontrol edildiği ve giriş aşamasının yapılıp yapılmadığı, alınan bir hata olup olmadığını verme işlemi.
```
    string Email = "enesgoksu@outlook.com";
            string Password = "12345";

            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            if((email == Email) && (password == Password))
                Console.WriteLine("Giriş yapıldı.");
            else if((email != Email) && (password == Password))
                Console.WriteLine("Email bilginiz yanlıştır.");
            else if((email == Email) && (password != Password))
                Console.WriteLine("Password bilginiz yanlıştır.");
            else if((email != Email) && (password != Password))
                Console.WriteLine("Email ve password bilgileriniz yanlıştır.");
```