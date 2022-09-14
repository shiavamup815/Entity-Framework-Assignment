using HandsonEFCodeFirstBook.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HandsonEFCodeFirstBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookRepository bookRepository = new BookRepository();
            OrderRepository orderRepository = new OrderRepository();
            do
            {
                Console.WriteLine("1.AddBook\n2.GetBook\n3.GetBookByID\n4.DeleteBook" +
                    "\n5.EditBook\n6.AddOrder");
                Console.WriteLine("Enter your choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Book book = new Book() { BookId = "P010", BookName = "Eng.Draw", Price = 1000, Author = "Wong" };
                            bookRepository.AddBook(book);
                        }
                        break;
                    case 2:
                        {
                            List<Book> book = bookRepository.GetAllBooks();
                            foreach (var book in Book)
                                Console.WriteLine($"ID:{employee.EmployeeId} Name:{employee.EmployeeName} Salary:{employee.Salary} Project:{employee.ProjectId}");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter BookId");
                            int id = int.Parse(Console.ReadLine());
                            Book book = BookRepository.GetBook(id);
                            Console.WriteLine($"ID:{book.BookId} Name:{book.BookName} Price:{book.Price} Order:{book.OrderId}");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter BookId");
                            int id = int.Parse(Console.ReadLine());
                            BookRepository.DeleteBook(id);
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter BookId");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Price");
                            double Price = double.Parse(Console.ReadLine());
                            BookRepository.EditBook(id, Price);
                        }
                        break;
                    case 6:
                        {
                            Order order = new Order();
                            Console.WriteLine("Enter EmployeeName");
                            employee.EmployeeName = Console.ReadLine();
                            employee.ProjectId = "P0001";
                            employee.Salary = 34000;
                            employeeRepository.AddEmployee(employee);
                        }
                        break;

                }
            } while (true);
        }
    }
    
}
