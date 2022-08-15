using Feasablty_study.Domin.Interfaces;
using Feasablty_study.Domin.ViewModels;
using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Feasablty_study.Infrastructure.Repository
{
    public class FeasibilityStudyRepo : BaseRepository<Feasibility_study>, IFeasibilityStudyRepo
    {

        private readonly AppDbContext context1;
        public FeasibilityStudyRepo(AppDbContext context, AppDbContext context1) : base(context)
        {
            this.context1=context1;
          
        }
      /* public async Task<IEnumerable<Feasibility_study>> GetAllAsync(string userId)
        {
            context1.Feasibility_studies.

        }
       public async Task<IEnumerable<Feasibility_study>> GetAllAsync(params Expression<Func<Feasibility_study, object>>[] includeProperties, string userId)
        {

        }*/

        public async Task AddAsync(CreateFeasibilityStudyViewModel model,string UserId)
        {
            Feasibility_study fs = new Feasibility_study()
            {
                UserId = UserId,
                ContactNumber = model.feasibility_Study.ContactNumber,
                Description = model.feasibility_Study.Description,
                ProjectDate = model.feasibility_Study.ProjectDate,
                OwnerName = model.feasibility_Study.OwnerName,
                ProjectLocation = model.feasibility_Study.ProjectLocation,
                ProjectName = model.feasibility_Study.ProjectName,
                ProjectType = model.feasibility_Study.ProjectType,
                ProjectEmail=model.feasibility_Study.ProjectEmail,
            };
            fs.Preliminary_study = new Preliminary_study();
            fs.Preliminary_study.CteristicsOfTheProjectArea = string.Join(",", model.CteristicsOfTheProjectArea);
            fs.Preliminary_study.FactorsRepresentedOnIncreasedDemand = string.Join(",", model.FactorsRepresentedOnIncreasedDemand);
            fs.Preliminary_study.FactorsRepresentedOnLowDemand = string.Join(",", model.FactorsRepresentedOnLowDemand);
            fs.Preliminary_study.ProjectObjectives = string.Join(",", model.ProjectGoals);

            fs.Preliminary_study.VisionOfTheProject = model.preliminary_Study.VisionOfTheProject;

            fs.licenses = new List<License>();

            foreach (var item in model.licenses)
            {
                var It = new License()
                {
                    LicenseType = item.LicenseType,
                    Licenses = item.Licenses,

                };
                fs.licenses.Add(It);
            }
            fs.market_Study = new Market_study();
            fs.market_Study.AvailbleOpportunity = string.Join(",", model.AvailbleOpportunity);
            fs.market_Study.StrengthPoints = string.Join(",", model.StrengthPoints);
            fs.market_Study.TargetMarket = string.Join(",", model.TargetMarket);
            fs.market_Study.PointsOfEwakness = string.Join(",", model.PointsOfEwakness);
            //fs.market_Study.ProjectLocationOnTheMap = model.Market_Study.ProjectLocationOnTheMap;
            fs.market_Study.Threats = string.Join(",", model.Threats);
            fs.market_Study.MarketGap = model.Market_Study.MarketGap;
            fs.market_Study.TotalExpected_revenue = 0;
            fs.market_Study.TotalMarketing_Activity = 0;

            fs.competitors = new List<Competitors>();
            foreach (var item in model.Competitors)
            {
                var It = new Competitors()
                {
                    CompetitorsName = item.CompetitorsName,
                    CompetitorsPrice = item.CompetitorsPrice,
                    AmounrAdded = item.AmounrAdded,
                    Products = item.Products,
                };
                fs.competitors.Add(It);
            }

            fs.expected_Revenues = new List<Expected_revenue>();
            foreach (var item in model.expected_Revenues)
            {
                var It = new Expected_revenue()
                {
                    ProductName = item.ProductName,
                    ProductPrice = item.ProductPrice,
                    MonthlyQusntity = item.MonthlyQusntity,
                };
                fs.expected_Revenues.Add(It);
                fs.market_Study.TotalExpected_revenue += It.TotalYearlyPrice;
            }

            fs.marketing_Activities = new List<Marketing_Activity>();
            foreach (var item in model.marketing_Activities)
            {
                var It = new Marketing_Activity()
                {
                    Name = item.Name,
                    Amount = item.Amount,
                };
                fs.marketing_Activities.Add(It);
                fs.market_Study.TotalMarketing_Activity += It.Amount;

            }

            fs.risks = new List<Risk>();
            foreach (var item in model.risks)
            {
                var It = new Risk()
                {
                    TypeRisk = item.TypeRisk,
                    DescriptionRisk = item.DescriptionRisk,
                    DangerReductionStyle = item.DangerReductionStyle,
                    DescriptionDangerReduece = item.DescriptionDangerReduece,


                };
                fs.risks.Add(It);
            }

            fs.technical_Study = new Technical_Study();
            fs.technical_Study.TotalMachinery_Equipment = 0;
            fs.technical_Study.TotalManpower_workforce = 0;
            fs.technical_Study.TotalPublic_benefit = 0;
            fs.technical_Study.TotalConstruction_and_buliding = 0;
            fs.technical_Study.TotalRaw_materials = 0;
            fs.technical_Study.TotalGovernment_fees = 0;
            fs.technical_Study.TotalRentals = 0;

            fs.machinery_Equipment = new List<Machinery_Equipment>();

            foreach (var item in model.machinery_Equipment)
            {
                var It = new Machinery_Equipment()
                {
                    Name = item.Name,
                    NameSupplier = item.NameSupplier,
                    Number = item.Number,
                    Price = item.Price,

                };
                fs.machinery_Equipment.Add(It);
                fs.technical_Study.TotalMachinery_Equipment += It.TotalPrice;
            }

            fs.Manpower_Workforces = new List<Manpower_workforce>();
            foreach (var item in model.Manpower_Workforces)
            {
                var It = new Manpower_workforce()
                {
                    JobTitle = item.JobTitle,
                    Number = item.Number,
                    MonthlySalary = item.MonthlySalary,

                };
                fs.Manpower_Workforces.Add(It);
                fs.technical_Study.TotalManpower_workforce += It.TotalYearlySalary;

            }

            fs.construction_And_Bulidings = new List<Construction_and_buliding>();
            foreach (var item in model.construction_And_Bulidings)
            {
                var It = new Construction_and_buliding()
                {
                    BuildingType = item.BuildingType,
                    TotalArea = item.TotalArea,
                    PricePerMeter = item.PricePerMeter,


                };
                fs.construction_And_Bulidings.Add(It);
                fs.technical_Study.TotalConstruction_and_buliding += It.TotalPriceArea;
            }

            fs.rentals = new List<Rentals>();
            foreach (var item in model.rentals)
            {
                var It = new Rentals()
                {
                    RentalType = item.RentalType,
                    RentalYearly = item.RentalYearly,


                };
                fs.rentals.Add(It);
                fs.technical_Study.TotalRentals = It.RentalYearly;
            }

            fs.Government_Fees = new List<Government_fees>();
            foreach (var item in model.Government_Fees)
            {
                var It = new Government_fees()
                {
                    Name = item.Name,
                    Price = item.Price,


                };
                fs.Government_Fees.Add(It);
                fs.technical_Study.TotalGovernment_fees += It.Price;
            }

            fs.establishment_Expenses = new List<Establishment_expenses>();
            foreach (var item in model.establishment_Expenses)
            {
                var It = new Establishment_expenses()
                {
                    Type = item.Type,
                    Price = item.Price,

                };
                fs.establishment_Expenses.Add(It);
                fs.technical_Study.TotalEstablishment_expenses += It.Price;
            }

            fs.raw_Materials = new List<Raw_materials>();
            foreach (var item in model.raw_Materials)
            {
                var It = new Raw_materials()
                {
                    Material = item.Material,
                    PriceOfUnity = item.PriceOfUnity,
                    Unit = item.Unit,
                    QuantityRequiredMonthly = item.QuantityRequiredMonthly,

                };
                fs.raw_Materials.Add(It);
                fs.technical_Study.TotalRaw_materials += It.TotalPriceQuantityYearly;
            }


            fs.public_Benefits = new List<Public_benefit>();
            foreach (var item in model.public_Benefits)
            {
                var It = new Public_benefit()
                {
                    Benefit = item.Benefit,
                    MonthlyCost = item.MonthlyCost,

                };
                fs.public_Benefits.Add(It);
                fs.technical_Study.TotalPublic_benefit += It.YearlyCost;
            }


            await context1.Feasibility_studies.AddAsync(fs);
            // fs.market_Study.competitors.ToList();
            context1.SaveChanges();
        }
    }
}
