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
    /// Логика взаимодействия для PagesCreateMaterial.xaml
    /// </summary>
    public partial class PagesCreateMaterial : Page
    {
        public PagesCreateMaterial()
        {
            InitializeComponent();
        }

        private void BtnAddHomeTech_Click(object sender, RoutedEventArgs e)
        {
            ControlHelper.programm.frmObj.Navigate(new PagesAddHomeTech());
        }

        private void BtnAddColor_Click(object sender, RoutedEventArgs e)
        {
            ControlHelper.programm.frmObj.Navigate(new PagesAddColor());
        }

        private void BtnAddFirmHomeModel_Click(object sender, RoutedEventArgs e)
        {
            ControlHelper.programm.frmObj.Navigate(new PagesAddFirmModel());
        }
    }
}
