Console.WriteLine("\"Kim Milyoner Olmak İster?\" Yarışmasına Hoş Geldiniz.");
Console.WriteLine("Kurallar çok basit 3 sorudan 2'sine doğru cevap ver, büyük ödülü kazan. Başarılar!");

// Doğru cevapların sayısını kontrol eden değişkenimiz.
int counter = 0;

Console.WriteLine("\nKızınca tüküren hayvan hangisidir?\nA) Lama       B) Deve");
string choice = Console.ReadLine();

// Kulanıcıdan aldığım cevabın büyük küçük harf duyarlılığını yok etmek için kullandığım yöntem.
string lowerChoice = choice.ToLower();

if (lowerChoice == "a")
{
    counter += 1; // Her doğru cevapta counter değeri 1 artacak.
    Console.WriteLine("Bravo! Doğru cevap verdiniz.");
    Console.WriteLine("Sıradaki soru geliyor...");  
}
else
{
    Console.WriteLine("Maalesef doğru cevap A şıkkı Lama olacaktı.");
    Console.WriteLine("Sıradaki soru geliyor...");
}

Console.WriteLine("\nDünya'ya en yakın gezegen hangisidir?\nA) Venüs       B) Mars");
string secondChoice = Console.ReadLine();

string secondLower = secondChoice.ToLower();

if ( secondLower == "a" )
{
    counter += 1;
    Console.WriteLine("Bravo! Doğru cevap verdiniz. ");
}
else
{
    Console.WriteLine("Maalesef doğru cevap A şıkkı Venüs olacaktı.");
}

// Burada switch-case karar yapısına geçtim verdiği cevaba göre ve doğru sayısındaki duruma göre diğer işlemleri atlayacak.

switch (counter)
{
    case 2:
        Console.WriteLine("Tebrikler! Bir Milyon TL'nin sahibi oldunuz.");
        break;
    case 1:
        Console.WriteLine("Sıradaki soru geliyor...");
        Console.WriteLine("\n5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?\nA)7      B)12");
        string thirdChoice = Console.ReadLine();

        string thirdLower = thirdChoice.ToLower();
        if (thirdChoice == "b")
        {
            counter += 1;
            Console.WriteLine("Tebrikler! Bir Milyon TL'nin sahibi oldunuz.");
        }
        else if (counter <= 1)
        {
            Console.WriteLine("Maalesef doğru cevap B şıkkı 12 olacaktı.");
            Console.WriteLine("Maalesef büyük ödülü kaybettin. İstersen şansını tekrar dene.");
        }
        break;
    default:
        Console.WriteLine("Maalesef büyük ödülü kaybettin. İstersen şansını tekrar dene.");
        break;
}

