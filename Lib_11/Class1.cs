using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_11
{
    public class Class1
    {
        /// <summary>
        /// Генерирует числа распределенные в диапазоне от 0 до n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] Rand(int n)
        {
            Random Rnd = new Random();
            int[] mas = new int[n];

            for (int t = 0; t < mas.Length; t++)
            {
                mas[t] = Rnd.Next(0, n);
            }

            return mas;

        }

        /// <summary>
        /// Выводит произведение целых случайных чисел.
        /// </summary>
        /// <param name="mas"></param>
        /// <returns></returns>
        public int Proiz(int[] mas)
        {

            int proizChacla = 1;
            for (int i = 0; i < mas.Length; i++)
            {
                proizChacla *= mas[i];
            }
            return proizChacla;

        }

    }
}
