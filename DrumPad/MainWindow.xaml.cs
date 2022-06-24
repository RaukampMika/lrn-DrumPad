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
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Media;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DrumPad
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        #region Event handlers buttons

        public void pad1_clicked(object sender, RoutedEventArgs e)
        {
            _ = new Sound("rim.wav");
        }

        private void pad2_clicked(object sender, RoutedEventArgs e)
        {
            _ = new Sound("crash.wav");
        }
        private void pad3_clicked(object sender, RoutedEventArgs e)
        {
            _ = new Sound("elec1.wav");
        }
        private void pad4_clicked(object sender, RoutedEventArgs e)
        {
            _ = new Sound("high_snare.wav");
        }
        private void pad5_clicked(object sender, RoutedEventArgs e)
        {
            _ = new Sound("high_snare2.wav");
        }
        private void pad6_clicked(object sender, RoutedEventArgs e)
        {
            _ = new Sound("kick.wav");
        }
        private void pad7_clicked(object sender, RoutedEventArgs e)
        {
            _ = new Sound("snare.wav");
        }
        private void pad8_clicked(object sender, RoutedEventArgs e)
        {
            _ = new Sound("tom.wav");
        }
        private void pad9_clicked(object sender, RoutedEventArgs e)
        {
            _ = new Sound("trash.wav");
        }
        private void pad10_clicked(object sender, RoutedEventArgs e)
        {
            _ = new Sound("clip1.wav");
        }
        private void pad11_clicked(object sender, RoutedEventArgs e)
        {
            _ = new Sound("clip2.wav");
        }
        private void pad12_clicked(object sender, RoutedEventArgs e)
        {
            _ = new Sound("clip3.wav");
        }
        private void pad13_clicked(object sender, RoutedEventArgs e)
        {
            _ = new Sound("clip4.wav");
        }
        private void pad14_clicked(object sender, RoutedEventArgs e)
        {
            _ = new Sound("clip5.wav");
        }
        private void pad15_clicked(object sender, RoutedEventArgs e)
        {
            _ = new Sound("clip6.wav");
        }
        private void pad16_clicked(object sender, RoutedEventArgs e)
        {
            _ = new Sound("clip7.wav");
        }
        #endregion
    }
}
