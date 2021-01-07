namespace WebsiteClasses.Core
{

    public class Projects
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDesc { get; set; }
        public ProjectType PType { get; set; }

        public Projects()
        {
        }
    }
}
