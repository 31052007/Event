using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем объект книг
            Books books = new Books();

            // подписка на события
            books.onAddBook += ShowMessage;
            books.onDeleteBook += ShowMessage;

            // добавление книг
            books.AddBook("Властелин колец");
            books.AddBook("Звездные воины");

            // удаление книги
            books.DeleteBook("Звездные воины");
            books.DeleteBook("Не существующая книга"); // Это для теста, чтобы показать, если книга не найдена
            Console.ReadKey();
        }

        // обработчик событий
        public static void ShowMessage(string text)
        {
            Console.WriteLine(text);
        }
    }
}
