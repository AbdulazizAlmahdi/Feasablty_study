using Feasablty_study.Domin.Entites;
using Feasablty_study.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Feasablty_study.Domin.ViewModels
{
    public class CreateFeasibilityStudyViewModel
    {


        public Feasibility_study Feasibility_Study { get; set; }
        public Preliminary_study Preliminary_Study { get; set; }
        public String[] ProjectGoals { get; set; }
        public String[] CteristicsOfTheProjectArea { get; set; }
        public String[] FactorsRepresentedOnIncreasedDemand { get; set; }
        public String[] FactorsRepresentedOnLowDemand { get; set; }
        public IList<License> Licenses { get; set; }
        public Market_study Market_Study { get; set; }
        public string[] AvailbleOpportunity { get; set; }
        public string[] TargetMarket { get; set; }
        public string[] PointsOfEwakness { get; set; }
        public string[] Threats { get; set; }
        public string[] StrengthPoints { get; set; }
        public IList<Competitors> Competitors { get; set; }
        public IList<Expected_revenue> Expected_Revenues { get; set; }
        public IList<Marketing_Activity> Marketing_Activities { get; set; }
        public IList<Risk> Risks { get; set; }
        public Technical_Study Technical_Study { get; set; }
        public IList<Machinery_Equipment> Machinery_Equipment { get; set; }
        public IList<Manpower_workforce> Manpower_Workforces { get; set; }
        public IList<Construction_and_buliding> Construction_And_Bulidings { get; set; }
        public IList<Rentals> Rentals { get; set; }
        public IList<Government_fees> Government_Fees { get; set; }
        public IList<Establishment_expenses> Establishment_Expenses { get; set; }
        public IList<Raw_materials> Raw_Materials { get; set; }
        public IList<Public_benefit> Public_Benefits { get; set; }



    }
}
