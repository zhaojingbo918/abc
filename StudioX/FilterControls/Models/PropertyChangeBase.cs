using System;
using System.ComponentModel;

namespace StudioX.FilterControls.Models
{
    [Serializable]
    public class PropertyChangeBase : INotifyPropertyChanged
    {
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}