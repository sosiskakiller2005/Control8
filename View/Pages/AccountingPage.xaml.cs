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
            GroupCmb.ItemsSource = context.Group.ToList();
            GroupCmb.DisplayMemberPath = "Name";
            ActivityCmb.DisplayMemberPath = "Name";
            ActivityCmb.ItemsSource = context.Activity.ToList();
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
    }
}
