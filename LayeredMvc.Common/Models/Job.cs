namespace LayeredMvc.Common
{
    public class Job
    {
        public int Id { get; }
        public string Title { get; }
        public string Description { get; }
        public string Location { get; }
        public int Salary { get; }
        public int Applications { get; set; }

        public Job(int id, string title, string description, string location, int salary)
        {
            Id = id;
            Title = title;
            Description = description;
            Location = location;
            Salary = salary;
            Applications = 0;
        }
    }
}
