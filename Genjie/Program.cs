using System;
using System.Collections.Generic;
using System.IO;

namespace Genjie
{
    class Program
    {
        static void Main(string[] args)
        {
            var glosor = File.ReadAllText(@"Glosor\Spanska 10 maj.txt");
            Console.WriteLine(glosor);

            var lines = glosor.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            var dict = new Dictionary<string, string>();

            foreach (var line in lines)
            {
                var splitline = line.Split('=');
                var svenska = splitline[0];
                var spanska = splitline[1];
            }

            Console.ReadLine();
        }
    }
}