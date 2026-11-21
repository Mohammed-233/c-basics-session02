using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object.Print it.
            //Book b1 = new Book();
            //object b2 = new object();
            //b1.title = "Almoshtak";
            //b1.pages = 300;
            //b2 = b1;
            //Console.WriteLine(b2.ToString());
            #endregion
            #region MyRegion Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.
            //Book b1 = new Book();
            //b1.title = "almoshtak";
            //b1.pages = 300;
            //Book b2 = new Book();
            //b2.title = "almoshtak";
            //b2.pages = 300;
            //Console.WriteLine(b1.ToString());
            //Console.WriteLine(b2.ToString());
            //Console.WriteLine(b1.Equals(b1));
            //Console.WriteLine(b1.Equals(b2));
            //Console.WriteLine(b1.GetHashCode());
            //Console.WriteLine(b1.GetType());
            #endregion
            #region Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";
            //syntax error because we cannot put string in integer variable so the fix is
            //int pages = 464;  
            //or using casting by parse
            //int pages = int.Parse("464");

            #endregion
            #region Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot 
            //    int x = 10;
            //    int y = 0;
            //try 
            //{
            //    Console.WriteLine(x/y);
            //}

            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}

            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion
            #region Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double pages2 = pages;
            #endregion
            #region Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //int price2 = (int)price;
            #endregion
            #region Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagesText = "464";
            //int page3=Convert.ToInt32(pagesText);
            #endregion
            #region  Given string yearText = "2023";, convert it using int.Parse(). Then given string badText ="abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            //string yeartext = "2023";
            //    int year= int.Parse(yeartext);
            //string bad_text = "abc";
            //if (int.TryParse(bad_text, out int result))
            //{
            //    Console.WriteLine(result);
            //}
            //else {
            //    Console.WriteLine("invalid number");
            //}
            #endregion
            #region Q09.  Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()to prove it's now a string
            //int pages = 464;
            //string pagesString = pages.ToString();
            //Console.WriteLine($"Type of pagesString: {pagesString.GetType()}");
            #endregion
            #region  Declare int copies = 100;. Box it into an object variable, then unbox it back into a new intvariable, and print both
            //int copies = 100;
            //object obj = copies;
            //int unboxedCopies = (int)obj;

            //Console.WriteLine($"Original: {obj}, Unboxed: {unboxedCopies}");
            #endregion
            #region Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print itsvalue.
            //int? year = null;
            //Console.WriteLine($"Year has value: {year.HasValue}");
            //year = 2023;
            //Console.WriteLine($"Year value: {year.Value}");
            #endregion
            #region Declare a string? reviewer = null;. Print whether it is null.
            //string? reviewer = null;
            //Console.WriteLine(reviewer is null);
            #endregion
            #region Declare a Book? book = null;. Use ?. to safely read book.Title without crashing t program, and print the result.
            //Book? book = null;
            //Console.WriteLine(book?.title);
            #endregion
            #region Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??= to assign title the value "Untitled" only if it's still null.
            // Book? book = null;
            // string? title = book?.title;
            // Console.WriteLine(title ?? "Untitled");
            //title ??= "Untitled";
            // Console.WriteLine(title);
            #endregion
            #region Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullablestring confirmedName using the ! operator.
            //string? name = "Ahmed";
            //string confirmedName = name!;
            #endregion




        }
    }
    }
