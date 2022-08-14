using Feasablty_study.Domin.ViewModels;
using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Infrastructure.Repository;
using Feasablty_study.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feasablty_study.Controllers
{
    public class Feasibility_studyController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IFeasibilityStudyRepo _feasibilityStudyRepo;

        public Feasibility_studyController(AppDbContext context,IFeasibilityStudyRepo feasibilityStudyRepo, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _feasibilityStudyRepo = feasibilityStudyRepo;
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: Feasibility_study
        public async Task<IActionResult> Index()
        {
            var allF_S = await _feasibilityStudyRepo.GetAllAsync(s => s.Preliminary_study);
            return View(allF_S.ToList());
        }

        // GET: Feasibility_study/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feasibility_study = await _feasibilityStudyRepo.GetByIdAsync((int)id,u=>u.user,p=>p.Preliminary_study,m=>m.market_Study,t=>t.technical_Study);
               
            if (feasibility_study == null)
            {
                return NotFound();
            }

            return View(feasibility_study);
        }

        // GET: Feasibility_study/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFeasibilityStudyViewModel model)
        {
            Feasibility_study fs = new Feasibility_study()
            {
                UserId = _userManager.GetUserId(User),
                ContactNumber = model.feasibility_Study.ContactNumber,
                Description = model.feasibility_Study.Description,
                ProjectDate = model.feasibility_Study.ProjectDate,
                OwnerName = model.feasibility_Study.OwnerName,
                ProjectLocation = model.feasibility_Study.ProjectLocation,
                ProjectName = model.feasibility_Study.ProjectName,
                ProjectType = model.feasibility_Study.ProjectType,
            };
            fs.Preliminary_study = new Preliminary_study();
            fs.Preliminary_study.CteristicsOfTheProjectArea =string.Join(",",model.CteristicsOfTheProjectArea);
            fs.Preliminary_study.FactorsRepresentedOnIncreasedDemand =string.Join(",",model.FactorsRepresentedOnIncreasedDemand);
            fs.Preliminary_study.FactorsRepresentedOnLowDemand = string.Join(",",model.FactorsRepresentedOnLowDemand);
            fs.Preliminary_study.ProjectObjectives = string.Join(",",model.ProjectGoals);

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
            fs.market_Study=new Market_study();
            fs.market_Study.AvailbleOpportunity = string.Join(",",model.AvailbleOpportunity);
            fs.market_Study.StrengthPoints = string.Join(",", model.StrengthPoints);
            fs.market_Study.TargetMarket = string.Join(",", model.TargetMarket);
            fs.market_Study.PointsOfEwakness = string.Join(",", model.PointsOfEwakness);
            //fs.market_Study.ProjectLocationOnTheMap = model.Market_Study.ProjectLocationOnTheMap;
            fs.market_Study.Threats = string.Join(",", model.Threats);
            fs.market_Study.MarketGap=model.Market_Study.MarketGap;

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

            fs.expected_Revenues=new List<Expected_revenue>();
            foreach (var item in model.expected_Revenues)
            {
                var It = new Expected_revenue()
                {
                   ProductName = item.ProductName,
                   ProductPrice = item.ProductPrice,
                   MonthlyQusntity = item.MonthlyQusntity,
                };
                fs.expected_Revenues.Add(It);
            }

            fs.marketing_Activities=new List<Marketing_Activity>();
            foreach (var item in model.marketing_Activities)
            {
                var It = new Marketing_Activity()
                {
                    Name = item.Name,
                    Amount = item.Amount,
                };
                fs.marketing_Activities.Add(It);
            } 
            
            fs.risks=new List<Risk>();
            foreach (var item in model.risks)
            {
                var It = new Risk()
                {
                    TypeRisk=item.TypeRisk,
                    DescriptionRisk=item.DescriptionRisk,
                    DangerReductionStyle=item.DangerReductionStyle,
                    DescriptionDangerReduece=item.DescriptionDangerReduece,

                    
                };
                fs.risks.Add(It);
            }  

            fs.technical_Study=new Technical_Study();
            
            
            fs.machinery_Equipment = new List<Machinery_Equipment>();
            foreach (var item in model.machinery_Equipment)
            {
                var It = new Machinery_Equipment()
                {
                    Name=item.Name,
                    NameSupplier=item.NameSupplier,
                    Number=item.Number,
                    Price=item.Price,
                               
                };
                fs.machinery_Equipment.Add(It);
            }

            fs.Manpower_Workforces = new List<Manpower_workforce>();
            foreach (var item in model.Manpower_Workforces)
            {
                var It = new Manpower_workforce()
                {
                    JobTitle=item.JobTitle,
                    Number=item.Number,
                    MonthlySalary=item.MonthlySalary,
                               
                };
                fs.Manpower_Workforces.Add(It);
            }
              
            fs.construction_And_Bulidings = new List<Construction_and_buliding>();
            foreach (var item in model.construction_And_Bulidings)
            {
                var It = new Construction_and_buliding()
                {
                    BuildingType=item.BuildingType,
                    TotalArea=item.TotalArea,
                    PricePerMeter=item.PricePerMeter,
                    
                               
                };
                fs.construction_And_Bulidings.Add(It);
            }
             
            fs.rentals = new List<Rentals>();
            foreach (var item in model.rentals)
            {
                var It = new Rentals()
                {
                    RentalType=item.RentalType,
                    RentalYearly=item.RentalYearly,
                    
                               
                };
                fs.rentals.Add(It);
            }
                         
            fs.Government_Fees = new List<Government_fees>();
            foreach (var item in model.Government_Fees)
            {
                var It = new Government_fees()
                {
                    Name=item.Name,
                    Price=item.Price,
                    
                               
                };
                fs.Government_Fees.Add(It);
            }
                         
            fs.establishment_Expenses = new List<Establishment_expenses>();
            foreach (var item in model.establishment_Expenses)
            {
                var It = new Establishment_expenses()
                {
                    Type=item.Type,
                    Price=item.Price,
                                         
                };
                fs.establishment_Expenses.Add(It);
            }
                         
            fs.raw_Materials = new List<Raw_materials>();
            foreach (var item in model.raw_Materials)
            {
                var It = new Raw_materials()
                {
                  Material=item.Material,
                  PriceOfUnity=item.PriceOfUnity,
                  Unit=item.Unit,
                  QuantityRequiredMonthly=item.QuantityRequiredMonthly,
                                         
                };
                fs.raw_Materials.Add(It);
            }

                                     
            fs.public_Benefits = new List<Public_benefit>();
            foreach (var item in model.public_Benefits)
            {
                var It = new Public_benefit()
                {
                  Benefit=item.Benefit,
                  MonthlyCost=item.MonthlyCost,
                                         
                };
                fs.public_Benefits.Add(It);
            }


            await _context.Feasibility_studies.AddAsync(fs);
            // fs.market_Study.competitors.ToList();
            _context.SaveChanges();

            return View(model);

           // return View(feasibility_study);
        }

        // GET: Feasibility_study/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feasibility_study = await _context.Feasibility_studies.FindAsync(id);
            if (feasibility_study == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", feasibility_study.UserId);
            return View(feasibility_study);
        }

        // POST: Feasibility_study/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProjectName,Description,ProjectLocation,ProjectType,ProjectLogo,DateTime,ContactNumber,UserId")] Feasibility_study feasibility_study)
        {
            if (id != feasibility_study.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(feasibility_study);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Feasibility_studyExists(feasibility_study.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", feasibility_study.UserId);
            return View(feasibility_study);
        }

        // GET: Feasibility_study/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feasibility_study = await _context.Feasibility_studies
                .Include(f => f.user)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (feasibility_study == null)
            {
                return NotFound();
            }

            return View(feasibility_study);
        }

        // POST: Feasibility_study/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var feasibility_study = await _context.Feasibility_studies.FindAsync(id);
            _context.Feasibility_studies.Remove(feasibility_study);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Feasibility_studyExists(int id)
        {
            return _context.Feasibility_studies.Any(e => e.Id == id);
        }
    }
}
