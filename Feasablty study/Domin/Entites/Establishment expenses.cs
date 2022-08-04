using Feasablty_study.Domin.Interfaces;

namespace Feasablty_study.Models
{
    public class Establishment_expenses : IEntityBase
    {
        public int Id { get; set; }

        public string TypeOfExpense { get; set; }
        public string PriceOfExpens { get; set; }
        public int TechnicalStudyId { get; set; }
        public Technical_Study technical_Study { get; set; }
    }
}
