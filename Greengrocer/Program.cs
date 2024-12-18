
//Rüya Manavı Uygulamasının If-Else karar yapıları kullanılarak hazırlanmış hali aşağıdaki gibidir.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Rüya Manavı'na Hoş Geldiniz!");
        Console.WriteLine(" Elma = 2 TL\n Armut = 3 TL\n Çilek = 2 TL\n Muz = 3 TL\n Diğer bütün meyveler = 4 TL");

        Console.WriteLine("Hangi meyveyi satın almak istertsiniz? (Elma/Armut/Muz/Diğer): ");
        string? meyve = Console.ReadLine()?.ToLower();

        if (meyve == "elma")

        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2TL'dir.");
        }

        else if (meyve == "armut")

        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3TL'dir.");
        }

        else if (meyve == "çilek")

        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2TL'dir.");
        }

        else if (meyve == "muz")

        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3TL'dir.");
        }

        else

        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4TL'dir.");
        }


    }
}

//Rüya Manavı Uygulamasının Switch-Case karar yapıları kullanılarak hazırlanmış hali aşağıdaki gibidir.
class Program
{
    static void Main()
    {
        Console.WriteLine("Rüya Manavı'na Hoş Geldiniz!");
        Console.WriteLine(" Elma = 2 TL\n Armut = 3 TL\n Çilek = 2 TL\n Muz = 3 TL\n Diğer bütün meyveler = 4 TL");

        Console.WriteLine("Hangi meyveyi satın almak istertsiniz? (Elma/Armut/Muz/Çilek/Diğer): ");
        string? meyve = Console.ReadLine()?.ToLower();

        switch (meyve)
        {
            case "elma":
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 2TL'dir.");
                break;
            case "armut":
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 3 TL'dir.");
                break;
            case "çilek":
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 2TL'dir.");
                break;
            case "muz":
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 3 TL'dir.");
                break;
            default:
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı 4TL'dir.");
                break;
        }


    }

}
//Bence bu tür bir problemi Switch-Case yapısıyla çözmek daha mantıklıdır.
//Çünkü if-else yapısına göre hem daha basit bir yapıdır hemd dekoşullar sabit değerlere bağlıdır.

