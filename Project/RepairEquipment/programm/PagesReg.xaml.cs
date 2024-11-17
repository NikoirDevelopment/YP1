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

namespace RepairEquipment.programm
{
    /// <summary>
    /// Логика взаимодействия для PagesReg.xaml
    /// </summary>
    public partial class PagesReg : Page
    {
        public PagesReg()
        {
            InitializeComponent();
            LoadSystem();
        }

        private void LoadSystem()
        {
            TxbUser.IsEnabled = true;
            TxbName.IsEnabled = false;
            TxbSurname.IsEnabled = false;
            TxbMiddlename.IsEnabled = false;
            TxbPhone.IsEnabled = false;
            TxbPassword1.IsEnabled = false;
            TxbPassword2.IsEnabled = false;
        }

        private void TxbUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxbUser.Text.Length > 0)
            {
                TxbName.IsEnabled = true;
            }
            else
            {
                TxbName.IsEnabled = false;
                TxbName.Text = null;
            }
        }

        private void TxbName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxbName.Text.Length > 0)
            {
                TxbSurname.IsEnabled = true;
            }
            else
            {
                TxbSurname.IsEnabled = false;
                TxbSurname.Text = null;
            }
        }

        private void TxbSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxbSurname.Text.Length > 0)
            {
                TxbMiddlename.IsEnabled = true;
            }
            else
            {
                TxbMiddlename.IsEnabled = false;
                TxbMiddlename.Text = null;
            }
        }

        private void TxbMiddlename_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxbMiddlename.Text.Length > 0)
            {
                TxbPhone.IsEnabled = true;
            }
            else
            {
                TxbPhone.IsEnabled = false;
                TxbPhone.Text = null;
            }
        }

        private void TxbPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxbPhone.Text.Length > 0)
            {
                TxbPassword1.IsEnabled = true;
                TxbPassword2.IsEnabled = true;
            }
            else
            {
                TxbPassword1.IsEnabled = false;
                TxbPassword1.Password = null;
                TxbPassword2.IsEnabled = false;
                TxbPassword2.Password = null;
            }
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            CreateData();
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            ControlHelper.main.frmObj.GoBack();
        }

        /// <summary>
        /// Создание пользователя
        /// </summary>
        private void CreateData()
        {
            if (TxbUser.Text != null && TxbName.Text != null && TxbSurname.Text != null && TxbMiddlename.Text != null
                    && TxbPhone.Text != null && TxbPassword1.Password != null && TxbPassword2.Password != null)
            {
                if (TxbPassword1.Password == TxbPassword2.Password)
                {
                    try
                    {
                        string login = TxbUser.Text;
                        string password = TxbPassword2.Password;

                        var checkUser = OdbConnectHelper.databaseconnect.User.FirstOrDefault(
                            x => String.Compare(x.Login, login, StringComparison.InvariantCulture) == 0);

                        if (checkUser == null)
                        {
                            User userObj = new User()
                            {
                                Surname = TxbSurname.Text,
                                Name = TxbName.Text,
                                Patronymic = TxbMiddlename.Text,
                                Phone = Convert.ToInt64(TxbPhone.Text),
                                Login = login,
                                Password = password,
                                IdRole = 4
                            };
                            OdbConnectHelper.databaseconnect.User.Add(userObj);
                            OdbConnectHelper.databaseconnect.SaveChanges();

                            MessageBox.Show("Пользователь " + login + " создан!",
                                "Системное уведомление | Регистрация",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);

                            ControlHelper.main.frmObj.GoBack();
                        }
                        else
                        {
                            MessageBox.Show("Логин уже занят!",
                                "Системное уведомление | Регистрация",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Критическая ошибка базы данных! " + ex,
                            "Критическая ошибка | Регистрация",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!",
                        "Системное уведомление | Регистрация",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Одно или несколько полей заполнены не верно или пусты!",
                    "Системное уведомление | Регистрация",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }
    }
}