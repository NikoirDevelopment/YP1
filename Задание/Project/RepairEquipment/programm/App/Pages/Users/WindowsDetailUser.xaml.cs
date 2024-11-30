using RepairEquipment.data;
using RepairEquipment.programm.App.SystemPagesAndWindows;
using RepairEquipment.scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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
    /// Логика взаимодействия для WindowsDeleteUsers.xaml
    /// </summary>
    public partial class WindowsDetailUser : Window
    {
        private User _user;
        public WindowsDetailUser(User user)
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
            BtnSave.IsEnabled = false;

            TxbPassword1.IsEnabled = false;
            StcPassword1.Visibility = Visibility.Collapsed;
            TxbPassword2.IsEnabled = false;
            StcPassword2.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Проверка и загрузка данных
        /// </summary>
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
                TxbPassword1.Text = _user.Password;
                TxbPassword2.Text = _user.Password;
            }
            else
            {
                MessageBox.Show("Критическая ошибка базы данных! Не удалось загрузить данные пользователя",
                    "Критическая ошибка | Профиль пользователя",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Для изменения данных требуется ввести пароль менеджера! После ввода пароля, будет доступно " +
                                            "редактирование данных пользователя, а также виден пароль пользователя. Продолжить?",
                                            "Системное уведомление | Проверка доступа",
                                            MessageBoxButton.YesNo,
                                            MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                WindowsCheckPasswordRoot windowsCheckPasswordRoot = new WindowsCheckPasswordRoot(this);
                windowsCheckPasswordRoot.Show();
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if ((TxbUser.Text != _user.Login) || ((int)CmdRole.SelectedValue != _user.IdRole) || (TxbName.Text != _user.Name) || (TxbSurname.Text != _user.Surname) || (TxbMiddlename.Text != _user.Patronymic)
                || (Convert.ToInt64(TxbPhone.Text) != (_user.Phone)) || (TxbPassword2.Text != _user.Password))
            {
                MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите изменить данные?",
                   "Системное уведомление | Профиль пользователя",
                   MessageBoxButton.YesNo,
                   MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    // Создание отдельного подключения бащы данных
                    using (var OdbContext = new OdbYP1Entities())
                    {
                        try
                        {
                            var userToUpdate = OdbContext.User.FirstOrDefault(x => x.id == _user.id);

                            if (userToUpdate != null)
                            {
                                userToUpdate.Login = TxbUser.Text;
                                userToUpdate.IdRole = (int)CmdRole.SelectedValue;
                                userToUpdate.Name = TxbName.Text;
                                userToUpdate.Surname = TxbSurname.Text;
                                userToUpdate.Patronymic = TxbMiddlename.Text;
                                userToUpdate.Phone = Convert.ToInt64(TxbPhone.Text);
                                userToUpdate.Password = TxbPassword2.Text;

                                OdbContext.SaveChanges();

                                MessageBox.Show("Данные пользователя изменены!",
                                    "Системное уведомление | Профиль пользователя",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Произошла неизвестная ошибка при попытке сохранить данные пользователя!",
                                    "Системное уведомление | Профиль пользователя",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка базы данных: {ex.Message}\n{ex.StackTrace}",
                                "Критическая ошибка | Профиль пользователя",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
                        }
                    }
                }
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите закрыть подробную информацию?",
                "Системное уведомление | Профиль пользователя",
                MessageBoxButton.YesNo,
                MessageBoxImage.Information);

            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Вы вышли из системы!",
                    "Системное уведомление | Профиль пользователя",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                this.Close();
            }
        }
    }
}