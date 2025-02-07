using Control8.Model;
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

namespace Control8.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ReportPage1.xaml
    /// </summary>
    public partial class ReportPage1 : Page
    {
        Entities entities = new Entities();
        public ReportPage1()
        {
            InitializeComponent();
        }

        private void SelectBtn_Click(object sender, RoutedEventArgs e)
        {
            var a = (DateTime)StartDP.SelectedDate;
            var b = (DateTime)EndDP.SelectedDate;
            DatGr.ItemsSource = entities.Journal.Where(y => y.DateEvent >= a && y.DateEvent <= b).ToList();

            var CountRecording = entities.Journal.Count();


            var SumMark = entities.Journal.
                Select(y => y.Mark).Sum();
            AvgMarkTb.Text = Convert.ToString(SumMark / CountRecording);
        }
    }
}
