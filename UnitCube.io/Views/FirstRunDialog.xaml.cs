using System;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UnitCube.io.Views
{
    public sealed partial class FirstRunDialog : ContentDialog
    {
        public FirstRunDialog()
        {
            // TODO: Update content for init dialog
            RequestedTheme = (Window.Current.Content as FrameworkElement).RequestedTheme;
            InitializeComponent();
        }
    }
}
