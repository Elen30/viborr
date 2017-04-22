using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сортировка_выбором1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            int len = 9;                                    //length of array
            int[] Mas = new int[len];
            Mas[0] = 3;                                     //array
            Mas[1] = 2;
            Mas[2] = 4;
            Mas[3] = 1;
            Mas[4] = 7;
            Mas[5] = 9;
            Mas[6] = 8;
            Mas[7] = 6;
            Mas[8] = 5;
            Сортировка_выбором1.Program j = new Сортировка_выбором1.Program();
            Mas = j.v(Mas, len);
            for (i = 0; i < len; i++)                       //output array to console
            {
                Console.Write(Mas[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public int[] v(int[] a, int size)              //sorting method
        {
            int temp;
            for (int i = 0; i < size; i++)
            {
                // Найдем минимальный элемент на
                // промежутке индексов [i; size);
                // изначально его индекс равен i
                int minValueIndex = i;

                // Переберем оставшиеся элементы промежутка
                for (int j = i + 1; j < size; j++)
                {
                    // Если элемент в позиции j меньше
                    // элемента в позиции minValueIndex, то
                    // необходимо обновить значение индекса
                    if (a[j] < a[minValueIndex])
                    {
                        minValueIndex = j;
                    }
                }

                int prev = a[i];
                int next;
                for (int m = i; m < minValueIndex ; ++m)
                {
                    next = a[m + 1];
                    a[m + 1] = prev;
                    prev = next;
                }
                a[i] = prev;


                // Меняем текущий элемент с минимальным
                //temp = a[i];
                //a[i] = a[minValueIndex];
                //a[minValueIndex] = temp;
            }

            return a;                                     //result
            throw new NotImplementedException();
        }

    }
}
