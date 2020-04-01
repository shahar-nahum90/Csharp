using System;

namespace lesson_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int Matrix;

            do
            {
                Console.WriteLine("Please enter the size of the matrix you want: ");
                Matrix = Convert.ToInt32(Console.ReadLine());
            } while (Matrix == 0);

            YourChoice(Matrix);
        }

        public static void YourChoice(int Y)
        {
            string[][] YourMatrix = new string[Y][];

            for (int row = 0; row < Y; row++)
            {
                YourMatrix[row] = new string[Y];
                for (int col = 0; col < Y; col++)

                {
                    if (Y % 2 != 0 && Y / 2 == row && Y / 2 == col)
                        YourMatrix[row][col] = "center ";
                    else if ((row < col && row + col != Y - 1))
                        YourMatrix[row][col] = "up";
                    else if (row > col && row + col != Y - 1)
                        YourMatrix[row][col] = "down";
                    else if (row == col)
                        YourMatrix[row][col] = "main";
                    else if (row + col == Y - 1)
                        YourMatrix[row][col] = "sub";
                }

            }


            foreach (string[] x in YourMatrix)
            {
                foreach (string z in x)
                {
                    Console.Write(z + " ");
                }
                Console.WriteLine();
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}

