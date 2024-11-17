using RepairEquipment.data;
using RepairEquipment.programm.App.Pages;
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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace RepairEquipment.programm.App.SystemPagesAndWindows
{
    /// <summary>
    /// Логика взаимодействия для WindowsCheckPasswordRoot.xaml
    /// </summary>
    public partial class WindowsCheckPasswordRoot : Window
    {

        private WindowsDetailUser _windowsDetailUser;
        public WindowsCheckPasswordRoot(WindowsDetailUser windowsDetailUser)
        {
            InitializeComponent();
            LoadData(windowsDetailUser);
        }

        private void LoadData(WindowsDetailUser windowsDetailUser)
        {
            OdbConnectHelper.databaseconnect = new OdbYP1Entities();

            _windowsDetailUser = windowsDetailUser;
        }

        private void BtnCheckPassword_Click(object sender, RoutedEventArgs e)
        {
            string password = PabCheckPassword.Password;

            if (password != null)
            {
                var checkPassword = OdbConnectHelper.databaseconnect.User.FirstOrDefault(
                    x => x.Password == password && x.IdRole == 1);

                if (checkPassword != null)
                {
                    MessageBox.Show("Получен ключ доступа!",
                        "Системное уведомление | Проверка доступа",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);

                    LoadTrueSystem();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не верный пароль!",
                        "Системное уведомление | Проверка доступа",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Поле пустое!",
                    "Системное уведомление | Проверка доступа",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }

        /// <summary>
        /// Изменение параметров окна
        /// </summary>
        private void LoadTrueSystem()
        {
            _windowsDetailUser.TxbUser.IsEnabled = true;
            _windowsDetailUser.CmdRole.IsEnabled = true;
            _windowsDetailUser.TxbName.IsEnabled = true;
            _windowsDetailUser.TxbSurname.IsEnabled = true;
            _windowsDetailUser.TxbMiddlename.IsEnabled = true;
            _windowsDetailUser.TxbPhone.IsEnabled = true;
            _windowsDetailUser.TxbPassword1.IsEnabled = true;
            _windowsDetailUser.StcPassword1.Visibility = Visibility.Visible;
            _windowsDetailUser.TxbPassword2.IsEnabled = true;
            _windowsDetailUser.StcPassword2.Visibility = Visibility.Visible;
            _windowsDetailUser.BtnSave.IsEnabled = true;

            _windowsDetailUser.TxbOdbPassword1.IsEnabled = false;
            _windowsDetailUser.StcOdbPassword1.Visibility = Visibility.Collapsed;
            _windowsDetailUser.TxbOdbPassword2.IsEnabled = false;
            _windowsDetailUser.StcOdbPassword2.Visibility = Visibility.Collapsed;
        }
    }
}
