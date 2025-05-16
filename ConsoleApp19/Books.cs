using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Books
    {
        protected List<String> BookNames = new List<String>();
        // делегат
        public delegate void BookHandler(String text);
        // событие
        public event BookHandler onAddBook;
        public event BookHandler onDeleteBook;
        // метод 'Добавление книги'
        public void AddBook(String bookName)
        {
            BookNames.Add(bookName);
            // вызываем событие
            if (onAddBook != null)
                onAddBook("Книга " + bookName + " добавлена");
        }
        // метод 'Удаление книги'
        public void DeleteBook(String bookName)
        {
            BookNames.Add(bookName);
            // вызываем событие
            if (onDeleteBook != null)
                onDeleteBook("Книга " + bookName + " УДАЛЕНА!");
        }
    }
}

