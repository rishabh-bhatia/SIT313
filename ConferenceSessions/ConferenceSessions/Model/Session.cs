using System;
namespace ConferenceSessions.Model
{
    public class Session
    {
        public string SessionTitle { get; set; }
        public string SessionSpeaker { get; set; }
        public string IsTechnical { get; set; }
        public string SessionDescription { get; set; }

        public Session()
        {
        }
    }
}
