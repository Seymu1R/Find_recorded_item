using System;
using System.Collections.Generic;

namespace Find_record_return_exeption
{
    internal class Program
    {
        static void Main(string[] args)
        {
        up:
            try
            {
                Find();
            }
            catch (RecorExeption exception)
            {
                Console.WriteLine(exception.Message);
                goto up;
            }
        }
        private static void Find()
        {
            List<string> students = new List<string> { "Seymur", "Aysel", "Ismayıl", "Halil" };
            string input = Console.ReadLine();
            if (students.Contains(input))
            {
                Console.WriteLine("Record has been created");

            }
            else
            {
                throw new recordExeption("Record not found");
            }
        }
    }
}
