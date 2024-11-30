using RepairEquipment.data;
using RepairEquipment.programm.App.SystemPagesAndWindows;
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

namespace RepairEquipment.programm.App.Pages.Users
{
    /// <summary>
    /// Логика взаимодействия для WindowsDeleteUser.xaml
    /// </summary>
    public partial class WindowsDeleteUser : Window
    {
        private User _user;
        public WindowsDeleteUser(User user)
        {
            InitializeComponent();
            LoadSystem();
            LoadData(user);
        }

        private void LoadSystem()
        {
            TxbUser.IsEnabled = false;
            CmdRole.IsEnabled = false;
            TxbName.IsEnabled = false;
            TxbSurname.IsEnabled = false;
            TxbMiddlename.IsEnabled = false;
            TxbPhone.IsEnabled = false;
            TxbOdbPassword1.IsEnabled = false;
            TxbOdbPassword2.IsEnabled = false;
        }

        private void LoadData(User user)
        {
            var checkUser = OdbConnectHelper.databaseconnect.User.FirstOrDefault(
                x => x.id == user.id);

            _user = checkUser;

            if (_user != null)
            {
                this.Title = "Профиль пользователя: | " + _user.Surname + " " + _user.Name + " " + _user.Patronymic;
                TxbSurnameNameMiddlename.Text = _user.Surname + " " + _user.Name + " " + _user.Patronymic;

                TxbUser.Text = _user.Login;

                CmdRole.ItemsSource = OdbConnectHelper.databaseconnect.Role.ToList();
                CmdRole.SelectedValue = _user.IdRole;
                CmdRole.SelectedValuePath = "Id";
                CmdRole.DisplayMemberPath = "Name";

                TxbName.Text = _user.Name;
                TxbSurname.Text = _user.Surname;
                TxbMiddlename.Text = _user.Patronymic;
                TxbPhone.Text = Convert.ToString(_user.Phone);
                TxbOdbPassword1.Password = _user.Password;
                TxbOdbPassword2.Password = _user.Password;
            }
            else
            {
                MessageBox.Show("Критическая ошибка базы данных! Не удалось загрузить данные пользователя",
                    "Критическая ошибка | Удаление пользователя",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены. что хотите удалить пользователя?",
                                            "Системное уведомление | Удаление пользователя",
                                            MessageBoxButton.YesNo,
                                            MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                OdbConnectHelper.databaseconnect.User.Remove(_user);
                OdbConnectHelper.databaseconnect.SaveChanges();

                MessageBox.Show("Пользователь " + _user.Surname + " " + _user.Name + " " + _user.Patronymic + " удалён!",
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
