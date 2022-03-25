using System;
using System.Windows;
using NorthwindBusiness;
using System.Diagnostics;

namespace NorthwindWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CustomerManager _customerManager = new CustomerManager();
        public MainWindow()
        {
            InitializeComponent();
            PopulateListBox();
        }
        private void PopulateListBox()
        {
            ListBoxCustomer.ItemsSource = _customerManager.RetrieveAll();
        }

        private void PopulateCustomerFields()
        {
            if (_customerManager.SelectedCustomer != null)
            {
                TextId.Text = _customerManager.SelectedCustomer.CustomerId;
                TextName.Text = _customerManager.SelectedCustomer.ContactName;
                TextCity.Text = _customerManager.SelectedCustomer.City;
                TextPostalCode.Text = _customerManager.SelectedCustomer.PostalCode;
                TextCountry.Text = _customerManager.SelectedCustomer.Country;
            }
        }

        private void ListBoxCustomer_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ListBoxCustomer.SelectedItem != null)
            {
                _customerManager.SetSelectedCustomer(ListBoxCustomer.SelectedItem);

                Trace.WriteLineIf(ListBoxCustomer.SelectedItem.ToString().Contains("BLOG"), $"BLOG was selected");
                PopulateCustomerFields();
            }
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            _customerManager.Update(customerId: TextId.Text, contactName: TextName.Text, city: TextCity.Text, postcode: TextPostalCode.Text, country: TextCountry.Text);
            ListBoxCustomer.ItemsSource = null;
            // put back the screen data
            PopulateListBox();
            ListBoxCustomer.SelectedItem = _customerManager.SelectedCustomer;
            PopulateCustomerFields();
        }
    }
}
