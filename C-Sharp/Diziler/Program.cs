// Arrays

// string stu1 ="Engin";
// string stu2 ="Derin";
// string stu3 ="Oğulcan";
// string stu4 ="Fatma"; 

// Diziye alalım bunu :
// string[] students = new string[4];
// students[0]="Engin";
// students[1] ="Derin";
// students[2] ="Oğulcan";
// students[3] ="Fatma"; 

// foreach (var student in students)
// {
//     Console.WriteLine(student);
// }

// Başka bir tanımlama yöntemi : 
// string[] students2 = {"Engin","Derin","Oğulcan","Fatma","Başak"};
// string[] students2 = new [] {"Engin","Derin","Oğulcan","Fatma","Başak"};
// foreach (var student in students2)
// {
//     Console.WriteLine(student);
// }

// Array ile ilgili kısıtlar. tanımlanan türde değer ister sen string tanımlanan diziye nteger yazamazsın.
// arrayleri daha çok database işlemlerinde kullanızrız.
// diziye tanımladığın eleman sayısıdan fazlasını yazmazsın. Kaç verdiysen o kaddar veri tutar.

//  Çok Boyutlu Diziler
//  tanmlarken kullandığımız [] -> tek boyutlu dizi demek
// [,] -> 2 boyutlu oldu.

// Türkiyenin Bölgeleri ve Bölgelerde Bilinen 3 Şehir
string[,] regions = new string[7,3] // 7 satır 3 stun demek bu 
{
    {"istanbul","İzmit","Edirne"},
    {"Ankara","Konya","Aksaray"},
    {"Antalya","Mersin","Adana"},
    {"Giresun","Trabzon","Rize"},
    {"İzmir","Muğla","Manisa"},
    {"Diyarbakır","Batman"," Şırnak"},
    {"Kars","Ağrı","Malatya"}
};

// dizi indexi = [{0},{1},{2}] -> 3 boyutlu dizi bu bizim ki 2 boyutlu bu yüzden [{0},{1}]
for (int i = 0; i <= regions.GetUpperBound(0); i++) // satırları gezdim şuan (0) dizi indexi 
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++) // sütunları gezdim (1) dizi indexi
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("***");
}
