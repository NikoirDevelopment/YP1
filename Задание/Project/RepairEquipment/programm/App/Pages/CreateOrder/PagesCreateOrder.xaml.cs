using RepairEquipment.data;
using RepairEquipment.programm.App.Pages.CheckOrder;
using RepairEquipment.scripts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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

namespace RepairEquipment.programm.App.Pages.CreateOrder
{
    /// <summary>
    /// Логика взаимодействия для PagesCreateOrder.xaml
    /// </summary>
    public partial class PagesCreateOrder : Page
    {
        public PagesCreateOrder()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            CmdHomeTech.ItemsSource = OdbConnectHelper.databaseconnect.HomeTech.ToList();
            CmdHomeTech.SelectedValuePath = "Id";
            CmdHomeTech.DisplayMemberPath = "Name";

            CmdTechFactory.ItemsSource = OdbConnectHelper.databaseconnect.FirmModel.ToList();
            CmdTechFactory.SelectedValuePath = "Id";
            CmdTechFactory.DisplayMemberPath = "Model";

            CmdTechColor.ItemsSource = OdbConnectHelper.databaseconnect.TechColor.ToList();
            CmdTechColor.SelectedValuePath = "Id";
            CmdTechColor.DisplayMemberPath = "Name";
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            if ((CmdHomeTech.ItemsSource != null) && (CmdTechFactory.ItemsSource != null) && (CmdTechColor.ItemsSource != null)
                && TxbProblemeDescryption.Text.Length > 0)
            {
                MessageBoxResult result = MessageBox.Show("Подтвердить создание заявки на ремонт?",
                    "Системное уведомление | Создание заявки",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Information);

                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        Request request = new Request
                        {
                            StartDate = DateTime.Now,
                            IdTech = (int)CmdHomeTech.SelectedValue,
                            IdFirmModel = (int)CmdTechFactory.SelectedValue,
                            IdColor = (int)CmdTechColor.SelectedValue,
                            ProblemDescryption = TxbProblemeDescryption.Text,
                            IdStatus = 3,
                            ClientId = BufferUser.Id
                        };

                        OdbConnectHelper.databaseconnect.Request.Add(request);
                        OdbConnectHelper.databaseconnect.SaveChanges();

                        MessageBox.Show("Заявка создана!",
                            "Критическая ошибка | Создание заявки",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);

                        CmdHomeTech.SelectedValue = null;
                        CmdTechFactory.SelectedValue = null;
                        CmdTechColor.SelectedValue = null;

                        ControlHelper.programm.frmObj.Navigate(new PagesCheckOrder());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Критическая ошибка базы данных! " + ex,
                            "Критическая ошибка | Создание заявки",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Одно или несколько полей не заполнено!",
                    "Системное уведомление | Создание заявки",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }
    }
}
