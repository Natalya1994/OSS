using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using System.ComponentModel;
using Microsoft.Win32;


namespace _1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int ty, sum = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tbN_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
            myAL.Sort();
            lbMain.Items.Add("Отсортированный массив");
            foreach (int elem in myAL)
            {
                lbMain.Items.Add(elem);
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lbMain.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lbMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index, k;
            try
            {

                int y, l = 1;
                int itemCount = Convert.ToInt32(tbN.Text);
                k = Convert.ToInt32(tbN.Text);
                int[] ma = new int[k];//если отрицательная, то будет ошибка
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                lbMain.Items.Add("Исходный массив");
                for (index = 1; index <= itemCount; index++)
                {
                    number = -14 + rnd1.Next(57);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                }


                y = myAL.Count;
                int[] mas = new int[y];
                foreach (int i in myAL)
                {
                    if (i > 25)
                    {

                        lbMain.Items.Add("номер элемента,большего 25=");
                        lbMain.Items.Add(l);
                        break;
                    }
                    else l++;

                    if (l == k + 1)
                    {
                        // lbMain.Items.Clear();
                        //MessageBox.Show("нет таких элементов!");
                        lbMain.Items.Add("нет таких элементов");
                    }
                }
            }
            catch
            {
                lbMain.Items.Clear();
                MessageBox.Show("Error!");
            }
            //k = Convert.ToInt32(tbN.Text);
            /*if (k < 1)
            {
                lbMain.Items.Clear();
                MessageBox.Show("Error!");
            }*/
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {



            ArrayList myAL = new ArrayList();
            int index;

            try
            {
                int y, l = 1, t;
                int itemCount = Convert.ToInt32(tbN.Text);
                int k = Convert.ToInt32(tbN.Text);
                int[] mas = new int[k];
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                lbMain.Items.Add("Исходный массив");
                for (index = 1; index <= itemCount; index++)
                {
                    number = -14 + rnd1.Next(57);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                }


                // y = myAL.Count;
                //int[] mas = new int[y];
                foreach (int i in myAL)
                {
                    if (l == 2)
                    {

                        t = i;
                        ty = i;
                        lbMain.Items.Add("number 2 element=");
                        lbMain.Items.Add(ty);
                        break;
                    }
                    else l++;

                }

                // lbMain.Items.Add(ty);
                foreach (int i in myAL)
                {
                    if (i > ty)
                    {
                        sum += i;
                    }
                }
                lbMain.Items.Add("suma=");
                lbMain.Items.Add(sum);

            }
            catch
            {
                lbMain.Items.Clear();
                MessageBox.Show("Error!");
            }

            // int  r = Convert.ToInt32(tbN.Text);
            /*if (r< 1)
            {
                lbMain.Items.Clear();
                MessageBox.Show("Error!");
            }*/
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int i;
            try
            {
                int y, l = 1, t = 0;
                int itemCount = Convert.ToInt32(tbN.Text);
                int[] mas = new int[itemCount];
                // int k = Convert.ToInt32(tbN.Text);
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                lbMain.Items.Add("Исходный массив");
                for (i = 1; i <= itemCount; i++)
                {
                    number = rnd1.Next(1, 15);
                    mas[i - 1] = number;
                    myAL.Add(number);
                    lbMain.Items.Add(number);

                }

                // lbMain.Items.Add(myAL[0]);
                for (i = 1; i < itemCount - 1; i++)
                {

                    if (mas[i] > mas[i - 1] && mas[i] > mas[i + 1]) t++;
                }
                lbMain.Items.Add("элементов массива больших соседей=");
                lbMain.Items.Add(t);
            }

            catch
            {
                lbMain.Items.Clear();
                MessageBox.Show("Error!");
            }
            /*int r = Convert.ToInt32(tbN.Text);
            if (r< 1&& r>-1)
            {
                lbMain.Items.Clear();
                MessageBox.Show("Error!");
            }*/
        }
    }
}








