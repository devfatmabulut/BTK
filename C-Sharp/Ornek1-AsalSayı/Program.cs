// See https://aka.ms/new-console-template for more information
// Girdiğimiz sayının Asal Sayı olup olmadığı bilgisini veren program

Console.WriteLine("SAYI GİRİNİZ : ");
int sayi =Convert.ToInt32(Console.ReadLine());

if (IsPrimeNumber(sayi))
{
    Console.WriteLine("Asal sayıdır");
}
else
{
     Console.WriteLine("Asal değildir."); 
}


static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number-1; i++)
    {
        if (number%i==0)
        {
            result = false;
            i = number;
        }
    }
    return result;
}
