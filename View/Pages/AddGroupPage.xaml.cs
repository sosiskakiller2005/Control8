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
    /// Логика взаимодействия для AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : Page
    {
        Entities context = new Entities();
        public AddGroupPage()
        {
            InitializeComponent();
            SpecialCmb.ItemsSource = context.Special.ToList();
            SpecialCmb.DisplayMemberPath = "Name";
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(GroupName.Text) && SpecialCmb.SelectedItem != null)
            {
                Group newGroup = new Group(){
                    Name = GroupName.Text,
                    Special = SpecialCmb.SelectedItem as Special
                };
                context.Group.Add(newGroup);
                context.SaveChanges();
                MessageBox.Show("Группа добавлена.");
            }
        }
    }
}
