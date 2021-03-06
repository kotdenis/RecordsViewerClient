﻿using RecordsViewerClient.ViewHelpModels;
using RecordsViewerClient.ViewModels;
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
using Unity;

namespace RecordsViewerClient.Controls
{
    /// <summary>
    /// Логика взаимодействия для ConnectionControl.xaml
    /// </summary>
    public partial class ConnectionControl : UserControl, IViews
    {
        [Dependency]
        public IViews views
        {
            set { DataContext = value; }
        }
        
        public ConnectionControl()
        {
            InitializeComponent();
        }
    }
}
