using Somafet.UnicodePasswordGenerator;
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

namespace Somafet.PwGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            GeneratePassword(26);

            GenerateButton.Click += GenerateButton_Pressed;
            CopyButton.Click += CopyButton_Pressed;
        }

        private void CopyButton_Pressed(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(PasswordTextBox.Text);
        }

        private void GenerateButton_Pressed(object sender, RoutedEventArgs e)
        {
            GeneratePassword(26);
        }

        private void GeneratePassword(int passwordLength)
        {
            PasswordTextBox.Text = PasswordGenerator.Next(passwordLength);
        }
    }
}
