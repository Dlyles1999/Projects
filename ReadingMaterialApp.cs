/* Programmer: Daniel Lyles
 * Date: 4/3/19
 * Purpose: Create a base class, Subclasses, and a Interface
 */

using static System.Console;
namespace ConsoleApplication41
{
    class Program
    {
        static void Main()
        {
            TestBook();
            TestMagazine();
            ReadKey();           

        }
        static void TestMagazine()
        {
            Magazine myMagazine = new Magazine("Tom", "Jones", 89, 2018, "Hot Topic", "655783838");

            WriteLine("\n\n\nAuthor Name: {0} {1}", myMagazine.AuthorFirstName, myMagazine.AuthorLastName);
            WriteLine("The Headline Of the Magazine: {0}", myMagazine.CoverTitlePage);
            WriteLine("Page Number: {0}", myMagazine.PageNumber);
            WriteLine(myMagazine.getAvailable());
        }
       static void TestBook()
        {
            Book myBook = new Book("Daniel", "Lyles", 104, 2014, "456432335", "The Big White Whale");


            WriteLine("Author Name: {0} {1}", myBook.AuthorFirstName, myBook.AuthorLastName);
            WriteLine($"The Title Of The Book: {myBook.BookTitle}");
            WriteLine("Page Number: {0}", myBook.PageNumber);
            WriteLine(myBook.getAvailable());
        }
    }
}
