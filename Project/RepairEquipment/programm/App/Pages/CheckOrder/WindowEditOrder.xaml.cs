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
using System.Windows.Shapes;

namespace RepairEquipment.programm.App.Pages.CheckOrder
{
    /// <summary>
    /// Логика взаимодействия для WindowEditOrder.xaml
    /// </summary>
    public partial class WindowEditOrder : Window
    {
        private Request _request;
        public WindowEditOrder(Request request)
        {
            InitializeComponent();
            LoadDataSender(request);
            LoadSystem();
            LoadData();
        }

        /// <summary>
        /// Распаковка данных от Sender
        /// </summary>
        /// <param name="request"></param>
        private void LoadDataSender(Request request)
        {
            var checkRequest = OdbConnectHelper.databaseconnect.Request.FirstOrDefault(
                x => x.Id == request.Id);

            _request = request;
        }

        /// <summary>
        /// Загрузка параметров системы
        /// </summary>
        private void LoadSystem()
        {
            switch (BufferUser.Role)
            {
                case 1: // Менеджер
                    if (_request.IdStatus == 4)
                    {
                        MessageBox.Show("Заявка имеет статус завершен. Изменению не должна подвергаться!",
                            "Уведомление",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);

                        TxbProblemeDescryption.IsEnabled = false;
                        TxbProblemeDescryptionMaster.IsEnabled = false;
                        CmdHomeTech.IsEnabled = false;
                        CmdModelTechFactory.IsEnabled = false;
                        CmdTechColor.IsEnabled = false;
                        CmdMaster.IsEnabled = false;
                        CmdOrderStatus.IsEnabled = false;
                        TxbProblemeDescryptionMaster.IsEnabled = false;
                    }
                    else
                    {
                        TxbProblemeDescryption.IsEnabled = false;
                        TxbProblemeDescryptionMaster.IsEnabled = true;
                        CmdHomeTech.IsEnabled = false;
                        CmdModelTechFactory.IsEnabled = false;
                        CmdTechColor.IsEnabled = false;
                        CmdMaster.IsEnabled = true;
                        CmdOrderStatus.IsEnabled = true;
                        TxbProblemeDescryptionMaster.IsEnabled = true;
                    }
                break;

                case 2: // Мастер
                    if (_request.IdStatus == 4)
                    {
                        MessageBox.Show("Заявка имеет статус завершен. Изменению не подлежит!",
                            "Уведомление",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);

                        TxbProblemeDescryption.IsEnabled = false;
                        TxbProblemeDescryptionMaster.IsEnabled = false;
                        CmdHomeTech.IsEnabled = false;
                        CmdModelTechFactory.IsEnabled = false;
                        CmdTechColor.IsEnabled = false;
                        CmdMaster.IsEnabled = false;
                        StcpTxbMaster.Visibility = Visibility.Collapsed;
                        CmdOrderStatus.IsEnabled = false;
                        TxbProblemeDescryptionMaster.IsEnabled = false;
                    }
                    else
                    {
                        TxbProblemeDescryption.IsEnabled = false;
                        TxbProblemeDescryptionMaster.IsEnabled = true;
                        CmdHomeTech.IsEnabled = false;
                        CmdModelTechFactory.IsEnabled = false;
                        CmdTechColor.IsEnabled = false;
                        CmdMaster.IsEnabled = false;
                        CmdOrderStatus.IsEnabled = false;
                        TxbProblemeDescryptionMaster.IsEnabled = true;
                    }
                break;

                case 3: //Оператор
                    if (_request.IdStatus == 4)
                    {
                        MessageBox.Show("Заявка имеет статус завершен. Изменению не подлежит!",
                            "Уведомление",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);

                        TxbProblemeDescryption.IsEnabled = false;
                        TxbProblemeDescryptionMaster.IsEnabled = false;
                        CmdHomeTech.IsEnabled = false;
                        CmdModelTechFactory.IsEnabled = false;
                        CmdTechColor.IsEnabled = false;
                        CmdMaster.IsEnabled = false;
                        CmdOrderStatus.IsEnabled = false;
                        TxbProblemeDescryptionMaster.IsEnabled = false;
                    }
                    else
                    {
                        TxbProblemeDescryption.IsEnabled = false;
                        TxbProblemeDescryptionMaster.IsEnabled = true;
                        CmdHomeTech.IsEnabled = false;
                        CmdModelTechFactory.IsEnabled = false;
                        CmdTechColor.IsEnabled = false;
                        CmdMaster.IsEnabled = true;
                        CmdOrderStatus.IsEnabled = true;
                        TxbProblemeDescryptionMaster.IsEnabled = true;
                    }
                break;

                case 4: // Клиент
                    if (_request.IdStatus == 4)
                    {
                        MessageBox.Show("Заявка имеет статус завершен. Изменению не подлежит!",
                            "Уведомление",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);

                        TxbProblemeDescryption.IsEnabled = false;
                        TxbProblemeDescryptionMaster.IsEnabled = false;
                        CmdHomeTech.IsEnabled = false;
                        CmdModelTechFactory.IsEnabled = false;
                        CmdTechColor.IsEnabled = false;
                        CmdMaster.IsEnabled = false;
                        StcpTxbMaster.Visibility = Visibility.Collapsed;
                        CmdOrderStatus.IsEnabled = false;
                        TxbProblemeDescryptionMaster.IsEnabled = false;
                    }
                    else
                    {
                        TxbProblemeDescryption.IsEnabled = true;
                        TxbProblemeDescryptionMaster.IsEnabled = false;
                        CmdHomeTech.IsEnabled = true;
                        CmdModelTechFactory.IsEnabled = true;
                        CmdTechColor.IsEnabled = true;
                        CmdMaster.IsEnabled = false;
                        StcpTxbMaster.Visibility = Visibility.Collapsed;
                        CmdOrderStatus.IsEnabled = false;
                        TxbProblemeDescryptionMaster.IsEnabled = false;
                    }
                break;
            }
        }

