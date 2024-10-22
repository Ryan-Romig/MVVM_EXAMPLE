using MVVM_EXAMPLE.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM_EXAMPLE.ViewModels
{

    public class ObjectViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ObjectViewModel(ObjectModel obj)
        {
            Id = obj.Id;
            Name = obj.Name;
        }
    }
}
