using CFSessionDB.Model;
using MarcTron.Plugin;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CFSessionDB.Data
{
    public class Database
    {
        //this is the connection to the database
        public SQLiteAsyncConnection CF_database { get; private set; }

        public Database()
        {
            //set up the connection to a new or existing database
            CF_database = MtSql.Current.GetConnectionAsync("w6lab.db");
            //Create table if not exists
            CF_database.CreateTableAsync<Session>().Wait();
            //insert some dummy data for testing
            CF_database.InsertAsync(new Session { SessionTitle = "Microsoft", SessionDescription = "Azure!" });
            CF_database.InsertAsync(new Session { SessionTitle = "Google", SessionDescription = "Android!" });
            CF_database.InsertAsync(new Session { SessionTitle = "Facebook", SessionDescription = "What's App!" });
        }

        public async Task<List<Session>> GetAllSessionAsync()
        {
            return await CF_database.Table<Session>().ToListAsync();
        }

        public async Task AddSessionsAsync(Session newSession)
        {
            await CF_database.InsertAsync(newSession);
        }
    }
}
