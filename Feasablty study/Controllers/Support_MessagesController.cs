using Feasablty_study.Infrastructure.Data;
using Feasablty_study.Models;
using System.Text.Unicode;
using Feasablty_study.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Feasablty_study.Domin.Entites;

namespace Feasablty_study.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
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
        public async Task<IActionResult> Create([Bind("Id,Title,Content,Email,Date,UserId")] Support_Messages support_Messages)
        {
            if (ModelState.IsValid)
            {

                support_Messages.user = _context.Users.SingleOrDefault(x => x.Id == support_Messages.UserId);
                _context.Add(support_Messages);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "UserName", support_Messages.UserId);
            return View(support_Messages);
        }






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

[HttpGet]
        public string GetMessages()
        {
            var messages = _context.SupportMessages.ToList();
            var json= JsonSerializer.Serialize(messages);
            string Messages=json;
            return Messages;

           /* return new DataTableResponse
            {
                RecordsTotal = messages.Count(),
                RecordsFiltered = 10,
                Data = messages.ToArray()
            };*/
        }
        [HttpPost]
        public string GetMessage()
        {
            var Result = JsonSerializer.Serialize(_context.SupportMessages);

            return Result;


            
        }
        [ProducesDefaultResponseType]
        [HttpPost]
        public JsonResult LoadData()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                // Skiping number of Rows count  
                var start = Request.Form["start"].FirstOrDefault();
                // Paging Length 10,20  
                var length = Request.Form["length"].FirstOrDefault();
                // Sort Column Name  
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                // Sort Column Direction ( asc ,desc)  
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                // Search Value from (Search box)  
                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                //Paging Size (10,20,50,100)  
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                // Getting all Customer data  
                var support_Messages = (from tempsupport_Messages in _context.SupportMessages
                                        select tempsupport_Messages);

                //Sorting  
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                   support_Messages = support_Messages.OrderBy( s=>s.Email);

                }
                //Search  
                if (!string.IsNullOrEmpty(searchValue))
                {
                    support_Messages = support_Messages.Where(m => m.Email == searchValue);
                }


                //total number of rows count
                recordsTotal = support_Messages.Count();          


                //Paging   
                var data = support_Messages.Skip(skip).Take(pageSize);



                //Returning Json Data  


                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });

            }
            catch (Exception)
            {
                throw;
            }

        }




        private bool Support_MessagesExists(int id)
        {
            return _context.SupportMessages.Any(e => e.Id == id);
        }
    }
}
