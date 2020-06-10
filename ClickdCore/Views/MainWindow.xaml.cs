using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ClickdCore.Views
{
    public class MainWindow : Window
    {

        private bool IsLeftClickChecked {get; set;}

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}