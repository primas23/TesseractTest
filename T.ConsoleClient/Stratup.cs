using System;
using System.Text;
using Т.Core;

namespace T.ConsoleClient
{
    public class Stratup
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var image1 = @"C:\Users\Primas\Pictures\Saved Pictures\1.jpeg";
            var image2 = @"C:\Users\Primas\Pictures\Saved Pictures\2.png";
            var image3 = @"C:\Users\Primas\Pictures\Saved Pictures\3.png";

            Console.WriteLine(new TextExtractorcs().ReadBg(image2));
        }
    }
}
