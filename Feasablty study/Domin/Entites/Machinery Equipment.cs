﻿using Feasablty_study.Domin.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Machinery_Equipment : IEntityBase
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string NameSupplier { get; set; }

        public int Number { get; set; }
        public double Price { get; set; }
        public double TotalPrice {
            get { return Price*Number; }
            set
            {
                _ = Number * Price;
            }
                }

        [ForeignKey("Feasibility_study")]
        public virtual int Feasibility_StudyId { get; set; }
        public virtual Feasibility_study Feasibility_Study { get; set; }
    }
}
