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
    /// Логика взаимодействия для AccountingPage.xaml
    /// </summary>
    public partial class AccountingPage : Page
    {
        Entities context = new Entities();
        public AccountingPage()
        {
            InitializeComponent();
            JournalLv.ItemsSource = context.Journal.ToList();
            GroupCmb.ItemsSource = context.Group.ToList();
            GroupCmb.DisplayMemberPath = "Name";
            ActivityCmb.ItemsSource = context.Activity.ToList();
            ActivityCmb.DisplayMemberPath = "Name";
            SpecialCmb.ItemsSource = context.Special.ToList();
            SpecialCmb.DisplayMemberPath = "Name";
            DirectionCmb.ItemsSource = context.Direction.ToList();
            DirectionCmb.DisplayMemberPath = "Name";
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            Journal newJournal = new Journal()
            {
                DateEvent = (DateTime)DateDp.SelectedDate,
                Group = GroupCmb.SelectedItem as Group,
                Activity = ActivityCmb.SelectedItem as Activity,
                Mark = Convert.ToInt32(MarkTb.Text)
            };
            context.Journal.Add(newJournal);
            context.SaveChanges();
            MessageBox.Show("Запись добавлена.");
        }

        private void SpecialCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Group> groups = context.Group.ToList();
            GroupCmb.ItemsSource = groups.Where(g => g.Special == SpecialCmb.SelectedItem as Special).ToList();
        }

        private void DirectionCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Activity> activities = context.Activity.ToList();
            ActivityCmb.ItemsSource = activities.Where(a => a.Direction == DirectionCmb.SelectedItem as Direction).ToList();
        }
    }
}
