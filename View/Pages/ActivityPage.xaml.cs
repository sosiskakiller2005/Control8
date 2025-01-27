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
    /// Логика взаимодействия для ActivityPage.xaml
    /// </summary>
    public partial class ActivityPage : Page
    {
        Entities context = new Entities();
        public ActivityPage(Group selectedGroup)
        {
            InitializeComponent();
            List<Journal> journals = context.Journal.ToList();
            ActivityDg.ItemsSource = journals.Where(j => j.Group == selectedGroup);
        }
    }
}
