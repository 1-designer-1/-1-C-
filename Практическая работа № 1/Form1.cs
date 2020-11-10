using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_11;

namespace Практическая_работа___1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ОчиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Серегин Денис\n" +
               "ИСП - 31\n" +
               "Практическая работа № 1\n" +
               "Найти произведение n целых случайных чисел  X., распределенных в диапазоне от 0 до n.  Вывести на экран на одной строке сгенерированные числа, на другой строке результат");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int chaslo = Convert.ToInt32(textBox1.Text);
            Class1 mathFunc = new Class1();//создание экземпляра класса, для работы с его функциями
            int[] randomMass = new int[chaslo];//одномерный массив
            randomMass = mathFunc.Rand(chaslo);//вызов функции Rand
            textBox3.Text = mathFunc.Proiz(randomMass).ToString();//вызов функции Proiz и запись результата в текстовое поле
            textBox2.Clear();//очистка текстового поля
            //вывод значений из массива в текстовое поле
            for (int i = 0; i < randomMass.Length; i++)
            {
                textBox2.Text += randomMass[i].ToString() + " ";
            }

        }
    }
}
