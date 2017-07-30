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

namespace MonitorModeSwitcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void All_Enabled(object sender, RoutedEventArgs e)
        {
            MonitorChanger.AlterMonitor(int.Parse(Properties.Resources.Primary), MonitorChanger.MonitorActions.EnableMonitor);
            MonitorChanger.AlterMonitor(int.Parse(Properties.Resources.Secondary), MonitorChanger.MonitorActions.EnableMonitor);
            MonitorChanger.AlterMonitor(int.Parse(Properties.Resources.TV), MonitorChanger.MonitorActions.EnableMonitor);
            MonitorChanger.AlterMonitor(int.Parse(Properties.Resources.Primary), MonitorChanger.MonitorActions.SetPrimaryMonitor);
        }

        private void Desktop_Mode(object sender, RoutedEventArgs e)
        {
            MonitorChanger.AlterMonitor(int.Parse(Properties.Resources.Primary), MonitorChanger.MonitorActions.EnableMonitor);
            MonitorChanger.AlterMonitor(int.Parse(Properties.Resources.Secondary), MonitorChanger.MonitorActions.EnableMonitor);
            MonitorChanger.AlterMonitor(int.Parse(Properties.Resources.Primary), MonitorChanger.MonitorActions.SetPrimaryMonitor);
            MonitorChanger.AlterMonitor(int.Parse(Properties.Resources.TV), MonitorChanger.MonitorActions.DisableMonitor);
        }

        private void Game_Mode(object sender, RoutedEventArgs e)
        {
            MonitorChanger.AlterMonitor(int.Parse(Properties.Resources.Primary), MonitorChanger.MonitorActions.EnableMonitor);
            MonitorChanger.AlterMonitor(int.Parse(Properties.Resources.Primary), MonitorChanger.MonitorActions.SetPrimaryMonitor);
            MonitorChanger.AlterMonitor(int.Parse(Properties.Resources.Secondary), MonitorChanger.MonitorActions.DisableMonitor);
            MonitorChanger.AlterMonitor(int.Parse(Properties.Resources.TV), MonitorChanger.MonitorActions.DisableMonitor);
        }

        private void TV_Mode(object sender, RoutedEventArgs e)
        {
            MonitorChanger.AlterMonitor(int.Parse(Properties.Resources.TV), MonitorChanger.MonitorActions.EnableMonitor);
            MonitorChanger.AlterMonitor(int.Parse(Properties.Resources.TV), MonitorChanger.MonitorActions.SetPrimaryMonitor);
            MonitorChanger.AlterMonitor(int.Parse(Properties.Resources.Primary), MonitorChanger.MonitorActions.DisableMonitor);
            MonitorChanger.AlterMonitor(int.Parse(Properties.Resources.Secondary), MonitorChanger.MonitorActions.DisableMonitor);
        }
    }
}
