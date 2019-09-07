using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ConferenceSessions.Model;
using ConferenceSessions.View;
using Xamarin.Forms;

namespace ConferenceSessions.ViewModel
{
    public class SessionListViewModel : INotifyPropertyChanged
    {
        // for implementing INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private INavigation _navigation; //for navigation stack
        public List<Session> Sessions { get; set; }//information about all sessions
        private Session _sessionSelected;//selected session
        public Session SessionSelected
        {
            get { return _sessionSelected; }
            set
            {
                if (_sessionSelected != value)
                {
                    _sessionSelected = value;
                    if (_sessionSelected != null)
                    {   //create new page with detailed information
                        _navigation.PushAsync(new SessionDetailsPage(_sessionSelected));
                    }
                }
            }
        }

        public SessionListViewModel(INavigation navigation)
        {
            _navigation = navigation;
            Sessions = new List<Session>(SessionData.Get());
        }
        //handle the event when property changes
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

