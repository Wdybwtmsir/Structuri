using System;
using System.Collections.Generic;

public class Book
{
    public string Author { get; set; }
    public string Genre { get; set; }
    public string Title { get; set; }
    public int Copies { get; set; }

    public Book(string author, string genre, string title, int copies)
    {
        Author = author;
        Genre = genre;
        Title = title;
        Copies = copies;
    }
}

class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>
        {
            new Book("Андрей Валентинович", "Хоррор", "Потасовка в КБК", 5000),
            new Book("Голубчиков Вова", "Фантастика", "Я пришел на пары", 15000),
            new Book("Обкакай Богбан", "Фантастика", "Я пришел на пару и не свалил", 8000)
        };

        Console.WriteLine("Книги с тиражом не более 10000 экземпляров:");

        foreach (var book in books)
        {
            if (book.Copies <= 10000)
            {
                Console.WriteLine($"Автор: {book.Author}, Жанр: {book.Genre}, Название: {book.Title}, Тираж: {book.Copies}");
            }
        }
    }
}