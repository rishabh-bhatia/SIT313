using System;
using System.Collections.Generic;

namespace ConferenceSessions.Model
{
    public class SessionData
    {
        public static IEnumerable<Session> Get()
        {
            return new List<Session>()
            {
                new Session(){ SessionTitle = "Big Data", SessionSpeaker = "Speaker 1", IsTechnical = "Yes", SessionDescription = "Spearker 1 is ..."},
                new Session(){ SessionTitle = "Small Data", SessionSpeaker = "Speaker 2", IsTechnical = "Yes", SessionDescription = "Spearker 2 is ..."},
                new Session(){ SessionTitle = "IT Skills", SessionSpeaker = "Speaker 3", IsTechnical = "Yes", SessionDescription = "Spearker 3 is ..."},
                new Session(){ SessionTitle = "Xamarin", SessionSpeaker = "Speaker 4", IsTechnical = "Yes", SessionDescription = "Spearker 4 is ..."},
                new Session(){ SessionTitle = "Software Engineering", SessionSpeaker = "Speaker 5", IsTechnical = "No", SessionDescription = "Spearker 5 is ..."},
                new Session(){ SessionTitle = "Research Methods", SessionSpeaker = "Speaker 6", IsTechnical = "No", SessionDescription = "Spearker 6 is ..."},
                new Session(){ SessionTitle = "Algorithms", SessionSpeaker = "Speaker 7", IsTechnical = "No", SessionDescription = "Spearker 7 is ..."},
            };
        }
        public SessionData()
        {
        }
    }
}
