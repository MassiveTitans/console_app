
namespace book
{
    class Book
    {
            private double price;
            private string book_name ;
            private string book_author;


            public double Kitob_narxi {
                get
                {
                    return price;
                } 
                set
                {
                    price = value;

                }}

            public string Kitob_nomi {
                get
                {
                    return book_name;
                } 
                set
                {
                    book_name = value;
                }}

            public string Kitob_muallifi {
                get{
                    return book_author ;
                } 
                set
                {
                    book_author = value;
                }}



             public Book(int narx  , string nomi , string muallif)
            {
                Kitob_muallifi = muallif;
                Kitob_narxi = narx;
                Kitob_nomi = nomi;

            }

            public void show_all_data(){
                Console.WriteLine($"Kitob muallifi: {Kitob_muallifi} \nKitob nomi: {Kitob_nomi} \nKitob narxi: {Kitob_narxi}");
            }

            public void ApplyDiscount(double discountPercentage)
            {
                if (discountPercentage < 0 || discountPercentage > 100)
                {
                    Console.WriteLine("Xato: Skidkani to'g'ri kiriting!");
                    return;
                }

            double discount = price * (discountPercentage / 100);
            Kitob_narxi -= discount;

            Console.WriteLine($"Skidka qo'llandi! Yangi narx: {price}");
        }

    }
}
