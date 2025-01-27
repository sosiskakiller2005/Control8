using Control8.AppData;
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
    /// Логика взаимодействия для ReportPage2.xaml
    /// </summary>
    public partial class ReportPage2 : Page
    {
        Entities context = new Entities();
        public ReportPage2()
        {
            InitializeComponent();
            SpecialCmb.ItemsSource = context.Special.ToList();
            SpecialCmb.DisplayMemberPath = "Name";
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            List<Group> groups = context.Group.ToList();
            GroupDg.ItemsSource = groups.Where(g => g.Special == SpecialCmb.SelectedItem as Special);
        }

        private void SelectBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.selectedFrame.Navigate(new ActivityPage(GroupDg.SelectedItem as Group));
        }

        private void SelectBtn_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
} 
