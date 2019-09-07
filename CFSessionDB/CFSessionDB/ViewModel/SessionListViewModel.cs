using CFSessionDB.Data;
using CFSessionDB.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace CFSessionDB.ViewModel
{
    public class SessionListViewModel : INotifyPropertyChanged
    {
        //this is the database object (described in step 3)
        Database _database = new Database();

        //Triggered When new session is added to database
        public event PropertyChangedEventHandler PropertyChanged;

        //the list to load/save data from/to database
        private ObservableCollection<Session> _sessionsList;

        public ObservableCollection<Session> SessionsList
        {
            get { return _sessionsList; }
            set
            {
                _sessionsList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SessionsList"));
            }
        }

        public async Task FetchDataAsync()
        {
            var list = await _database.GetAllSessionAsync();
            SessionsList = new ObservableCollection<Session>(list);
        }

        //load data from database at the beginning
        public SessionListViewModel()
        {
            FetchDataAsync();
        }
    }
}
