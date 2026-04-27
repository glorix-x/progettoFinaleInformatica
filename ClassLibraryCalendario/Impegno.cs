namespace ClassLibraryCalendario {
    public class Impegno {
        private string title;
        private string description;
        private DateTime deadline;
        private DateTime scheduledDate;

        public Impegno(string title, string description, DateTime deadline, DateTime scheduledDate) {
            this.title = title;
            this.description = description;
            this.deadline = deadline;
            this.scheduledDate = scheduledDate;
        }

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public DateTime ScheduledDate { get => scheduledDate; set => scheduledDate = value; }
    }
}
