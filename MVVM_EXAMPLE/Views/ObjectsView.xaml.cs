using MVVM_EXAMPLE.ViewModels;
using System.Windows.Controls;

namespace MVVM_EXAMPLE.Views
{
    /// <summary>
    /// Interaction logic for ToolView.xaml
    /// </summary>
    public partial class ObjectsView
    {
        public ObjectsView()
        {
            InitializeComponent();
            DataContext = new ObjectsViewModel();
        }
    }
}
