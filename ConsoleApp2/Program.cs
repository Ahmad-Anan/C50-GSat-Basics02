// C# Assignment - Book

#region Question 1
// object can hold anything because every class comes from object
object book = new Book { Title = "Clean Code", Pages = 464 };
Console.WriteLine(book); // prints Book (the class name) not the title
#endregion

#region Question 2
Console.WriteLine(book.ToString());    // Book
Console.WriteLine(book.Equals(book));  // True because it is the same book
Console.WriteLine(book.GetHashCode()); // some number, changes every run
Console.WriteLine(book.GetType());     // Book
#endregion

#region Question 3
// int pages = "464";
// compile time error, "464" is a string and pages is int
// fix: remove the quotes
int pages = 464;
Console.WriteLine(pages);
#endregion

#region Question 4
// if i write 10 / 0 directly it gives compile error
// so i put them in variables to get the exception at runtime
int num1 = 10;
int num2 = 0;

try
{
    int result = num1 / num2;
    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero");
}
finally
{
    // finally runs always
    Console.WriteLine("Done");
}
#endregion

#region Question 5
// implicit conversion, int fits in double so no cast needed
int pageCount = 300;
double pagesDouble = pageCount;
Console.WriteLine(pagesDouble);
#endregion

#region Question 6
// explicit conversion (cast), the .99 is removed not rounded
double price = 49.99;
int priceInt = (int)price;
Console.WriteLine(priceInt); // 49
#endregion

#region Question 7
string pagesText = "464";
int pagesNumber = Convert.ToInt32(pagesText);
Console.WriteLine(pagesNumber);
#endregion

#region Question 8
string yearText = "2023";
int year = int.Parse(yearText);
Console.WriteLine(year);

// Parse will crash with "abc" so i use TryParse
string badText = "abc";
if (int.TryParse(badText, out int badNumber))
{
    Console.WriteLine(badNumber);
}
else
{
    Console.WriteLine("Invalid number");
}
#endregion

#region Question 9
// pages is already 464 from question 3
string pagesString = pages.ToString();
Console.WriteLine(pagesString);
Console.WriteLine(pagesString.GetType()); // System.String
#endregion

#region Question 10
int copies = 100;
object boxed = copies;     // boxing
int unboxed = (int)boxed;  // unboxing
Console.WriteLine(boxed);
Console.WriteLine(unboxed);
#endregion


// the class must be after the code (top level statements)
class Book
{
    public string Title { get; set; }
    public int Pages { get; set; }
}