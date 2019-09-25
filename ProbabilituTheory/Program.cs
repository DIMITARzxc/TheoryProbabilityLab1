using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilituTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleMean sample = new SampleMean();
            
            
            int n;
            Console.WriteLine("Введите длинну выборки");
            n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Заполните выборку элементом под индексом:{i}");
                arr[i] = int.Parse(Console.ReadLine());
            }

            
           
            Console.WriteLine("Выборка: " + String.Join(" ", arr));
            Console.WriteLine("Среднее значение выборки: " + sample.Average(arr));
            Console.WriteLine("Медиана выборки: " + sample.Median(arr));
            Console.WriteLine("Мода выборки: " + sample.Mode(arr));
            Console.WriteLine("Максимальное значине выборки: " + sample.MaxValue(arr));
            Console.WriteLine("Минимальнон значине выборки: " + sample.MinValue(arr));
            Console.WriteLine("Розмах выборки: "+sample.SampleSize(arr));
            Console.WriteLine("Дисперсия выборки: "+sample.Dispersion(arr));
            Console.WriteLine("Стандартное отклонение выборки: " + sample.StandardDeviation(arr));
            Console.ReadLine();
        }
    }
}
