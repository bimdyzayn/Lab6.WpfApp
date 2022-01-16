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

namespace Lab6WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WeatherControl pogoda = new WeatherControl(35,"Западное",5,1);
            InitializeComponent();
            TempTextBox.Text = pogoda.Temp.ToString();
            NaprTextBox.Text = pogoda.Napr;
            SkorTextBox.Text = pogoda.Skor.ToString();
            OsadTextBox.Text = pogoda.Osad.ToString();
        }
    }
}
