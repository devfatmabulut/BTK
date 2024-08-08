// // Conditionals

 var number = 11;
// if (number == 10)
// {
//  Console.WriteLine("Number is 10");
// }
// else
// {
//     Console.WriteLine("Number is not 10");
// }

// // NOT : eklenti reSharper

// // Single Line İf ile Çalışmak
// // Yukarıdaki if bloğunun tek satır yazılmış hali :
// Console.WriteLine(number == 10 ? "* Number is 10" : " *Number is not 10");

// // Else if Bloğuyla Çalışmak

// if (number == 10)
// {
//  Console.WriteLine("Number is 10");
// }
// else if (number == 20)
// {
//     Console.WriteLine("Number is 20");
// }
// else
// {
//     Console.WriteLine("Number is not 10 or 20");
// }

// Switch Bloğuyla Çalşmak
// switch (number)
// {
//     case 10 :
//     Console.WriteLine("Number is 10");
//     break;

//     case 20 :
//     Console.WriteLine("Number is 20");
//     break;
   
//     default:
//     Console.WriteLine("Number is not 10 or 20");
//     break;
// }

// DEMO ÇOKLU ŞARTLARLA ÇALIŞMAK

// if (number >= && number <= 100)
// {
//     Console.WriteLine("Number is between 0 - 100");
// }
// else if (number > 100 && number <= 200)
// {
//     Console.WriteLine("Number is between 101 - 200");
// }
// else if (number > 200 || number < 0 )
// {
//     Console.WriteLine("Number is less than 0 or greater 200");
// }

// İç İçe if Bloklarıyla Çalışmak (Nested İf)

if (number < 100)
{
    if (number <= 90 && number >10)
    {
        Console.WriteLine(number);
    }
    
}
else
{
    Console.WriteLine("Number is greather 100 ");
}