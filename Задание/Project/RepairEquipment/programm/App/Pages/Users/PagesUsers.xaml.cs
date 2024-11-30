using RepairEquipment.data;
using RepairEquipment.programm.App.Pages.Users;
using RepairEquipment.scripts;
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

namespace RepairEquipment.programm.App.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagesUsers.xaml
    /// </summary>
    public partial class PagesUsers : Page
    {
        public PagesUsers()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DtgTable.ItemsSource = OdbConnectHelper.databaseconnect.User.ToList();
        }

        private void BtnDetailUser_Click(object sender, RoutedEventArgs e)
        {
            WindowsDetailUser windowsDetailUser = new WindowsDetailUser((sender as Button).DataContext as User);
            windowsDetailUser.Show();
        }

        private void BtnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            WindowsDeleteUser windowsDeleteUser = new WindowsDeleteUser((sender as Button).DataContext as User);
            windowsDeleteUser.Show();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
