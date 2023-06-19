﻿using System.ComponentModel.DataAnnotations;

namespace Meeting_Manegment_System.Models
{
    public class Meeting
    {
        [Key]
        public int MeetingId { get; set; }
        public int CommitteeId { get; set; }
        public string Goal { get; set; }
        public bool Emergency { get; set; }
        public DateTime Date { get; set;}= DateTime.Now;
        public int DocumentId { get; set; }
        public WordDocument WordDocument { get; set; }
        public Committee Committee { get; set; }
        public List<Voting> Votings { get; set; }
        public List<MemberAnswers> MemberAnswers { get; set; }
        public List<MemberMeeting> memberMeetings { get; set; }

    }
    
}
