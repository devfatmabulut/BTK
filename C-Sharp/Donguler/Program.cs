// Loops

// For Döngüsü

// 1 den 100 e kadar olan sayıları yazdır

// for (int i = 1; i < 101; i++)
// {
//     Console.Write("{0} - ",i);
// }
// Console.Write("FINISH");
// Console.WriteLine();

// // 1 den 100e kadar olan TEK sayıları yazdır
// Console.WriteLine("Tek sayılar : ");
// for (int i = 1; i < 101; i+= 2)
// {
//     Console.Write("{0} - ",i);
// }
// Console.Write("FINISH");
// Console.WriteLine();

// // 1 den 100e kadar olan Çift sayıları yazdır
// Console.WriteLine("Çift sayılar : ");
// for (int i = 2; i < 101; i+= 2)
// {
//     Console.Write("{0} - ",i);
// }
// Console.Write("FINISH");
// Console.WriteLine();

// // 1 den 100e kadar olan Çift sayıları  büyükten küçüğe yazdır
// Console.WriteLine("Büyükten Küçüğe Çift sayılar : ");
// for (int i = 100 ; i >= 2 ; i-= 2)
// {
//     Console.Write("{0} - ",i);
// }
// Console.Write("FINISH");

// While Döngüsü
// var number =100;
// while (number >= 0)
// {
//     Console.WriteLine(number);
//     number --; // döngüyü sonsuz döngüden çıkarmış olduk
// }

// // Do While Döngüsü
// // whiledan önce do olduğu içiçn şarttan önce mutlaka do içine yazdığımız koşulu çalıştıracaktır.
// int number =10;
// do
// {
//     Console.WriteLine(number);
//     number--;
// } while ( number>=0);

// For Each Döngüsü (iterate -> dolaşılma)
// genellikle dizilerde kullanılır.
// genellikle veri tabanı için kullanılır.
 string[] names =new string [4]{"Basak","Metehan","sema","metin"};
 foreach (var name in names)
 {
  //  name="Oğulcan"; // foreach içinde atama yapılmaz
    Console.WriteLine(name);
 }