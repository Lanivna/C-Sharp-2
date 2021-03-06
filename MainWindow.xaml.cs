﻿using System;
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
using FontAwesome.WPF;

namespace C_Sharp_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ImageAwesome _loader;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(ShowResult, ShowLoader);
        }

        private void ShowResult()
        {

            ((MainWindowViewModel) DataContext).FirstName =
                ((MainWindowViewModel) DataContext).FirstName;

            ((MainWindowViewModel) DataContext).LastName =
                ((MainWindowViewModel) DataContext).LastName;

            ((MainWindowViewModel) DataContext).Email = 
                ((MainWindowViewModel) DataContext).Email;

            ((MainWindowViewModel)DataContext).Adult =
                "Adult: " + ((MainWindowViewModel)DataContext).Adult;

            ((MainWindowViewModel) DataContext).SunSign =
                "Your Sun sign is " + ((MainWindowViewModel) DataContext).SunSign;

            ((MainWindowViewModel) DataContext).ChineseSign =
                "You Chinese sign is " + ((MainWindowViewModel) DataContext).ChineseSign;

            ((MainWindowViewModel)DataContext).Birthday =
                "Birthday: " + ((MainWindowViewModel)DataContext).Birthday;
        }

        public void ShowLoader(bool isShow)
        {
            LoaderHelper.OnRequestLoader(MainGrid, ref _loader, isShow);
        }
    }
}