        /// <summary>
        /// Загрузка данных
        /// </summary>
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

        private void BtnCreateEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (BufferUser.Role)
                {
                    case 1:
                        _request.RepairParts = TxbProblemeDescryptionMaster.Text;
                        OdbConnectHelper.databaseconnect.SaveChanges();

                        MessageBox.Show("Статус заявки изменено!",
                            "Системное уведомление",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);

                        this.Close();
                    break;

                    case 2:
                        _request.RepairParts = TxbProblemeDescryptionMaster.Text;
                        OdbConnectHelper.databaseconnect.SaveChanges();

                        MessageBox.Show("Статус заявки изменено!",
                            "Системное уведомление",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);

                        this.Close();
                    break;

                    case 3:
                        _request.IdTech = (int)CmdHomeTech.SelectedValue;
                        _request.IdFirmModel = (int)CmdModelTechFactory.SelectedValue;
                        _request.IdColor = (int)CmdTechColor.SelectedValue;
                        _request.ProblemDescryption = TxbProblemeDescryption.Text;
                        _request.MasterId = (int)CmdMaster.SelectedValue;

                        if ((int)CmdOrderStatus.SelectedValue == 4)
                        {
                            _request.IdStatus = (int)CmdOrderStatus.SelectedValue;
                            _request.ComplectionDate = DateTime.Now;
                        }
                        else
                        {
                            _request.IdStatus = (int)CmdOrderStatus.SelectedValue;
                        }
                        _request.RepairParts = TxbProblemeDescryptionMaster.Text;
                        OdbConnectHelper.databaseconnect.SaveChanges();

                        MessageBox.Show("Статус заявки изменено!",
                            "Системное уведомление",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);

                        this.Close();
                    break;

                    case 4:
                        _request.IdTech = (int)CmdHomeTech.SelectedValue;
                        _request.IdFirmModel = (int)CmdModelTechFactory.SelectedValue;
                        _request.IdColor = (int)CmdTechColor.SelectedValue;
                        _request.ProblemDescryption = TxbProblemeDescryption.Text;
                        OdbConnectHelper.databaseconnect.SaveChanges();

                        MessageBox.Show("Ваша заявка изменена!",
                            "Системное уведомление",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);

                        this.Close();
                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критическая ошибка базы данных! " + ex,
                    "Критическая ошибка | Изменение заявки",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
