using Feasablty_study.Domin.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Machinery_Equipment : IEntityBase
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string NameSupplier { get; set; }

        public int Number { get; set; }
        public float Price { get; set; }
        public float TotalPrice {
            get { return Price*Number; }
            set
            {
                value = Number * Price;
            }
                }

        [ForeignKey("Feasibility_study")]
        public virtual int Feasibility_StudyId { get; set; }
        public virtual Feasibility_study Feasibility_Study { get; set; }
    }
}
