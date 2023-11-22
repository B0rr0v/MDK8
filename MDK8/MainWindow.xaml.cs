using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MDK8
//Создать интерфейс – серия чисел (см. лекцию). Создать класс – геометрическая
//прогрессия. Класс должен включать конструктор.Сравнение производить по шагу прогрессии.
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Агальцов Даниил ИСП-31 Практическая работа №8:Создать интерфейс – серия чисел (см. лекцию). Создать класс – геометрическая прогрессия. Класс должен включать конструктор.Сравнение производить по шагу прогрессии.");
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            tb4.Clear();
            tb5.Clear();
            tb6.Clear();
            Listok.Items.Clear();
            Listok1.Items.Clear();
        }

        private void Пуск(object sender, RoutedEventArgs e)
        {

            bool f = Int32.TryParse(tb3.Text, out int a);
            bool f1 = Int32.TryParse(tb1.Text, out int b);
            bool f2 = Int32.TryParse(tb2.Text, out int c);
            bool f3 = Int32.TryParse(tb4.Text, out int d);
            bool f4 = Int32.TryParse(tb5.Text, out int g);
            bool f5 = Int32.TryParse(tb6.Text, out int h);
            if (f && f1 && f2 && f3 && f4 && f5 && c > 0 && h > 0)
            {
                GeomProg series = new GeomProg(a, b);
                series.SetStart(a);
                Listok.Items.Add(a);
                for (int i = 1; i < c; i++)
                {
                    Listok.Items.Add(series.GetNext());

                }

                GeomProg series1 = new GeomProg(d, g);
                series1.SetStart(d);
                Listok1.Items.Add(d);
                for (int i = 1; i < h; i++)
                {
                    Listok1.Items.Add(series1.GetNext());

                }

            }
            else MessageBox.Show("Заполните текстбокс числами", "", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        private void Сравнить(object sender, RoutedEventArgs e)
        {
            bool h = Int32.TryParse(tb1.Text, out int x);
            bool h1 = Int32.TryParse(tb5.Text, out int y);
            GeomProg series = new GeomProg(x, y);
            if (x.CompareTo(y) == 0) MessageBox.Show("Шаги равны", "", MessageBoxButton.OK, MessageBoxImage.Error);
            if (x.CompareTo(y) == 1) MessageBox.Show("Первый шаг больше второго", "", MessageBoxButton.OK, MessageBoxImage.Error);
            if (x.CompareTo(y) == -1) MessageBox.Show("Второй шаг больше первого", "", MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}
