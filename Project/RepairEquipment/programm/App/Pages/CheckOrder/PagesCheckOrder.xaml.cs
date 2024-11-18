using RepairEquipment.data;
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

namespace RepairEquipment.programm.App.Pages.CheckOrder
{
    /// <summary>
    /// Логика взаимодействия для PagesCheckOrder.xaml
    /// </summary>
    public partial class PagesCheckOrder : Page
    {
        public PagesCheckOrder()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            if (BufferUser.Role == 4)
            {
                var checkRoleUser = OdbConnectHelper.databaseconnect.Request.Where(
                    x => x.ClientId == BufferUser.Id);

                DtgTable.ItemsSource = checkRoleUser.ToList();

                CmdHomeTech.ItemsSource = OdbConnectHelper.databaseconnect.HomeTech.ToList();
                CmdHomeTech.SelectedValuePath = "Id";
                CmdHomeTech.DisplayMemberPath = "Name";

            }
            else if (BufferUser.Role == 2)
            {
                var checkRoleMaster = OdbConnectHelper.databaseconnect.Request.Where(
                    x => x.MasterId == (BufferUser.Id) && ((x.IdStatus == 1) || (x.IdStatus == 3)));

                DtgTable.ItemsSource = checkRoleMaster.ToList();

                CmdHomeTech.ItemsSource = OdbConnectHelper.databaseconnect.HomeTech.ToList();
                CmdHomeTech.SelectedValuePath = "Id";
                CmdHomeTech.DisplayMemberPath = "Name";
            }
            else
            {
                DtgTable.ItemsSource = OdbConnectHelper.databaseconnect.Request.ToList();

                CmdHomeTech.ItemsSource = OdbConnectHelper.databaseconnect.HomeTech.ToList();
                CmdHomeTech.SelectedValuePath = "Id";
                CmdHomeTech.DisplayMemberPath = "Name";
            }
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (BufferUser.Role == 4)
            {
                var checkHomeTech = OdbConnectHelper.databaseconnect.Request.Where(
                    x => x.IdTech == ((int)CmdHomeTech.SelectedValue) && (x.ClientId == BufferUser.Id));

                DtgTable.ItemsSource = checkHomeTech.ToList();
            }
            else if (BufferUser.Role == 2)
            {
                var checkHomeTech = OdbConnectHelper.databaseconnect.Request.Where(
                    x => x.IdTech == ((int)CmdHomeTech.SelectedValue) && (x.MasterId == BufferUser.Id)
                    && ((x.IdStatus == 1) || (x.IdStatus == 3)));

                DtgTable.ItemsSource = checkHomeTech.ToList();
            }
            else
            {
                var checkHomeTech = OdbConnectHelper.databaseconnect.Request.Where(
                    x => x.IdTech == (int)CmdHomeTech.SelectedValue);

                DtgTable.ItemsSource = checkHomeTech.ToList();
            }

        }

        private void BtnClean_Click(object sender, RoutedEventArgs e)
        {
            CmdHomeTech.SelectedValue = null;
            LoadData();
        }

        private void BtnEditOrder_Click(object sender, RoutedEventArgs e)
        {
            WindowEditOrder windowEditOrder = new WindowEditOrder((sender as Button).DataContext as Request);
            windowEditOrder.Show();
        }

        private void BtnDeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            WindowDeleteOrder windowDeleteOrder = new WindowDeleteOrder((sender as Button).DataContext as Request);
            windowDeleteOrder.Show();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
