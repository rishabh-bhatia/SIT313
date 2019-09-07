using ConferenceSessions.ViewModel;
using Xamarin.Forms;

namespace ConferenceSessions.View
{
    public partial class SessionListPage : ContentPage
    {
        public SessionListPage()
        {
            InitializeComponent();
            BindingContext = new SessionListViewModel(Navigation);
        }
    }
}
