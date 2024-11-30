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
using System.Xml.Linq;

namespace RepairEquipment.programm.App.Pages.CreateMaterial
{
    /// <summary>
    /// Логика взаимодействия для PagesAddHomeTech.xaml
    /// </summary>
    public partial class PagesAddHomeTech : Page
    {
        public PagesAddHomeTech()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            string name = TxbName.Text;

            try
            {
                if (name != null)
                {
                    var checkHomeTech = OdbConnectHelper.databaseconnect.HomeTech.FirstOrDefault(
                        x => x.Name == name);

                    if (checkHomeTech == null)
                    {
                        HomeTech homeTech = new HomeTech
                        {
                            Name = name
                        };

                        MessageBoxResult result = MessageBox.Show(
                            "Вы уверены, что хотите добавить: " + name + "?",
                            "Уведомление | Добавление элементов в систему | Добавление бытовой техники",
                            MessageBoxButton.YesNo,
                            MessageBoxImage.Warning);

                        if (result == MessageBoxResult.Yes)
                        {
                            OdbConnectHelper.databaseconnect.HomeTech.Add(homeTech);
                            OdbConnectHelper.databaseconnect.SaveChanges();

                            MessageBox.Show(
                                name + " добавлен",
                                "Уведомление | Добавление элементов в систему | Добавление бытовой техники",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);

                            ControlHelper.programm.frmObj.Navigate(new PagesCreateMaterial());
                        }
                    }
                    else
                    {
                        MessageBox.Show(name + " уже занято!",
                            "Системное уведомление | Добавление элементов в систему | Добавление бытовой техники",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Проверьте, что поле заполнено верно и не пустое!",
                        "Системное уведомление | Добавление элементов в систему | Добавление бытовой техники",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критическая ошибка базы данных! " + ex,
                    "Критическая ошибка | Добавление элементов в систему | Добавление бытовой техники",
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
