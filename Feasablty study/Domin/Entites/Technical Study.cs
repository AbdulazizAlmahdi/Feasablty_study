using Feasablty_study.Domin.Interfaces;
using System.Collections.Generic;

namespace Feasablty_study.Models
{
    public class Technical_Study : IEntityBase
    {
        public int Id { get; set; }
        public int FeasibilityStudyId { get; set; }
        public Feasibility_study feasibility_study { get; set; }
        public ICollection <Raw_materials> raw_Materials  { get; set; }
        public ICollection <Public_benefit> public_Benefits  { get; set; }
        public ICollection <Manpower_workforce> Manpower_Workforces  { get; set; }
        public ICollection <Government_fees> Government_Fees  { get; set; }
        public ICollection <Machinery_Equipment> machinery_Equipment  { get; set; }
        public ICollection <Rentals> rentals  { get; set; }
        public ICollection <Establishment_expenses> establishment_Expenses  { get; set; }
        public ICollection <Construction_and_buliding> construction_And_Bulidings  { get; set; }


    }
}
