using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ConferenceSessionsAPIs.Models;
namespace ConferenceSessionsAPIs.Controllers
{
    [Route("api/[controller]")]
    public class ConferenceSessionsController
    {
        List<Session> sessions = new List<Session>
            (new Session[] {
                new Session{ SessionTitle = "Microsoft", SessionDescription = "Azure!"},
                new Session{ SessionTitle = "Google", SessionDescription = "Android!"},
                new Session{ SessionTitle = "Facebook", SessionDescription = "What'sApp!"},
                new Session{ SessionTitle = "IBM", SessionDescription = "Watson!"}
            });

        [HttpGet] // returns all objects in the list
        public List<Session> GetAll()
        {
            return sessions;
        }

        [HttpGet("{id}")] // returns first object matching the id
        public Session GetSession(string id)
        {
            var session = sessions.FirstOrDefault((p) => p.SessionTitle == id);
            return session;
        }
    }
}
