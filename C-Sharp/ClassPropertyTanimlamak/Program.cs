
class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();
        customer.FirstName = "Basak";   // set bloğu çalışır.
        customer.LastName = "BULUT";    // set bloğu çalışır.
        customer.City = "Ankara";       // set bloğu çalışır.
        customer.Id = 1905;             // set bloğu çalışır.

        Customer customer1 = new Customer { FirstName = "Fatma", LastName = "BULUT", City = "Ankara", Id = 1906 }; // set bloğu çalışır.

        Console.WriteLine(customer.FirstName); // get bloğu çalışır
    }


    // class Customer  // 
    // {
    //     // public string FirstName;  // field

    //     // Properties-------------------------------------------------------------------------------
    //         public int Id { get; set; }
    //          public string FirstName { get; set; }
    //         public string LastName { get; set; }
    //         public string City { get; set; }

    // }

    // Encapsulation
    /*
    *Örneğin; kullanıcı FirstName set etti ve değerin başına mr/mrs ekledi.
        Set ederken sorun yaşamız ancak Get ederken işler değişir. 
        Biz bu durumda sorun yaşamamak için public string FirstName { get; set; } kodundaki ";" sileriz ve onun yerine parantez açarız.
    */



    class Customer  // PASCAL KEY örnekleri ise camel key 
    {
        public int Id { get; set; }
        // Buraya bir field tanımlarız;
        string _firstName;
        public string FirstName
        {
            get { return "Mrs."+ _firstName; }
            set { _firstName = value; }
        }  // **Console.WriteLine(customer.FirstName); output : Mrs.Basak -> tabi bu kod Main Fonksiyonunda olmalı
        public string LastName { get; set; }
        public string City { get; set; }

    }
}

