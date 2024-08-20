using Feasablty_study.Domin.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Feasibility_study : IEntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "ادخل اسم المشروع "), MaxLength(150, ErrorMessage = "اسم المشروع طويل للغاية")]
        public string ProjectName { get; set; }
        [MaxLength(200)]
        [Required]
        public string Description { get; set; }
        public string ProjectLocation { get; set; }
        public string ProjectType { get; set; }
        public string ProjectLogo { get; set; }

        public DateTime ProjectDate { get; set; }
        public string OwnerName { get; set; }
        public string ProjectEmail { get; set; }
        public string ContactNumber { get; set; }
        public double TotalOperatingExpenseseOneYear { get; set; }
        public double WorkingCapital { get; set; }
        public double NetProfit { get; set; }
        public double Zakat { get; set; }
        public int ProfitRate { get; set; }
        public User User { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public Preliminary_study Preliminary_study { get; set; }
        public virtual ICollection<License> Licenses { get; set; }
        public virtual Market_study Market_Study { get; set; }
        public virtual ICollection<Competitors> Competitors { get; set; }
        public virtual ICollection<Expected_revenue> Expected_Revenues { get; set; }
        public virtual ICollection<Marketing_Activity> Marketing_Activities { get; set; }
        public ICollection<Risk> Risks { get; set; }

        public Technical_Study Technical_Study { get; set; }
        public virtual ICollection<Machinery_Equipment> Machinery_Equipment { get; set; }
        public virtual ICollection<Manpower_workforce> Manpower_Workforces { get; set; }
        public virtual ICollection<Construction_and_buliding> Construction_And_Bulidings { get; set; }
        public virtual ICollection<Rentals> Rentals { get; set; }
        public virtual ICollection<Government_fees> Government_Fees { get; set; }
        public virtual ICollection<Establishment_expenses> Establishment_Expenses { get; set; }
        public virtual ICollection<Raw_materials> Raw_Materials { get; set; }
        public virtual ICollection<Public_benefit> Public_Benefits { get; set; }




    }
}
