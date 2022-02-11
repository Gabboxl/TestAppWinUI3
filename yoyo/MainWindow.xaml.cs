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

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace yoyo
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();


            myButton.Click += new RoutedEventHandler(async void (object sender, RoutedEventArgs e) => {

                // Call app specific code to subscribe to the service. For example:
                ContentDialog subscribeDialog = new ContentDialog
                {
                    Title = "Esperienza?",
                    Content = "Salve come va",
                    CloseButtonText = "No",
                    PrimaryButtonText = "Okay",
                    SecondaryButtonText = "forse",
                    DefaultButton = ContentDialogButton.Primary,

                };

                //fix altrimenti non si vede il dialog perchè non è fissato ad alcun layout radice xaml
                subscribeDialog.XamlRoot = this.Content.XamlRoot;
                ContentDialogResult result = await subscribeDialog.ShowAsync();

            });
        }


    }
}
