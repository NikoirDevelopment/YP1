using RepairEquipment.data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

namespace RepairEquipment.programm.App.Pages.Statistics
{
    /// <summary>
    /// Логика взаимодействия для PagesStatistics.xaml
    /// </summary>
    public partial class PagesStatistics : Page
    {
        private ObservableCollection<Request> completedRequests;

        public PagesStatistics()
        {
            InitializeComponent();
            LoadData();
            LoadStatistics();
        }

        private void LoadData()
        {
            completedRequests = new ObservableCollection<Request>(
                OdbConnectHelper.databaseconnect.Request
                .Where(r => r.IdStatus == 2)
                .ToList()
            );
        }

        /// <summary>
        /// Создание статистики
        /// </summary>
        private void LoadStatistics()
        {
            DtgApplicationHistory.ItemsSource = OdbConnectHelper.databaseconnect.Request.ToList();

            TxtTotal.Text = completedRequests.Count.ToString();

            // Расчёт среднего времени выполнения
            if (completedRequests.Count > 0)
            {
                TimeSpan averageTime = TimeSpan.Zero;
                int validRequests = 0;
                foreach (var request in completedRequests)
                {
                    DateTime? startDate = request.StartDate != null ? (DateTime?)request.StartDate : null;
                    DateTime? complectionDate = request.ComplectionDate != null ? (DateTime?)request.ComplectionDate : null;

                    if (startDate.HasValue && complectionDate.HasValue)
                    {
                        TimeSpan duration = complectionDate.Value - startDate.Value;
                        averageTime += duration;
                        validRequests++;

                        Debug.WriteLine($"ID: {request.Id}, StartDate: {startDate}, ComplectionDate: {complectionDate}, Duration: {duration}");
                    }
                }

                if (validRequests > 0)
                {
                    // Расчёт срелнего времени и дней на заявку
                    double averageDays = averageTime.TotalDays / validRequests;
                    TxtTime.Text = $" {averageDays:F2} дней";
                }
                else
                {
                    TxtTime.Text = "-";
                }
            }
            else
            {
                TxtTime.Text = "-";
            }
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
            LoadStatistics();
        }
    }
}
