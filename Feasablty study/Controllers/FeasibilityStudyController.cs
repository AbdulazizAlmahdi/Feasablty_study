using Feasablty_study.Domin.Entites;
using Feasablty_study.Domin.ViewModels;
using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Infrastructure.Repository;
using Feasablty_study.Models;
using Feasablty_study.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using Rotativa.AspNetCore.Options;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Feasablty_study.Controllers
{
    [Authorize]
    public class Feasibility_studyController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IFeasibilityStudyRepo _feasibilityStudyRepo;
        private readonly IWebHostEnvironment _hosting;


        public Feasibility_studyController(AppDbContext context,IFeasibilityStudyRepo feasibilityStudyRepo, UserManager<User> userManager, SignInManager<User> signInManager, IWebHostEnvironment hosting)
        {
            _feasibilityStudyRepo = feasibilityStudyRepo;
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _hosting = hosting;
        }
        

        // GET: Feasibility_study
        public async Task<IActionResult> Index()
        {
            var currentuser =_userManager.Users.First(u=>u.Id==User.FindFirstValue(ClaimTypes.NameIdentifier));
            var allfeasibilityStudy = await _feasibilityStudyRepo.GetAllAsync(f=>f.User);
            if (User.IsInRole(UserRoles.Admin))
            {
                return View(allfeasibilityStudy.ToList());

            }
            else if (User.IsInRole(UserRoles.Employee))
            {

                var allForEmployeefeasibilityStudy = allfeasibilityStudy.ToList().FindAll(i => i.User.RegionId == currentuser.RegionId);
                return View(allForEmployeefeasibilityStudy);

            }
            else if (User.IsInRole(UserRoles.User))
            {

                var allForUserfeasibilityStudy = allfeasibilityStudy.ToList().FindAll(i => i.UserId == _userManager.GetUserId(User));
                return View(allForUserfeasibilityStudy);

            }
            else if (User.IsInRole(UserRoles.Employee))
            {
                var allForUserfeasibilityStudy = allfeasibilityStudy.ToList().FindAll(i => i.User.RegionId == currentuser.RegionId);
                return View(allForUserfeasibilityStudy);
            }
            else
                return View();
        }
        public async Task<IActionResult> PrintAsPdf(int id)
        {
            var feasibilitystudy = await _feasibilityStudyRepo.GetByIdAsync(
                id,
                a => a.Preliminary_study,
                b => b.Licenses,
                m => m.Market_Study,
                c => c.Competitors,
                c => c.Expected_Revenues,
                c => c.Construction_And_Bulidings,
                c => c.Technical_Study,
                c => c.Marketing_Activities,
                c => c.Risks,
                c=>c.Establishment_Expenses,
                c=>c.Manpower_Workforces,
                c=>c.Machinery_Equipment,
                c=>c.Government_Fees,
                c=>c.Rentals,
                c=>c.Raw_Materials,
                c=>c.Public_Benefits
                );
            return new ViewAsPdf("PrintAsPdf", feasibilitystudy)
            {
                PageOrientation = Orientation.Portrait,
                MinimumFontSize = 25,
                PageSize = Size.A4,
                CustomSwitches =" --print-media-type --no-background --footer-line --header-line --page-offset 0 --footer-center [page] --footer-font-size 8 --footer-right \"page [page] from [topage]\"  "
            };
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feasibility_study = await _feasibilityStudyRepo.GetByIdAsync((int)id,u=>u.User,p=>p.Preliminary_study,m=>m.Market_Study,t=>t.Technical_Study);
               
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

            /*if (Request.Form.Files.Count > 0)
            {
                var file = Request.Form.Files.FirstOrDefault();
                string pathUpload = Path.Combine(_hosting.WebRootPath, "Images");
                model.Feasibility_Study.ProjectLogo = UploadFileHelper.UploadFile(file, pathUpload, model.Feasibility_Study.ProjectLogo);
            }
            */
            await _feasibilityStudyRepo.AddAsync(model,UserId);
            return Json(new { result = "Redirect", url = Url.Action("Index", "Feasibility_study") });

        }

        // GET: Feasibility_study/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feasibility_study = await _context.Feasibility_studies
                .Include(f => f.User)
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
