namespace Feasablty_study.Models
{
    public class License
    {
        public int Id { get; set; }
        public string LicenseType { get; set; }
        public string Licenses { get; set; }
        public int PreliminaryStudyId { get; set; }
        public Preliminary_study preliminary_Study { get; set; }
    }
}
