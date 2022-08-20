using Feasablty_study.Domin.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Construction_and_buliding : IEntityBase
    {
        public int Id { get; set; }

        public string BuildingType { get; set; }

        public double PricePerMeter { get; set; }

        public double TotalArea { get; set; }
        public double TotalPriceArea {  
            get { return PricePerMeter * TotalArea;}
            set => _ = PricePerMeter * TotalArea;
                

        }

        [ForeignKey("Feasibility_study")]
        public virtual int Feasibility_StudyId { get; set; }
        public virtual Feasibility_study Feasibility_Study { get; set; }
    }
}
