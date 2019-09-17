using Prism.Regions;
using System.Windows;
using System.Windows.Controls;
using TicTacToe.Views;

namespace TicTacToe.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            regionManager.RegisterViewWithRegion("FileMenu", typeof(FileMenu));
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(GameField));
        }
    }
}
