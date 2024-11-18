using RepairEquipment.data;
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
using System.Windows.Shapes;

namespace RepairEquipment.programm.App.Pages.CheckOrder
{
    /// <summary>
    /// Логика взаимодействия для WindowDeleteOrder.xaml
    /// </summary>
    public partial class WindowDeleteOrder : Window
    {
        private Request _request;
        private User _user;

        public WindowDeleteOrder(Request request)
        {
            InitializeComponent();
            LoadSystem();
            LoadDataSender(request);
            LoadData();
        }

        private void LoadDataSender(Request request)
        {
            var checkRequest = OdbConnectHelper.databaseconnect.Request.FirstOrDefault(
                x => x.Id == request.Id);

            var checkUser = OdbConnectHelper.databaseconnect.User.FirstOrDefault(
                x => x.id == request.ClientId);

            _request = checkRequest;
            _user = checkUser;
        }

        private void LoadSystem()
        {
            TxbProblemeDescryption.IsEnabled = false;
            TxbProblemeDescryptionMaster.IsEnabled = false;
            CmdHomeTech.IsEnabled = false;
            CmdModelTechFactory.IsEnabled = false;
            CmdTechColor.IsEnabled = false;
            CmdMaster.IsEnabled = false;
            CmdOrderStatus.IsEnabled = false;
            TxbProblemeDescryptionMaster.IsEnabled = false;
        }

        private void LoadData()
        {
            CmdHomeTech.ItemsSource = OdbConnectHelper.databaseconnect.HomeTech.ToList();
            CmdHomeTech.SelectedValuePath = "Id";
            CmdHomeTech.DisplayMemberPath = "Name";

            CmdModelTechFactory.ItemsSource = OdbConnectHelper.databaseconnect.FirmModel.ToList();
            CmdModelTechFactory.SelectedValuePath = "Id";
            CmdModelTechFactory.DisplayMemberPath = "Model";

            CmdTechColor.ItemsSource = OdbConnectHelper.databaseconnect.Color.ToList();
            CmdTechColor.SelectedValuePath = "Id";
            CmdTechColor.DisplayMemberPath = "Name";

            var checkUser = OdbConnectHelper.databaseconnect.User.Where(
                x => x.IdRole == 2);

            CmdMaster.ItemsSource = checkUser.ToList();
            CmdMaster.SelectedValuePath = "id";
            CmdMaster.DisplayMemberPath = "Name";

            CmdOrderStatus.ItemsSource = OdbConnectHelper.databaseconnect.Status.ToList();
            CmdOrderStatus.SelectedValuePath = "Id";
            CmdOrderStatus.DisplayMemberPath = "Name";

            if (CmdHomeTech.ItemsSource == null || CmdModelTechFactory.ItemsSource == null || CmdTechColor.ItemsSource == null
                || CmdMaster.ItemsSource == null || CmdOrderStatus.ItemsSource == null)
            {
                CmdHomeTech.SelectedValue = null;
                CmdModelTechFactory.SelectedValue = null;
                CmdTechColor.SelectedValue = null;
                CmdMaster.SelectedValue = null;
                CmdOrderStatus.SelectedValue = null;
                TxbProblemeDescryptionMaster.Text = "Ошибка подключение к базе данных";
                TxbProblemeDescryption.Text = "Ошибка подключение к базе данных";
            }
            else
            {
                CmdHomeTech.SelectedValue = _request.IdTech;
                CmdModelTechFactory.SelectedValue = _request.IdFirmModel;
                CmdTechColor.SelectedValue = _request.IdColor;
                TxbProblemeDescryption.Text = _request.ProblemDescryption;
                CmdMaster.SelectedValue = _request.MasterId;
                CmdOrderStatus.SelectedValue = _request.IdStatus;
                TxbProblemeDescryptionMaster.Text = _request.RepairParts;
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены. что хотите удалить заказ?",
                                            "Системное уведомление | Удаление пользователя",
                                            MessageBoxButton.YesNo,
                                            MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                OdbConnectHelper.databaseconnect.Request.Remove(_request);
                OdbConnectHelper.databaseconnect.SaveChanges();
                MessageBox.Show("Заказ вид техники:" + _request.HomeTech + " модель фирмы: " + _request.FirmModel + " цвет: " + _request.Color + "."
                    + " От клиента: " + _user.Surname + " " + _user.Name + " " + _user.Patronymic + ".",
                "Системное уведомление | Удаление пользователя",
                MessageBoxButton.OK,
                MessageBoxImage.Information);

                this.Close();
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
