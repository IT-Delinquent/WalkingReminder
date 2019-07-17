using System.Windows;
using System.Windows.Input;

namespace WalkingReminder
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

        //Event when the user presses the "Fine..." Button - closes form
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        //Event when the user clicks on the border with the left mouse button - moves form
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
