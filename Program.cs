using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarfNotu
{
    class Program
    {
        static void Main(string[] args)
        {
            int exam;
           
            Console.WriteLine("Notunuzu Giriniz");
            exam = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("Notunuz : {0}", Transcripts(exam));
            Console.ReadLine();
        }
        public static string Transcripts(int exam)
        {           
            if (exam <= 100 && exam >= 90)
            {                
                return "AA";
            }
            else if (exam <= 89 && exam >= 80)
            {
                return "AB";
            }
            else if (exam <= 79 && exam >= 70)
            {
                return "BB";
            }
            else if (exam <= 69 && exam >= 65)
            {
                return "BC";
            }
            else if (exam <= 64 && exam >= 60)
            {
                return "CC";
            }
            else if (exam <= 59 && exam >= 50)
            {
                return "DD";
            }
            else if (exam <= 49 && exam >= 30)
            {
                return "FD";
            }
            return "FF";
        
           
        }
    }
}
