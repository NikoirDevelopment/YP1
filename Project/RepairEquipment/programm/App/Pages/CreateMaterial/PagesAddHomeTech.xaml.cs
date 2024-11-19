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
                    HomeTech homeTech = new HomeTech
                    {
                        Name = name
                    };

                    OdbConnectHelper.databaseconnect.HomeTech.Add(homeTech);
                    OdbConnectHelper.databaseconnect.SaveChanges();

                    MessageBoxResult result = MessageBox.Show(
                        "Вы уверены, что хотите добавить: " + name,
                        "Уведомление | Добавление элементов в систему | Добавление бытовой техники",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Warning);
                }
                else
                {
                    MessageBox.Show("Критическая ошибка базы данных! ",
                    "Критическая ошибка | Добавление элементов в систему | Добавление бытовой техники",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
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
