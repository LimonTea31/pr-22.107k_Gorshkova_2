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

namespace pr_22._107k_Gorshkova_2
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
        private void Input(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }
        private void btnStartClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string input = tb_text.Text;
                if (string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("Введите буквы");
                    return;
                }
                int vowelsCount = CountVowels(input);
                tb_text.Text += "\nКоличество гласных букв: " + vowelsCount;
                    string longestWord = FindLongestWord(input);
                tb_text.Text += "\nСамое длинное слово: " + longestWord;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
        
        private int CountVowels(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0; foreach (char c in input.ToLower())
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
        private string FindLongestWord(string input)
        {
            string[] words = input.Split(' ');
            string longestWord = ""; foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            return longestWord;
        }

        private void txvvod_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        private void txvvod_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsLetter(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void tb_text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnTry_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                int x = int.Parse(tblTry.Text);
            }catch(FormatException)
            {
                MessageBox.Show("Работает");
            }
        }
    }
}
