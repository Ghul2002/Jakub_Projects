using System;

namespace Trójkąt_Pascala
{
    class Program
    {
        static void piramida(double rows)
        {
            int columns = 1;
            int spaces = Convert.ToInt32(rows);
            int index = 0;
            int column_ctrl = 0;
            int row_ctrl = 0;
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < columns; j++)
                {
                    int fact_row = 1;
                    for (int l = 1; l <= row_ctrl; l++)
                    {
                        fact_row = fact_row * l;
                    }
                    int fact_column = 1;
                    for (int l = 1; l <= column_ctrl; l++)
                    {
                        fact_column = fact_column * l;
                    }
                    int fact_mianownik = 1;
                    for (int l = 1; l <= row_ctrl - column_ctrl; l++)
                    {
                        fact_mianownik = fact_mianownik * l;
                    }
                    index = fact_row / (fact_column * fact_mianownik);
                    if (index > 9)
                    {
                        Console.Write(index + "  ");
                    }
                    else
                        Console.Write(index + "   ");
                    index++;
                    column_ctrl++;
                }
                Console.WriteLine();
                row_ctrl++;
                columns = columns + 1;
                spaces--;
                column_ctrl = 0;
            }
        }
        static void Main(string[] args)
        {
            double rows;
            Console.WriteLine("Podaj ilość rzędów:");
            rows = Convert.ToInt32(Console.ReadLine()) - 1;
            while (rows < 0)
            {
                if (rows < 0)
                {
                    Console.WriteLine("Podaj dodatnią wartość");
                    rows = Convert.ToInt32(Console.ReadLine()) - 1;
                }
            }
            piramida(rows);
        }
    }
}
