using System;

namespace LayeredMvc.Common
{
    public class Application
    {
        public int Id { get; }
        public int JobId { get; }
        public string ApplicantName { get; }
        public DateTime Date { get; }
        public string CoveringLetter { get; }

        public Application(int id, int jobId, string applicantName, DateTime date, string coveringLetter)
        {
            Id = id;
            JobId = jobId;
            ApplicantName = applicantName;
            Date = date;
            CoveringLetter = coveringLetter;
        }
    }
}
