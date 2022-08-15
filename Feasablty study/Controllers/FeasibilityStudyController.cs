using Feasablty_study.Domin.Entites;
using Feasablty_study.Domin.ViewModels;
using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Infrastructure.Repository;
using Feasablty_study.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
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
            if (User.IsInRole(UserRoles.Admin))
            {
                var all_feasibilityStudy = await _feasibilityStudyRepo.GetAllAsync(s => s.Preliminary_study);
                return View(all_feasibilityStudy.ToList());

            }
            else
            {
                var allfeasibilityStudy = await _feasibilityStudyRepo.GetAllAsync();
                var allForUserfeasibilityStudy=allfeasibilityStudy.ToList().FindAll(i => i.UserId == _userManager.GetUserId(User));
                return View(allForUserfeasibilityStudy) ;

            }
        }
        public async Task<IActionResult> PrintAsPdf(int id)
        {
            var feasibilitystudy = await _feasibilityStudyRepo.GetByIdAsync(
                id,
                a => a.Preliminary_study,
                b => b.licenses,
                m => m.market_Study,
                c => c.competitors,
                c => c.expected_Revenues,
                c => c.construction_And_Bulidings,
                c => c.technical_Study,
                c => c.marketing_Activities,
                c => c.risks,
                c=>c.establishment_Expenses,
                c=>c.Manpower_Workforces,
                c=>c.machinery_Equipment,
                c=>c.Government_Fees,
                c=>c.rentals,
                c=>c.raw_Materials,
                c=>c.public_Benefits
                );     
            return new ViewAsPdf("PrintAsPdf", feasibilitystudy);
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
            string UserId = _userManager.GetUserId(User);
            await _feasibilityStudyRepo.AddAsync(model,UserId);
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
