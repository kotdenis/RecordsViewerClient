using RecordsViewerClient.Controls;
using RecordsViewerClient.ViewHelpModels;
using RecordsViewerClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using Unity;

namespace RecordsViewerClient
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var container = new UnityContainer();
            container.RegisterType<IViews, ViewMain>();
            container.RegisterType<IMessageSender, MessageSender>();
            container.RegisterType<IPhotoes, Photoes>();
            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
