namespace Feasablty_study.Models
{
    public class Rentals
    {
        public int Id { get; set; }

        public string RentQuantity { get; set; }

        public string LeaseType { get; set; }
        public int TechnicalStudyId { get; set; }
        public Technical_Study technical_Study { get; set; }
    }
}
