// See https://aka.ms/new-console-template for more information

// string city = "Ankara";
// Console.WriteLine( "[0] = " + city [0]) ; // OUTPUT  : A
// // Stringler Char'ın arrayidir.

// foreach (var item in city)
// {
//     Console.WriteLine(item); // OUTPUT  : Alt alta A n k a r a yazdırır.
// }

// string city2 ="İstanbul";
// string sum = city + city2;
// Console.WriteLine("Toplam  : " + sum); // OUTPUT  : Ankaraİstanbul  // string toplaması

// // Aslında sum değişkenine hiç gerek yok biz onun yerine şöyle yapabiliriz : 
// Console.WriteLine(String.Format("{0} {1}, city,city2"));

// String Metodları ile Çalışmak

string sentence = "My name is Fatma BULUT"; 
var result = sentence.Length;
var result2 = sentence.Clone();
 sentence = "My name is Başak BULUT"; // Clonladıktan sonra değer atasam o o ilk clonladığında kaldı.
var result3 = sentence.EndsWith("T"); // bu cümle "t" ile bitiyormu dedik. * sonuç bool değ ile döndürülür
var result4 = sentence.StartsWith("Myname"); //  Başlangıç deeğerini sorgular bir den ok karakter ends/start kullanılır.
var result5 = sentence.IndexOf("name"); // Yazdığımız değerin nerede olduğunu gösterir eğer bulamıyorsa -1 döndürür.
var result6 = sentence.IndexOf("a"); // Yazdığımız değerin ilk değerini verir 
var result7 = sentence.LastIndexOf("a"); // sondan aramaya başlar
var result8 = sentence.Insert(0,"Hello ! "); // Metine ekleme yapar.
var result9 = sentence.Substring(5); // Metini parçalar biz 5 ten itibaren al dedik.
var result10 = sentence.Substring(5,11); // Bu 5 ten itibaren 11 karakter al demek.
var result11 = sentence.ToLower(); // Tüm metini küçük harfe çevirir
var result12 = sentence.ToUpper(); // Tüm metini büyük harfe çevirir
var result13 = sentence.Replace(" ","-"); // Metin içerisindeki ifadeleri değiştirmeye yarar. " " boşlukları "-" ile değiştirdim.
var result14 = sentence.Remove(11,6); // Metinin girdiğimiz değerden sonrasını atmak için kullanılır 11 den donra 6 tane sil dedik.

Console.WriteLine(result);// OUTPUT : 22
Console.WriteLine(result2);// OUTPUT : "My name is Fatma BULUT"
Console.WriteLine(result3);// OUTPUT : True
Console.WriteLine(result4);// OUTPUT : False * Çünkü boşlukta bir karakterdir.
Console.WriteLine(result5);// OUTPUT : 3
Console.WriteLine(result6);// OUTPUT : 4
Console.WriteLine(result7);// OUTPUT : 14
Console.WriteLine(result8);// OUTPUT : Hello ! My name is Basak BULUT
Console.WriteLine(result9);// OUTPUT : me is Basak BULUT
Console.WriteLine(result10);// OUTPUT : me is Basak
Console.WriteLine(result11);// OUTPUT : my name is basak bulut
Console.WriteLine(result12);// OUTPUT : MY NAME IS BASAK BULUT
Console.WriteLine(result13);// OUTPUT : My-name-is-Basak-BULUT
Console.WriteLine(result14);// OUTPUT : My name is BULUT