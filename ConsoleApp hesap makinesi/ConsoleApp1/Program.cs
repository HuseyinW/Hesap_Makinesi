double sayi1=0;
double sayi2=0;
string islem="";
double sonuc=0;
bool hata=false;

Console.Write("1. Sayıyı Giriniz => ");
sayi1 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("2. Sayıyı Giriniz => ");
sayi2 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Sayılara hangi işlemi yaptıracağınızı seçiniz(+,-,*,/): ");
islem = Console.ReadLine();


switch (islem)
{
	case "+": sonuc = sayi1 + sayi2; break;
	case "-":
		if (sayi1 < sayi2)
		{
			sonuc = sayi2 - sayi1;
		}
		else
		{
			sonuc = sayi1 - sayi2;
		}
		break;

	case "*": sonuc = sayi1 * sayi2; break;
	case "/": sonuc = sayi1 / sayi2; break;
	default: hata = true; break;
}
if (hata) 
{
	Console.WriteLine("Hatalı Giriş");
}
	else
	{
        Console.WriteLine("{0} {1} {2} = {3}", sayi1, islem, sayi2, sonuc);

    }
