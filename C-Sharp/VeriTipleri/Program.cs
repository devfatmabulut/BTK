// Veri Türleri

// İnteger Veri Tipi
// değer tipidir - value type
// -2147483648 .. +2147483647
// 32 bit yer kaplar
// Tam sayı değeri tutar
int number1= 10;
Console.WriteLine("Number is {0}",number1);

// Long Veri Tipi
// integerin 2 katıdır. long > integer
// -9223372036854775808 .. +9223372036854775807
// 64 bit yer kaplar
// Tam sayı değeri tutar

long number2 = 2147483649;
Console.WriteLine("Number is {0}",number2);

// Short Veri Tipi
// 16 bitlik yer tutar 
// -32768 .. +32767 
// long > int > short
// Tam sayı değeri tutar

short number3= 32767;
Console.WriteLine("Number is  {0}", number3);

// Byte Veri Türü
// 8 bit -> 1 byte yer kaplar
// 0 .. 255
// Tam sayı değeri tutar
// long > int > short > byte

byte number4 = 225;
Console.WriteLine("Number is {0}", number4);

// Boolean Veri Türü
// true : false değeri tutar 
// mantıksal veri türüdür

bool condition = true;
bool condition2 = false ;

// Char Veri Türü
// Tek karakter tutar
// '' ile atama yapılır.

char caracter = 'a';
Console.WriteLine("Caracter is {0}", caracter);
Console.WriteLine("Caracter is {0}", (int)caracter); // sayısal karşılık verir.

// Double Veri Türü
// Ondalıklı sayı türlerini tutar.
// 64 bit yer tutar

double number6 = 10.4;
Console.WriteLine("Number is {0}", number6);

// Decimal Veri Türü
// Double x2 değer tutar.
// Ondalıklı sayı türlerini tutar.
// sayı sonunu 'm' harfi eklenerek tanımlanır. m/M fark etmez. 

decimal number5 = 10.4m;
Console.WriteLine("Number is {0}", number5);
// ondalık olmadığında 'm' koymamıza gerek yok.
decimal number52 = 10;
Console.WriteLine("Number is {0}", number52);

// Enum Veri Tipi
// programlamada magic string değerler tutmak yerine 
// dışarıya tanımlayıp class gibi dışarıdan ağırabiliyoruz.
// tip değişimleri önemledir.

Console.WriteLine(Days.Monday); // OUTPUT : Monday
Console.WriteLine((int)Days.Friday); // OUTPUT : 4 (Sabit numarasını verir)
// Enum Sabitinin başlangıç değerini değiştirebiliriz
// Monday = 10 dersek sırasıyla Tuesday = 11, Thursday =12 ... olur.
// Tektekte değiştirebiliriz ancak birsonraki yine devam numarasından başlar 
// Monday = 10 , Tuesday = 50 atayabiliriz ancak bu durumda Thursday = 51, Wenesday = 52 ... olarak devam eder.

enum Days
{
    Monday, Tuesday, Thursday, Wenesday, Friday, Saturday, Sunday
}

// // Var Keyword ile Çalışmak

// var number7 = 10 ; // var = int
// var number7 = 'A';
// Console.WriteLine("Number is {0}", number7); // OUTPUT :  65  -> Çünkü ilk atamamız integer olduğu için devamı integer olarak algılanır.
// // number7 = "A" ; // hata veriyor çünkü "A" bir string veri türü, number7'yi biz başta int tanımladığımız için hata verir.


// //*** kendi merakım :
// // number7 = Convert.ToInt32("A"); 



