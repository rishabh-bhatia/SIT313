using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ConferenceSessions.Model;

namespace ConferenceSessions.ViewModel
{
    public class SessionDetailsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // to handle the property change event
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        private Session _session;
        public Session Session
        {
            set { SetProperty(ref _session, value); }
            get { return _session; }
        }

        public void SetData(Session finalSession)
        {
            Session = finalSession;
        }
    }
}
