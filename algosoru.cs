
//1.Soru
Console.WriteLine("Sayı adedi: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] sayiDizisi = new int[n];

for (int i = 0; i < n; i++)
{
    int a = Convert.ToInt32(Console.ReadLine());
    
        sayiDizisi[i] = a;
    
}

for (int i = 0; i < n; i++) { 

    if (sayiDizisi[i] % 2 == 0)
    {
        Console.WriteLine(sayiDizisi[i]);
    }
}


//2.Soru

Console.WriteLine("Kaç sayı girmek istiyorsunuz: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] sayiDizisi = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write(i+1+". sayi: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    sayiDizisi[i] = sayi;
}

Console.WriteLine("Aramak istediğiniz sayı: ");
int m = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < sayiDizisi.Length; i++)
{
    if (sayiDizisi[i] == m || m % sayiDizisi[i]  == 0)
    {
        Console.WriteLine(sayiDizisi[i]);
    }
}



//3.soru
Console.WriteLine("Kaç kelime girmek istiyorsunuz: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] kelimeler = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write("kelime " + (i+1) + ": ");
    string kelime = Console.ReadLine();
    kelimeler[i] = kelime;
}

for (int i = n; i > 0 ; i--)
{
    Console.WriteLine(kelimeler[i-1] + " ");
}



//4.soru
Console.WriteLine("Bir cümle yaz ");
string n = Console.ReadLine();
int sayac=0;
string[] cumleDizi = n.Split(" ");

Console.WriteLine("Kelime Sayısı:" + cumleDizi.Length);

foreach (string s in cumleDizi)
{
    sayac += s.Length;

}
Console.WriteLine(sayac);