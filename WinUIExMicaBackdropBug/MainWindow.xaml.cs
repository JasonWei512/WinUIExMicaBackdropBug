using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinUIEx;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUIExMicaBackdropBug
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : WindowEx
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private async void bugButton_Click(object sender, RoutedEventArgs e)
        {
            App.MainWindow.Close();
            await Task.Delay(TimeSpan.FromSeconds(1));
            App.MainWindow.Show();
        }

        private async void workaroundButton_Click(object sender, RoutedEventArgs e)
        {
            App.MainWindow.Close();
            await Task.Delay(TimeSpan.FromSeconds(1));
            App.MainWindow.Show();
            App.MainWindow.Backdrop = new MicaSystemBackdrop();
        }
    }
}
