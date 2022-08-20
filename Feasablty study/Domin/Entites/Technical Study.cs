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
        public double TotalMachinery_Equipment { get; set; }
        public double TotalManpower_workforce { get; set; }
        public double TotalConstruction_and_buliding { get; set; }
        public double TotalRentals { get; set; }
        public double TotalGovernment_fees { get; set; }
        public double TotalEstablishment_expenses { get; set; }
        public double TotalRaw_materials { get; set; }
        public double TotalPublic_benefit { get; set; }
        public double AnnualDepreciation { 
            get
            { 
                return (TotalMachinery_Equipment-(TotalMachinery_Equipment * 0.2))*0.05; 
            }
            set
            {
                _ = (TotalMachinery_Equipment - (TotalMachinery_Equipment * 0.2)) * 0.05;
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
                _ = TotalMachinery_Equipment  * 0.05;
            }
        }
        public double TotalOperatingExpensese
        { 
            get
            { 
                return (TotalGovernment_fees+TotalManpower_workforce+TotalPublic_benefit+TotalRaw_materials+TotalRentals+AnnualDepreciation+ AnnualAaintenance); 
            }
            set
            {
                _ = (TotalGovernment_fees + TotalManpower_workforce + TotalPublic_benefit + TotalRaw_materials + TotalRentals + AnnualDepreciation+ AnnualAaintenance);
            }
        }
            

        public int OperationalCycle { get; set; }

        public virtual Feasibility_study Feasibility_study { get; set; }
        


    }
}
