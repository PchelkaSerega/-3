using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book("Достоевский", false);

            Console.WriteLine("Книга 1:");
            Console.WriteLine("Автор: " + book1.autor);
            Console.WriteLine("Название: " + book1.nameBook);
            Console.WriteLine("Количсетво страниц: " + book1.str);
            if (book1.kollek == true)
                Console.WriteLine("Коллекционное издание");
            else
                Console.WriteLine("Не коллекционное издание");
            Console.WriteLine();

            Console.WriteLine("Книга 2:");
            Console.WriteLine("Автор: " + book2.autor);
            Console.Write("Введите название книги: ");
            book2.nameBook = Console.ReadLine();
            Console.Write("Введите количсетво страниц: ");
            book2.str = int.Parse(Console.ReadLine());
            if (book2.kollek == true)
                Console.WriteLine("Коллекционное издание");
            else
                Console.WriteLine("Не коллекционное издание");
            Console.ReadKey();
        }
    }

    class Book
    {
        public string autor;
        public string nameBook;
        public int str;
        public bool kollek;
        public Book()
        {
            autor = "Есенин";
            nameBook = "Пугачёв";
            str = 1023;
            kollek = true;
        }
        public Book(string autor, bool kollek)
        {
            this.autor = autor;
            this.kollek = kollek;
        }
    }
}
