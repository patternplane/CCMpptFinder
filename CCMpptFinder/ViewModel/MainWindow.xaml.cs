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


namespace CCMpptFinder
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        String[] PptFiles;

        public MainWindow()
        {
            //Search.test();
            //Powerpoint pptClass = new Powerpoint();
            //pptClass.test();

            InitializeComponent();

            //SlideShowControler showview = new SlideShowControler();
            //showview.Show();
            //SlideShowControler showview2 = new SlideShowControler();
            //showview2.Show();
        }
    }
}
