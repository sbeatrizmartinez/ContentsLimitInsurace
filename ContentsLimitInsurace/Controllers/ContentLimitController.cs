using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContentsLimitInsurace.Models;

namespace ContentsLimitInsurace.Controllers
{
    public class ContentLimitController : Controller
    {
        private readonly ContentLimitContext _context;

        public ContentLimitController(ContentLimitContext context)
        {
            _context = context;
        }

        // GET: ContentLimit
        public async Task<IActionResult> Index()
        {
            return View(await _context.contents.ToListAsync());
        }

       

        // GET: ContentLimit/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContentLimit/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContentId,itemName,itemValue,itemCategory")] ContentLimit contentLimit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contentLimit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contentLimit);
        }

 

        // GET: ContentLimit/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contentLimit = await _context.contents
                .FirstOrDefaultAsync(m => m.ContentId == id);
            if (contentLimit == null)
            {
                return NotFound();
            }

            return View(contentLimit);
        }

        // POST: ContentLimit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contentLimit = await _context.contents.FindAsync(id);
            _context.contents.Remove(contentLimit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContentLimitExists(int id)
        {
            return _context.contents.Any(e => e.ContentId == id);
        }
    }
}
