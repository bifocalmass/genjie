using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Genjie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var path = Path.Combine("Glosor", "Spanska 10 maj.txt");
            var glosor = File.ReadAllText(path);

            //Console.WriteLine(glosor);

            var lines = glosor.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            var dict = new Dictionary<string, string>();

            foreach (var line in lines)
            {
                var splitline = line.Split('=');
                var svenska = splitline[0].Trim();
                var spanska = splitline[1].Trim();

                dict.Add(svenska, spanska);
            }

            var rnd = new Random();


            while (true)
            {
                var question = dict.Keys.ToArray()[rnd.Next(dict.Count)];
                var correctAnswer = dict[question];

                Console.WriteLine(question);
                var answer = Console.ReadLine();

                if (correctAnswer.ToLower() == answer.ToLower())
                {
                    Console.WriteLine("Rätt");
                }
                else
                {
                    Console.Write("Fel, rätt svar är:");
                    Console.WriteLine(correctAnswer);
                }

                Console.WriteLine();
            }



            Console.ReadLine();

        }
    }
}