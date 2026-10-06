using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment3
{
    public partial class MainWindow : Window
    {
        private Person _person;

        public MainWindow()
        {
            InitializeComponent();

            // Initialize sample data
            _person = new Person("John", "Doe", 35);
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            lblFullName.Content = _person.FullName;
            lblAge.Content = _person.Age.ToString();
            chkIsAdult.IsChecked = _person.IsAdult;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            // Pass a copy or current values to the edit window
            EditWindow editWin = new EditWindow(_person);
            editWin.Owner = this;

            // Show modal dialog
            if (editWin.ShowDialog() == true)
            {
                // Update main window state if user clicked OK
                _person = editWin.UpdatedPerson;
                UpdateDisplay();
            }
        }
    }
}