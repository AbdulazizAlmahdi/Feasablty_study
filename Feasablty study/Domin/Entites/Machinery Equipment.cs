using Feasablty_study.Domin.Interfaces;

namespace Feasablty_study.Models
{
    public class Machinery_Equipment : IEntityBase
    {
        public int Id { get; set; }

        public string NameEquipment { get; set; }

        public int Number { get; set; }
        public float Price { get; set; }
        public float TotleAll { get; set; }
        public int TechnicalStudyId { get; set; }
        public Technical_Study technical_Study { get; set; }
    }
}
