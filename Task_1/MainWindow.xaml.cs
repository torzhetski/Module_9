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

namespace Task_1
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
       
        private void TextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (TextBox1.Text == "Введите текст...")
            {
                TextBox1.Clear();
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (TextBox1.Text == "Введите текст...")
            {
                TextBox1.Clear();
            }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (TextBox2.Text == "Введите текст...")
            {
                TextBox2.Clear();
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Spisok.Visibility=Visibility.Visible;
            var text = module_5.Split(TextBox1.Text);
            for (int i = 0; i < text.Length; i++)
            {
                Spisok.Items.Add(text[i]);
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            lable.Visibility=Visibility.Visible;
            lable.Content = module_5.ReversPhrase(TextBox2.Text);
        }

       
    }
}
