using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using WinRT;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Storage;
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
        AppWindow appWindow;
        public MainWindow()
        {
            appWindow = GetAppWindow();
            this.InitializeComponent();
        }

        public void ToggleSwitch_Loaded(object sender, RoutedEventArgs e)
        {
            if (ApplicationData.Current.LocalSettings.Values.TryGetValue("themeSetting", out object themeSetting) && (int)themeSetting == 0)
            {
                dark_switch.IsOn = true;
            }
            else
            {
                dark_switch.IsOn = false;
            }
        }

        public void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    if (this.Content is FrameworkElement frameworkElement)
                    {
                        ((FrameworkElement) this.Content).RequestedTheme = ElementTheme.Dark;
                    }
                }
                else
                {
                    if (this.Content is FrameworkElement frameworkElement)
                    {
                        ((FrameworkElement) this.Content).RequestedTheme = ElementTheme.Light;
                    }
                }

            }
            ApplicationData.Current.LocalSettings.Values["themeSetting"] = ((ToggleSwitch)sender).IsOn ? 0 : 1;
        }

        private AppWindow GetAppWindow()
        {
            IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            WindowId myWndId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            return AppWindow.GetFromWindowId(myWndId);
        }

        private void SwtichPresenter_Overlay(object sender, RoutedEventArgs e)
        {
            MenuFlyoutItem dropDownButton = sender as MenuFlyoutItem;
            if (dropDownButton.Name == "CompOverlay")
            {
                appWindow.SetPresenter(AppWindowPresenterKind.CompactOverlay);
            }
            else if (dropDownButton.Name == "Fullscreen")
            {
                appWindow.SetPresenter(AppWindowPresenterKind.FullScreen);
            }
            else
            {
                appWindow.SetPresenter(AppWindowPresenterKind.Default);
            }
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
