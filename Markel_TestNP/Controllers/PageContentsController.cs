using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Markel_TestNP.Models;

namespace Markel_TestNP.Controllers
{
    public class PageContentsController : Controller
    {
        private readonly MarkelDBContext _context;

        public PageContentsController(MarkelDBContext context)
        {
            _context = context;
        }

        // GET: PageContents
        public async Task<IActionResult> Index()
        {
            return View(await _context.PageContent.ToListAsync());
        }

        // GET: PageContents/Details/id
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pageContent = await _context.PageContent
                .FirstOrDefaultAsync(m => m.PageId == id);
            if (pageContent == null)
            {
                return NotFound();
            }

            return View(pageContent);
        }

        // GET: PageContents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PageContents/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PageId,TemplateKey,PageUrl,MenuText,Title,Body,ImageUrl")] Models.PageContent pageContent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pageContent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pageContent);
        }

        // GET: PageContents/Edit/id
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pageContent = await _context.PageContent.FindAsync(id);
            if (pageContent == null)
            {
                return NotFound();
            }
            return View(pageContent);
        }

        // POST: PageContents/Edit/id       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PageId,TemplateKey,PageUrl,MenuText,Title,Body,ImageUrl")] Models.PageContent pageContent)
        {
            if (id != pageContent.PageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pageContent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PageContentExists(pageContent.PageId))
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
            return View(pageContent);
        }

        // GET: PageContents/Delete/id
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pageContent = await _context.PageContent
                .FirstOrDefaultAsync(m => m.PageId == id);
            if (pageContent == null)
            {
                return NotFound();
            }

            return View(pageContent);
        }

        // POST: PageContents/Delete/id
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pageContent = await _context.PageContent.FindAsync(id);
            _context.PageContent.Remove(pageContent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PageContentExists(int id)
        {
            return _context.PageContent.Any(e => e.PageId == id);
        }
    }
}
