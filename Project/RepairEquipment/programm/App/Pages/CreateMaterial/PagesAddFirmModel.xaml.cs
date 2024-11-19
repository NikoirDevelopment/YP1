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

namespace RepairEquipment.programm.App.Pages.CreateMaterial
{
    /// <summary>
    /// Логика взаимодействия для PagesAddFirmModel.xaml
    /// </summary>
    public partial class PagesAddFirmModel : Page
    {
        public PagesAddFirmModel()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            CmbFirmTech.ItemsSource = OdbConnectHelper.databaseconnect.HomeTech.ToList();
            CmbFirmTech.SelectedValuePath = "Id";
            CmbFirmTech.DisplayMemberPath = "Name";
        }

        private void TxbName_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (TxbName.Text != null)
            {
                CmbFirmTech.IsEnabled = true;
            }
            else
            {
                CmbFirmTech.IsEnabled = false;
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = TxbName.Text;

            try
            {
                if (name != null)
                {
                    var checkFirmModel = OdbConnectHelper.databaseconnect.FirmModel.FirstOrDefault(
                        x => x.Name == name);

                    if (checkFirmModel == null)
                    {
                        FirmModel firmModel = new FirmModel
                        {
                            Name = CmbFirmTech.DisplayMemberPath,
                            Model = name,
                        };

                        MessageBoxResult result = MessageBox.Show(
                            "Вы уверены, что хотите добавить: " + name + "?",
                            "Уведомление | Добавление элементов в систему | Добавление модели",
                            MessageBoxButton.YesNo,
                            MessageBoxImage.Warning);

                        if (result == MessageBoxResult.Yes)
                        {
                            OdbConnectHelper.databaseconnect.FirmModel.Add(firmModel);
                            OdbConnectHelper.databaseconnect.SaveChanges();

                            MessageBox.Show(
                                name + " добавлен",
                                "Уведомление | Добавление элементов в систему | Добавление модели",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show(name + " уже занято!",
                            "Системное уведомление | Добавление элементов в систему | Добавление модели",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Проверьте, что поле заполнено верно и не пустое!",
                        "Системное уведомление | Добавление элементов в систему | Добавление модели",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критическая ошибка базы данных! " + ex,
                    "Критическая ошибка | Добавление элементов в систему | Добавление модели",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ControlHelper.programm.frmObj.Navigate(new PagesCreateMaterial());
        }
    }
}
