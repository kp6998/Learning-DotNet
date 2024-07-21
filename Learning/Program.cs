using Learning;
using Learning.DTO;

// Generics
Console.WriteLine("\n...Generics...");
var generics = new Generics();
Console.WriteLine(generics.TestCall(1));
Console.WriteLine(generics.TestCall(2, 3));

//Delegates
Console.WriteLine("\n...Delegates...");
var delegates = new Delegates();
var dObj = new Obj();
Delegates.DelegateFunc delegateFunc = dObj.func1;
delegateFunc += dObj.func2;
delegateFunc += func3;
delegates.Test(1, delegateFunc);
Func<string, string> delegateFuncStr = dObj.funcStr;
delegateFuncStr += funcStr1;
delegates.Test2("Test", delegateFuncStr);
Action<int> delegateAction = dObj.func1;
delegateAction += dObj.func2;
delegateAction += func3;
delegates.TestGenerics(4, delegateAction);

static void func3(int a)
{
    Console.WriteLine("func3-" + a);
}
static string funcStr1(string str)
{
    Console.WriteLine("call 2");
    return str + "1";
}

//LambdaExpressions
Console.WriteLine("\n...LambdaExpressions...");
const int factor = 5;
Func<int, int> multiply = num => num * factor;
Console.WriteLine(multiply(5));

var books = GetBooks();
var cheapBooks = books.FindAll(book => book.Price <= 20);
var selBook = books.FirstOrDefault(book => book.Price == 30).Id;
foreach (var book in cheapBooks)
{
    Console.WriteLine(book.Title);
}
Console.WriteLine(selBook);
Func<int> check = () => 1;
Console.WriteLine(check());

Action<int> check2 = x => Console.WriteLine(x);
check2(2);

Action check3 = () => Console.WriteLine("test3");
check3();

List<Book> GetBooks()
{
    return new List<Book>
    {
        new Book() {Id = 1, Title = "one", Price = 10},
        new Book() {Id = 2, Title = "two", Price = 20},
        new Book() {Id = 3, Title = "three", Price = 30}
    };
}

// Events
Console.WriteLine("\n...Events...");
var video = new Video() { title = "Video 1" };
var videoEncoder = new VideoEncoder();
var mailService = new MailService();
var messageService = new MessageService();

videoEncoder.VideoEncoded += mailService.OnVideoEncode;
videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

videoEncoder.Encode(video);

// Extension method
Console.WriteLine("\n...Extension method...");
string text = "Hello";
var textLength = text.GetLetterCount();
Console.WriteLine($"text length is - {textLength}");
var shortenText = text.ShortenText(2);
Console.WriteLine($"text length is - {shortenText}");

// LINQ
Console.WriteLine("\n...LINQ...");
var booksList = GetBooks();
    // Extension method
var cheapBooksList = booksList
    .Where(x => x.Price <= 30)
    .OrderByDescending(x => x.Title)
    .Select(x => x.Title);

    // Query operator
var cheapBooksList2 = from b in booksList
                      where b.Price <= 20
                      orderby b.Title descending
                      select b;

cheapBooksList.ToList()
    //.ForEach(x => Console.WriteLine($"{x.Title} - {x.Price}"));
    .ForEach(x => Console.WriteLine(x));
cheapBooksList2.ToList()
    .ForEach(x => Console.WriteLine($"{x.Title} - {x.Price}"));
    //.ForEach(x => Console.WriteLine(x));

var skipTake = books.Skip(2).Take(3);
skipTake.ToList()
    .ForEach(x => Console.WriteLine(x.Title));

var maxPrice = books.Max(x => x.Price);
var minPrice = books.Min(x => x.Price);
var totalPrice = books.Sum(x => x.Price);
var averagePrice = books.Average(x => x.Price);
Console.WriteLine(maxPrice);
Console.WriteLine(minPrice);
Console.WriteLine(totalPrice);
Console.WriteLine(averagePrice);

//Nullable types
Console.WriteLine("\n...Nullable types...");
DateTime? date = null;
//date = new DateTime(2015, 1, 1);
DateTime date2 = date.GetValueOrDefault();
DateTime date3 = date ?? DateTime.Today;

Console.WriteLine("date? = " + date);
Console.WriteLine(date2);
Console.WriteLine(date3);
Console.WriteLine(date.HasValue);
if (date.HasValue)
    Console.WriteLine(date.Value);

// Dynamic
Console.WriteLine("\n...Dynamic...");
dynamic d1 = 10;
d1 = "xyz";
dynamic d2 = "abc";
d2 = 20;
var v1 = d1 + d2;
v1 = 'a';
var v2 = "1";
v2 = 2.ToString();
Console.WriteLine(v1 + " " + v2);

// Exception handling
Console.WriteLine("\n...Exception handling...");
StreamReader streamReader;
try
{
    //throw new SystemException("Test ex");
    //var num = Divide(1, 0);
    streamReader = new StreamReader(@"c:\file.zip");
    var content = streamReader.ReadToEnd();

}
catch (DivideByZeroException ex)
{
    Console.WriteLine("DivideByZeroException");
}
catch (ArithmeticException ex)
{
    Console.WriteLine("ArithmeticException");
}
catch (FileNotFoundException ex)
{
    //throw;
    Console.WriteLine("FileNotFoundException");
}
catch (SystemException ex)
{
    Console.WriteLine("SystemException");
}
catch (Exception ex)
{
    Console.WriteLine("Exception");
}
finally
{

}
int Divide(int a, int b)
{
    return a / b;
}

public class CustomException : Exception
{

}
