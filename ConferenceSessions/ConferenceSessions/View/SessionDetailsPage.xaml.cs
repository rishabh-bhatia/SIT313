using Xamarin.Forms;
using ConferenceSessions.ViewModel;
using ConferenceSessions.Model;

namespace ConferenceSessions.View
{
    public partial class SessionDetailsPage : ContentPage
    {
        public SessionDetailsViewModel ViewModel { get; }

        public SessionDetailsPage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new SessionDetailsViewModel();
            ViewModel.SetData(new Session());
        }

        public SessionDetailsPage(Session session)
        {
            InitializeComponent();
            BindingContext = ViewModel = new SessionDetailsViewModel();
            ViewModel.SetData(session);
        }
    }
}
