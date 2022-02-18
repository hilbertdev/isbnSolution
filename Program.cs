using helperClass;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "817450494X";
            if (input.Length == 10)
            {
                ISBN10 isbn10 = new ISBN10(input, input.Length);
                if (isbn10.IsValidInput)
                {
                    Console.WriteLine(isbn10.IsISBNtenValid());
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            else if (input.Length == 13)
            {
                ISBN13 isbn13 = new ISBN13(input,input.Length);
                if (isbn13.IsValidInput)
                {
                    Console.WriteLine(isbn13.isISBNThirteenValid());
                }
                else
                {
                    Console.WriteLine("Invalid");
                }

            }
        }
    }
}