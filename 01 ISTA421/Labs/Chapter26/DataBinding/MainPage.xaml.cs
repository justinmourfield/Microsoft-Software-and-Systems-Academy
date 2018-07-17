﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Customers
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Customer customer = new Customer
            {
                CustomerID = 1,
                Title = "Mr",
                FirstName = "John",
                LastName = "Sharp",
                EmailAddress = "john@contoso.com",
                Phone = "111-1111"
            };
            List<string> titles = new List<string>
            {
                "Mr",
                "Mrs",
                "Ms",
                "Miss"
            };
            this.title.ItemsSource = titles;
            this.cTitle.ItemsSource = titles;

            this.DataContext = customer;           
        }
    }
}