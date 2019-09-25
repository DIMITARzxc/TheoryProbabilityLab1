using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilituTheory
{
    class SampleMean
    {
        public double Average(double[] arr)
        {
            if (arr.Length == 0)
                throw new ArgumentException("Маccив не может быть пустым");

            double sum = 0;
            foreach (double elem in arr)
            {
                sum += elem;
            }

            return sum / arr.Length;
        }

        public double Median(double[] arr)
        {
            if (arr.Length == 0)
                throw new ArgumentException("Маccив не может быть пустым");

            double[] copyArr = (double[])arr.Clone();
            Array.Sort(copyArr);
            return copyArr[copyArr.Length / 2];
        }

        public double Mode(double[] arr)
        {
            if (arr.Length == 0)
                throw new ArgumentException("Маccив не может быть пустым");

            Dictionary<double, int> dict = new Dictionary<double, int>();
            foreach (double elem in arr)
            {
                if (dict.ContainsKey(elem))
                    dict[elem]++;
                else
                    dict[elem] = 1;
            }

            int maxCount = 0;
            double mode = Double.NaN;
            foreach (double elem in dict.Keys)
            {
                if (dict[elem] > maxCount)
                {
                    maxCount = dict[elem];
                    mode = elem;
                }
            }

            return mode;
        }
        public double MaxValue(double[] arr)
        {
            double maxvalue = double.MinValue;
            foreach (var item in arr)
            {

                if (item > maxvalue)
                {
                    maxvalue = item;
                }
            }

            return maxvalue;
        }
        public double MinValue(double[] arr)
        {
            double minvalue = double.MaxValue;
            foreach (var item in arr)
            {

                if (item < minvalue)
                {
                    minvalue = item;
                }
            }

            return minvalue;
        }
        public double SampleSize(double[] arr)
        {
            double sample = 0;
            double maxvalue = double.MinValue;
            foreach (var item in arr)
            {

                if (item > maxvalue)
                {
                    maxvalue = item;
                }
            }
            double minvalue = double.MaxValue;
            foreach (var item in arr)
            {

                if (item < minvalue)
                {
                    minvalue = item;
                }
            }
            sample = maxvalue - minvalue;
            return sample;
        }
        public double Dispersion(double[] arr)
        {
            double dispersion = 0, sumD = 0;
            if (arr.Length == 0)
                throw new ArgumentException("Маccив не может быть пустым");

            double sum = 0;
            foreach (double elem in arr)
            {
                sum += elem;
            }

            sum /= arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                dispersion = dispersion + ((arr[i] - sum) * (arr[i] - sum));
            }
            sumD = dispersion / arr.Length;
            return sumD;
        }
        public double StandardDeviation(double[] arr)
        {
            double dispersion = 0, deviation = 0;
            if (arr.Length == 0)
                throw new ArgumentException("Маccив не может быть пустым");

            double sum = 0;
            foreach (double elem in arr)
            {
                sum += elem;
            }

            sum /= arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                dispersion = dispersion + ((arr[i] - sum) * (arr[i] - sum));
            }
            deviation = Math.Sqrt(dispersion / arr.Length);
            return deviation;
        }
    }
}
