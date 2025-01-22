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
    /// Логика взаимодействия для AddAtivityPaGE.xaml
    /// </summary>
    public partial class AddAtivityPaGE : Page
    {
        Entities context = new Entities();
        public AddAtivityPaGE()
        {
            InitializeComponent();
            DirectionCmb.ItemsSource = context.Direction.ToList();
            DirectionCmb.DisplayMemberPath = "Name";
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ActivityNameTb.Text) && DirectionCmb.SelectedItem != null)
            {
                Activity activity = new Activity()
                {
                    Name = ActivityNameTb.Text,
                    Direction = DirectionCmb.SelectedItem as Direction
                };
                context.Activity.Add(activity);
                context.SaveChanges();
                MessageBox.Show("Активность добавлена.");
            }
        }
    }
}
   