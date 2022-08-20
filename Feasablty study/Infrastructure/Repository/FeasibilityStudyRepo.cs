using Feasablty_study.Domin.Interfaces;
using Feasablty_study.Domin.ViewModels;
using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Feasablty_study.Services;
using System.IO;

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
        public static int Count { get; set; }
        public  int CountM ()
        {
          // this.count= context1.Feasibility_studies.Count();
            return Count;
        }

        public async Task AddAsync(CreateFeasibilityStudyViewModel model,string UserId)
        {
       
            Feasibility_study fs = new()
            {
                UserId = UserId,
                ContactNumber = model.Feasibility_Study.ContactNumber,
                Description = model.Feasibility_Study.Description,
                ProjectDate = model.Feasibility_Study.ProjectDate,
                OwnerName = model.Feasibility_Study.OwnerName,
                ProjectLocation = model.Feasibility_Study.ProjectLocation,
                ProjectName = model.Feasibility_Study.ProjectName,
                ProjectType = model.Feasibility_Study.ProjectType,
                ProjectEmail=model.Feasibility_Study.ProjectEmail,
                ProjectLogo=model.Feasibility_Study.ProjectLogo,
            };
            fs.Preliminary_study = new Preliminary_study
            {
                // string[] CteristicsOfTheProjectArea = new string[];
                //foreach
                CteristicsOfTheProjectArea = string.Join("<br/>", model.CteristicsOfTheProjectArea.Where(s => s != "false")),
                FactorsRepresentedOnIncreasedDemand = string.Join("<br/>", model.FactorsRepresentedOnIncreasedDemand.Where(s => s != "false")),
                FactorsRepresentedOnLowDemand = string.Join("<br/>", model.FactorsRepresentedOnLowDemand.Where(s => s != "false")),
                ProjectObjectives = string.Join("<br/>", model.ProjectGoals.Where(s => s != "false")),

                VisionOfTheProject = model.Preliminary_Study.VisionOfTheProject,
                MessageOfTheProject = model.Preliminary_Study.MessageOfTheProject
            };

            fs.Licenses = new List<License>();

            foreach (var item in model.Licenses)
            {
                var It = new License()
                {
                    LicenseType = item.LicenseType,
                    Licenses = item.Licenses,

                };
                fs.Licenses.Add(It);
            }
            fs.Market_Study = new Market_study()
            {
            AvailbleOpportunity = string.Join("<br/>", model.AvailbleOpportunity.Where(s => s != "false")),
            StrengthPoints = string.Join("<br/>", model.StrengthPoints.Where(s => s != "false")),
            TargetMarket = string.Join("<br/>", model.TargetMarket.Where(s => s != "false")),
            PointsOfEwakness = string.Join("<br/>", model.PointsOfEwakness.Where(s => s != "false")),
            //ProjectLocationOnTheMap = model.Market_Study.ProjectLocationOnTheMap,
            Threats = string.Join("<br/>", model.Threats.Where(s => s != "false")),
            MarketGap = model.Market_Study.MarketGap,
            TotalExpected_revenue = 0,
            TotalMarketing_Activity = 0,
        };
            

            fs.Competitors = new List<Competitors>();
            foreach (var item in model.Competitors)
            {
                var It = new Competitors()
                {
                    CompetitorsName = item.CompetitorsName,
                    CompetitorsPrice = item.CompetitorsPrice,
                    AmounrAdded = item.AmounrAdded,
                    Products = item.Products,
                };
                fs.Competitors.Add(It);
            }

            fs.Expected_Revenues = new List<Expected_revenue>();
            foreach (var item in model.Expected_Revenues)
            {
                var It = new Expected_revenue()
                {
                    ProductName = item.ProductName,
                    ProductPrice = item.ProductPrice,
                    MonthlyQusntity = item.MonthlyQusntity,
                };
                fs.Expected_Revenues.Add(It);
                fs.Market_Study.TotalExpected_revenue += It.TotalYearlyPrice;
            }

            fs.Marketing_Activities = new List<Marketing_Activity>();
            foreach (var item in model.Marketing_Activities)
            {
                var It = new Marketing_Activity()
                {
                    Name = item.Name,
                    Amount = item.Amount,
                };
                fs.Marketing_Activities.Add(It);
                fs.Market_Study.TotalMarketing_Activity += It.Amount;

            }

            fs.Risks = new List<Risk>();
            foreach (var item in model.Risks)
            {
                var It = new Risk()
                {
                    TypeRisk = item.TypeRisk,
                    DescriptionRisk = item.DescriptionRisk,
                    DangerReductionStyle = item.DangerReductionStyle,
                    DescriptionDangerReduece = item.DescriptionDangerReduece,


                };
                fs.Risks.Add(It);
            }

            fs.Technical_Study = new Technical_Study
            {
                TotalMachinery_Equipment = 0,
                TotalManpower_workforce = 0,
                TotalPublic_benefit = 0,
                TotalConstruction_and_buliding = 0,
                TotalRaw_materials = 0,
                TotalGovernment_fees = 0,
                TotalRentals = 0,
                OperationalCycle = model.Technical_Study.OperationalCycle
            };

            fs.Machinery_Equipment = new List<Machinery_Equipment>();

            foreach (var item in model.Machinery_Equipment)
            {
                var It = new Machinery_Equipment()
                {
                    Name = item.Name,
                    NameSupplier = item.NameSupplier,
                    Number = item.Number,
                    Price = item.Price,

                };
                fs.Machinery_Equipment.Add(It);
                fs.Technical_Study.TotalMachinery_Equipment += It.TotalPrice;
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
                fs.Technical_Study.TotalManpower_workforce += It.TotalYearlySalary;

            }

            fs.Construction_And_Bulidings = new List<Construction_and_buliding>();
            foreach (var item in model.Construction_And_Bulidings)
            {
                var It = new Construction_and_buliding()
                {
                    BuildingType = item.BuildingType,
                    TotalArea = item.TotalArea,
                    PricePerMeter = item.PricePerMeter,


                };
                fs.Construction_And_Bulidings.Add(It);
                fs.Technical_Study.TotalConstruction_and_buliding += It.TotalPriceArea;
            }

            fs.Rentals = new List<Rentals>();
            foreach (var item in model.Rentals)
            {
                var It = new Rentals()
                {
                    RentalType = item.RentalType,
                    RentalYearly = item.RentalYearly,


                };
                fs.Rentals.Add(It);
                fs.Technical_Study.TotalRentals += It.RentalYearly;
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
                fs.Technical_Study.TotalGovernment_fees += It.Price;
            }

            fs.Establishment_Expenses = new List<Establishment_expenses>();
            foreach (var item in model.Establishment_Expenses)
            {
                var It = new Establishment_expenses()
                {
                    Type = item.Type,
                    Price = item.Price,

                };
                fs.Establishment_Expenses.Add(It);
                fs.Technical_Study.TotalEstablishment_expenses += It.Price;
            }

            fs.Raw_Materials = new List<Raw_materials>();
            foreach (var item in model.Raw_Materials)
            {
                var It = new Raw_materials()
                {
                    Material = item.Material,
                    PriceOfUnity = item.PriceOfUnity,
                    Unit = item.Unit,
                    QuantityRequiredMonthly = item.QuantityRequiredMonthly,

                };
                fs.Raw_Materials.Add(It);
                fs.Technical_Study.TotalRaw_materials += It.TotalPriceQuantityYearly;
            }


            fs.Public_Benefits = new List<Public_benefit>();
            foreach (var item in model.Public_Benefits)
            {
                var It = new Public_benefit()
                {
                    Benefit = item.Benefit,
                    MonthlyCost = item.MonthlyCost,

                };
                fs.Public_Benefits.Add(It);
                fs.Technical_Study.TotalPublic_benefit += It.YearlyCost;
            }
            fs.TotalOperatingExpenseseOneYear = fs.Market_Study.TotalMarketing_Activity + fs.Technical_Study.TotalOperatingExpensese;
            fs.WorkingCapital = fs.TotalOperatingExpenseseOneYear / fs.Technical_Study.OperationalCycle;
            fs.Zakat = fs.Market_Study.TotalExpected_revenue * 0.025;
            fs.NetProfit = fs.Market_Study.TotalExpected_revenue-fs.TotalOperatingExpenseseOneYear-fs.Zakat;
            fs.ProfitRate =(int) (fs.NetProfit / fs.TotalOperatingExpenseseOneYear) * 100;
            await context1.Feasibility_studies.AddAsync(fs);
            context1.SaveChanges();
        }
    }
}
