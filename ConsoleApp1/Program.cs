
using System;
using System.IO;
class Program

{
    static void Main()
    {
        int N = 0;

        try
        {
            string input = File.ReadAllText("C:\\Users\\prdb\\source\\repos\\ConsoleApp1\\INPUT.txt").Trim();

            if (string.IsNullOrEmpty(input))
            {
                throw new FormatException("Файл INPUT.TXT пустой.");
            }

            N = int.Parse(input);

            if (N <= 0 || N > 100)
            {
                throw new FormatException("Размер матрицы должен быть натуральным числом от 1 до 100.");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Ошибка формата ввода: " + ex.Message);
            return;
        }
        catch (IOException ex)
        {
            Console.WriteLine("Ошибка чтения файла: " + ex.Message);
            return;
        }


        int[,] matrix = new int[N, N];
        int num = 1;

        for (int i = 0; i < N; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = num++;
                }
                Console.WriteLine("   ");
            }
            else
            {
                for (int j = N - 1; j >= 0; j--)
                {
                    matrix[i, j] = num++;
                    Console.WriteLine("   ");
                }
                Console.WriteLine("   ");
            }
        }

            using (StreamWriter writer = new StreamWriter("C:\\Users\\prdb\\source\\repos\\ConsoleApp1\\OUTPUT.txt"))
            {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    writer.Write(matrix[i, j] + "    "); 
                }
                writer.WriteLine();
            }
            }
        }
    }



