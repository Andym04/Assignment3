using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assignment3
{
    public partial class EditWindow : Window
    {
        public Person UpdatedPerson { get; private set; }

        public EditWindow(Person currentPerson)
        {
            InitializeComponent();

            // Populate form controls
            txtFirstName.Text = currentPerson.FirstName;
            txtLastName.Text = currentPerson.LastName;
            txtAge.Text = currentPerson.Age.ToString();

            UpdatedPerson = new Person(currentPerson.FirstName, currentPerson.LastName, currentPerson.Age);
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            // Validate Age input
            if (!int.TryParse(txtAge.Text, out int age) || age < 0)
            {
                MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtAge.Focus();
                return;
            }

            // Save updated fields
            UpdatedPerson.FirstName = txtFirstName.Text.Trim();
            UpdatedPerson.LastName = txtLastName.Text.Trim();
            UpdatedPerson.Age = age;

            DialogResult = true; // Closes window and returns true to caller
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false; // Closes window without keeping changes
        }
    }
}