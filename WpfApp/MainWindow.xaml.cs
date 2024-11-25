﻿using System.Windows;
using WpfApp.MVVM.ViewModel;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _mainViewModel;

        public MainWindow()
        {
            InitializeComponent();

            _mainViewModel = new MainViewModel();
            DataContext = _mainViewModel;
        }
    }
}