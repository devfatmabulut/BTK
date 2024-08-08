// Metotlar 

// // Add();
// // Add();
// // Add();
// // Add();
// // Add();
// // Add();
// // Add2(2,20); // output görünmez çünkü sadece işlem yaptım bu işlemei yazdırmadım.
// // var result = Add2(2,20); // İnt de diyebilirdim bir sorun olmazdı.
// // Console.WriteLine(result);  // OUTPUT : 22

// int number1 = 200;
// int number2 = 10;
// //var result2 = Add3(number1,number2);
// // var result2 = Add3(number1,number2);
// // Console.WriteLine(result2);  // OUTPUT : 40
// Console.WriteLine(result2);  // OUTPUT : 40
// Console.WriteLine(number1);  // OUTPUT : 200 -> Değer tiple çalışıyoruz bu yüzden  yukarıda 200 atasam bile bu değeri add3 de tekrar tanımladığım için add3 içindeki geçerli olacak.
// // eğerki number1 değerinin değişip add3 deki değer ile aynı olmasını istiyorsam metod tanımlamadaki number1 başına ref int eklemeliyim.
// // Aynı şekilde çağırırkende ref number1 olarak çağırmalıyım.

// var result2 = Add3(ref number1,number2);
// Console.WriteLine(number1);  // OUTPUT : 30 -> number1 Add3 metodundaki tanımlanan değeri ref keywordu sayesinde almış oldu. 

Console.WriteLine(Multiply(2,4)); // OUTPUT : 8
Console.WriteLine(Multiply(2,4,3)); // OUTPUT : 24
Console.WriteLine(Add4(1,2,3,4,5,6)); // OUTPUT : 21



// static void Add()
// {
//     Console.WriteLine("Added !!");
// }

// // Parametreli Metodlarla Çalışmak
// // void -> git şunu yap demek  bu yüzden burada void yerine int yazıyoruz
// static int Add2(int number1 , int number2)
// {
//     var result =number1+number2;
//     return result ;
// }

// // Challange Ref Keyword ile Çalışmak

// //static int Add3(int number1, int number2)
// static int Add3(ref int number1, int number2)
// {
//     number1 = 30;
//     return number1 + number2 ;
// }

// // Out Keyword ile Çalışmak
// // REFİN ALTERNATİFİDİR MANTIK OLARAK AYNIDIR.
// // FARKI -> REF Keywordünde number1 değişkenine mutlaka bir değer tanımlamış olmak gerekir anacak outta böyle bir zorunluluk yok.
// // Yukarıda tanımlamak gerekli 
// // eğer outta number1 değişkenine metod dışında değer atarsan bunu metod içinde de atamalısın. Bu durumda da metod dışında set etmek mantıksız
// // metod içerisinde stele geç.

// Metod Overloading

static int Multiply(int number1, int number2)
{
    return number1 * number2 ;
}

// diyelimki bizim bazende 3 değeri çarpmamız lazım o zaman : 
// aynı isimde olmasına rağmen sıkıntı yok buna metot overload diyoruz.
static int Multiply(int number1, int number2, int number3)
{
    return number1 * number2 * number3 ;
}

// Challenge Params Keyword İle Çalışmak
// diyelim ki 3-4 tane olup over load ile yazamayağımız kadar değer varsa ne yağacağız:
static int Add4(params int[] numbers) // params ile dizi tanımlayacağız.
{
    return numbers.Sum();
}
// Metod da params'ı şu şekilde kullana biliriz : 
// ancak o zaman bu metoddun sonucu 20 çıkar çünkü yukarıda tanımladığımız Console.WriteLine(Add4(1,2,3,4,5,6)); daki 1 = number1 olur
// ee biz metodda number1 i hiç kullanmadığımız için doğal olarak yanıt 20 olarak değişir.

static int Add4(int number1,params int[] numbers) 
{
    return numbers.Sum();
}

// params keywordundan sonra asla başka değer ataması yapılmaz hata alır. Çalışmaz PARAMS SON ATAMA OLMAK ZORUNDA!