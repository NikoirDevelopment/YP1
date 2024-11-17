using RepairEquipment.data;
using RepairEquipment.scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace RepairEquipment.programm.App
{
    /// <summary>
    /// Логика взаимодействия для AppRepairEquipment.xaml
    /// </summary>
    public partial class AppRepairEquipment : Window
    {
        public AppRepairEquipment()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            ControlHelper.programm.frmObj = FrmMain;
            OdbConnectHelper.databaseconnect = new OdbYP1Entities();

            SystemScript.CheckBtn = 0;

            if (BufferUser.Role != null)
            {
                switch (BufferUser.Role)
                {
                    case 1:
                        Btn_Users.Visibility = Visibility.Visible;
                        Btn_Statistics.Visibility = Visibility.Visible;
                        Btn_CheckOrder.Visibility = Visibility.Visible;
                        Btn_CreateOrder.Visibility = Visibility.Visible;
                        Btn_Message.Visibility = Visibility.Visible;
                        LblGrid0.Visibility = Visibility.Hidden;
                        LblGrid1.Visibility = Visibility.Hidden;
                        break;

                    case 2:
                        Btn_Users.Visibility = Visibility.Visible;
                        Btn_Statistics.Visibility = Visibility.Visible;
                        Btn_CheckOrder.Visibility = Visibility.Visible;
                        Btn_CreateOrder.Visibility = Visibility.Visible;
                        Btn_Message.Visibility = Visibility.Visible;
                        LblGrid0.Visibility = Visibility.Hidden;
                        LblGrid1.Visibility = Visibility.Hidden;
                        break;

                    case 3:
                        Btn_Users.Visibility = Visibility.Visible;
                        Btn_Statistics.Visibility = Visibility.Visible;
                        Btn_CheckOrder.Visibility = Visibility.Visible;
                        Btn_CreateOrder.Visibility = Visibility.Visible;
                        Btn_Message.Visibility = Visibility.Visible;
                        LblGrid0.Visibility = Visibility.Hidden;
                        LblGrid1.Visibility = Visibility.Hidden;
                        break;

                    case 4:
                        Btn_Users.Visibility = Visibility.Collapsed;
                        Btn_Statistics.Visibility = Visibility.Collapsed;
                        Btn_CheckOrder.Visibility = Visibility.Visible;
                        Btn_CreateOrder.Visibility = Visibility.Visible;
                        Btn_Message.Visibility = Visibility.Visible;
                        LblGrid0.Visibility = Visibility.Hidden;
                        LblGrid1.Visibility = Visibility.Hidden;
                        break;
                }
            }
            else
            {
                Btn_Users.Visibility = Visibility.Collapsed;
                Btn_Statistics.Visibility = Visibility.Collapsed;
                Btn_CheckOrder.Visibility = Visibility.Collapsed;
                Btn_CreateOrder.Visibility = Visibility.Collapsed;
                Btn_Message.Visibility = Visibility.Collapsed;
                LblGrid0.Visibility = Visibility.Visible;
                LblGrid1.Visibility = Visibility.Visible;
            }
        }

        private void Btn_Users_Click(object sender, RoutedEventArgs e)
        {
            this.Title = "БытСервис | Пользователи";
            //ControlHelper.programm.frmObj.Navigate(new PagesUsers());
        }

        private void Btn_CreateOrder_Click(object sender, RoutedEventArgs e)
        {
            this.Title = "БытСервис | Создание заявки";
            //ControlHelper.programm.frmObj.Navigate(new PagesCreateOrder());
        }

        private void Btn_CheckOrder_Click(object sender, RoutedEventArgs e)
        {
            this.Title = "БытСервис | Проверка заказа";
            //ControlHelper.programm.frmObj.Navigate(new PagesCheckOrder());
        }

        private void Btn_Statistics_Click(object sender, RoutedEventArgs e)
        {
            this.Title = "БытСервис | Статистика деятельности";
            //ControlHelper.programm.frmObj.Navigate(new PagesStatistick());
        }

        private void Btn_Message_Click(object sender, RoutedEventArgs e)
        {
            this.Title = "БытСервис | Уведомление";
            //ControlHelper.programm.frmObj.Navigate(new PagesMessage());
        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите выйти из системы?",
                "Системное уведомление | БытСеривис",
                MessageBoxButton.YesNo,
                MessageBoxImage.Information);

            if (result == MessageBoxResult.Yes)
            {
                SystemScript.CheckBtn = 1;

                MessageBox.Show("Вы вышли из системы!",
                    "Системное уведомление | БытСеривис",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                this.Close();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (SystemScript.CheckBtn == 0)
            {
                MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите выйти из системы?",
                "Системное уведомление | БытСеривис",
                MessageBoxButton.YesNo,
                MessageBoxImage.Information);

                if (result == MessageBoxResult.Yes)
                {
                    MessageBox.Show("Вы вышли из системы!",
                        "Системное уведомление | БытСеривис",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);

                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }

        }
    }
}
