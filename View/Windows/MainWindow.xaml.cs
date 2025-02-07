using Control8.AppData;
using Control8.View.Pages;
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
using System.Windows.Shapes;

namespace Control8.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrm.Navigate(new StartPage());
            FrameHelper.selectedFrame = MainFrm;
        }

        private void AddRegionHl_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new AddGroupPage());
        }

        private void AccountingHl_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate( new AccountingPage());
        }

        private void Report2Hl_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate( new ReportPage2());

        }

        private void Report1Hl_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate( new ReportPage1());

        }
    }
}
