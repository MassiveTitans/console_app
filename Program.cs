using book; 


namespace program
{
    class Program
    {
        static void Main()
        {
            Book kitob_ =new Book(12_000 ,  "Pro_book" , "Mike Tyson");

            // Object orqali propertylar yordamida fieldlarning qiymatini o'zgartirish
            kitob_.Name = "Yangi Nom";
            kitob_.Author = "Yangi Muallif";
            kitob_.Price = 75.0;
            

            // get data method

            kitob_.show_all_data();

            // Skidkani qo'llash
            myBook.ApplyDiscount(10.0);

            Console.ReadLine();


        }
    }
}
