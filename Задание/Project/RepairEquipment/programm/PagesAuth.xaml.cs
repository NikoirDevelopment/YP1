using RepairEquipment.data;
using RepairEquipment.programm.App;
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

namespace RepairEquipment.programm
{
    /// <summary>
    /// Логика взаимодействия для PageAuth.xaml
    /// </summary>
    public partial class PageAuth : Page
    {
        public PageAuth()
        {
            InitializeComponent();
            CheckSaveLogin();
        }

        /// <summary>
        /// Проверка на заполненого
        /// </summary>
        private void CheckSaveLogin()
        {
            if (Properties.Settings.Default.SaveLogin != String.Empty)
            {
                TxbUser.Text = Properties.Settings.Default.SaveLogin;
                ChbSave.IsChecked = true;
            }
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            CheckData();
        }

        /// <summary>
        /// Проверка пользователя
        /// </summary>
        private void CheckData()
        {
            string login = TxbUser.Text;
            string password = TxbPassword.Password;

            try
            {
                if (TxbUser.Text != null || TxbPassword.Password != null)
                {
                    var checkUser = OdbConnectHelper.databaseconnect.User.FirstOrDefault(
                            x => String.Compare(x.Login, login, StringComparison.InvariantCulture) == 0 &&
                            String.Compare(x.Password, password, StringComparison.InvariantCulture) == 0);

                    if (checkUser != null)
                    {
                        BufferUser.Id = checkUser.id;
                        BufferUser.Name = checkUser.Name;
                        BufferUser.Surname = checkUser.Surname;
                        BufferUser.Middlename = checkUser.Patronymic;
                        BufferUser.Role = checkUser.IdRole;

                        MessageBox.Show("Добро пожаловать " + BufferUser.Surname + " " + BufferUser.Name + " " + BufferUser.Middlename + "!",
                            "Системное уведомление | Авторизация",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);

                        RememberMe();

                        AppRepairEquipment appRepairEquipment = new AppRepairEquipment();
                        appRepairEquipment.Show();

                        Application.Current.MainWindow.Close();
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден! Убедитесь, что логин и пароль совпадают.",
                            "Системное уведомление | Авторизация",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Одно или несколько полей заполнено не верно, убедитесь, что они не пустые",
                        "Системное уведомление | Авторизация",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критическая ошибка базы данных! " + ex,
                    "Критическая ошибка | Авторизация",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Запомнить логин пользователя
        /// </summary>
        private void RememberMe()
        {
            if (ChbSave.IsChecked == true)
            {
                Properties.Settings.Default.SaveLogin = TxbUser.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.SaveLogin = null;
                Properties.Settings.Default.Save();
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            ControlHelper.main.frmObj.Navigate(new PagesReg());
        }
    }
}
