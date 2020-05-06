using System;

namespace Lesson_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Cookie c1 = new Cookie();

            c1.Gloten = false;
            c1.NumOfSuger = 1.5f;
            c1.NumOfEggs = 3;
            c1.Amountflour = 3.7f;

            Cookie c2 = new Cookie();

            c2.Gloten = true;
            c2.NumOfSuger = 3.2f;
            c2.NumOfEggs = 5;
            c2.Amountflour = 4.2f;

            Cookie c3 = new Cookie();

            c1.NumOfSuger = 2.5f;

            c2 = c1;

            c2.NumOfEggs = 7;

            Console.WriteLine(printDetails(c2));
            Console.WriteLine(printDetails(c1));
            
            // נתוני העוגיה הראשונה זהים לעוגיה השניה מכוון שאנחנו משווים מצביעים ולא מעבירים את התוכן עצמו של המשתנה 
           
            Console.ReadKey();
        }

        public static string printDetails(Cookie c)
        {
            string res = "Details of cookie: ";
            res += $"Gloten: {c.Gloten}\n";
            res += $"NumOfEggs: {c.NumOfEggs}\n";
            res += $"NumOfSuger: {c.NumOfSuger}\n";
            res += $"Amountflour: {c.Amountflour}\n";

            return res;
        }

    }
}
