using MVVM_EXAMPLE.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace MVVM_EXAMPLE.ViewModels
{
    public class ObjectsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ObjectViewModel> Objects { get; set; }

        public ObjectsViewModel()
        {
            Objects = new ObservableCollection<ObjectViewModel>();
            LoadToolsAsync();
        }

        private async void LoadToolsAsync()
        {
            Objects.Add(new ObjectViewModel(new ObjectModel { Id = 1, Name = "Object 1" }));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
