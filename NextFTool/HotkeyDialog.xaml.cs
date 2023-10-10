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
using System.Windows.Shapes;

namespace NextFTool
{
    /// <summary>
    /// Interaction logic for HotkeyDialog.xaml
    /// </summary>
    public partial class HotkeyDialog : Window
    {
        MainWindow mainWindow = null;
        public string index;

        public HotkeyDialog(string index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.closeHotkeyDialog();
            Close();            
        }

        private void Confirm_Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.closeHotkeyDialog();
            Close();
        }

        private void HotkeyDialog_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) { DragMove(); }
        }
    }
}
