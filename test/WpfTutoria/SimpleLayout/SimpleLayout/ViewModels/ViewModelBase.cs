using System.ComponentModel;

namespace SimpleLayout.ViewModels
{
    public class ViewModelBase: INotifyPropertyChanging
    {
        public event PropertyChangingEventHandler? PropertyChanging;

        public void OnPropertyChanged(string propertyName)
            => PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));

    }
}
