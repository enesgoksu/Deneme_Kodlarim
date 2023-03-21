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




            

        }
    }
}