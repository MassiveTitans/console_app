using book; 


namespace program
{
    class Program
    {
        static void Main()
        {
            Book kitob_ =new Book(12_000 ,  "Pro_book" , "Mike Tyson");

            // Object orqali propertylar yordamida fieldlarning qiymatini o'zgartirish
            kitob_.Kitob_nomi = "Yangi Nom";
            kitob_.Kitob_muallifi = "Yangi Muallif";
            kitob_.Kitob_narxi = 75.0;
            

            // get data method

            kitob_.show_all_data();

            // Skidkani qo'llash
            myBook.ApplyDiscount(10.0);

            Console.ReadLine();


        }
    }
}
