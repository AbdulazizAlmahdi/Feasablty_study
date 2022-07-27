using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Feasablty_study.Models;

namespace Feasablty_study.Controllers
{
    public class Support_MessagesController : Controller
    {
        private readonly AppDbContext _context;

        public Support_MessagesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Support_Messages
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.SupportMessages.Include(s => s.user);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Support_Messages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var support_Messages = await _context.SupportMessages
                .Include(s => s.user)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (support_Messages == null)
            {
                return NotFound();
            }

            return View(support_Messages);
        }

        // GET: Support_Messages/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "UserName");
            return View();
        }

        // POST: Support_Messages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,Email,Date,UserId")] Support_Messages support_Messages)
        {
            if (ModelState.IsValid)
            {
                _context.Add(support_Messages);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "UserName", support_Messages.UserId);
            return View(support_Messages);
        }

        // GET: Support_Messages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var support_Messages = await _context.SupportMessages.FindAsync(id);
            if (support_Messages == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", support_Messages.UserId);
            return View(support_Messages);
        }

        // POST: Support_Messages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        

        // GET: Support_Messages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var support_Messages = await _context.SupportMessages
                .Include(s => s.user)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (support_Messages == null)
            {
                return NotFound();
            }

            return View(support_Messages);
        }

        // POST: Support_Messages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var support_Messages = await _context.SupportMessages.FindAsync(id);
            _context.SupportMessages.Remove(support_Messages);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Support_MessagesExists(int id)
        {
            return _context.SupportMessages.Any(e => e.Id == id);
        }
    }
}
