using Feasablty_study.Domin.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Technical_Study 
    {

        [ForeignKey("Feasibility_study")]
        [Key]
        public int FeasibilityStudyId { get; set; }
        public float TotalMachinery_Equipment { get; set; }
        public float TotalManpower_workforce { get; set; }
        public float TotalConstruction_and_buliding { get; set; }
        public float TotalRentals { get; set; }
        public float TotalGovernment_fees { get; set; }
        public float TotalEstablishment_expenses { get; set; }
        public float TotalRaw_materials { get; set; }
        public float TotalPublic_benefit { get; set; }
        public double AnnualDepreciation { 
            get
            { 
                return (TotalMachinery_Equipment-(TotalMachinery_Equipment * 0.2))*0.05; 
            }
            set
            {
                value= (TotalMachinery_Equipment - (TotalMachinery_Equipment * 0.2)) * 0.05;
            }
        }
        public double AnnualAaintenance
        { 
            get
            { 
                return TotalMachinery_Equipment*0.05; 
            }
            set
            {
                value= TotalMachinery_Equipment  * 0.05;
            }
        }

        public virtual Feasibility_study feasibility_study { get; set; }
        


    }
}
