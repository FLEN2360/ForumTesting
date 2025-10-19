using ForumTesting.Data;
using ForumTesting.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForumTesting.Controllers
{
    public class MessagesController : Controller
    {
        private readonly MessageContext _context;

        public MessagesController(MessageContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var list = await _context.Messages
                .OrderByDescending(m => m.CreatedAt)
                .ToListAsync();
            return View(list);
        }

        [HttpGet]
        // GET: /Messages/Create
        public IActionResult Create() => View();

        // POST: /Messages/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Content")] Message msg)
        {
            if (!ModelState.IsValid) return View(msg);

            msg.CreatedAt = DateTime.UtcNow;
            _context.Add(msg);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: /Messages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var msg = await _context.Messages.FindAsync(id);
            if (msg == null) return NotFound();
            return View(msg);
        }

        // POST: /Messages/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Content")] Message msg)
        {
            if (id != msg.Id) return BadRequest();
            if (!ModelState.IsValid) return View(msg);

            try
            {
                // 取現存紀錄並更新需要的欄位以避免 overposting
                var existing = await _context.Messages.FindAsync(id);
                if (existing == null) return NotFound();
                existing.Name = msg.Name;
                existing.Content = msg.Content;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // 若用 RowVersion 可以更完整處理
                throw;
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: /Messages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var msg = await _context.Messages.FirstOrDefaultAsync(m => m.Id == id);
            if (msg == null) return NotFound();
            return View(msg);
        }

        // POST: /Messages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var msg = await _context.Messages.FindAsync(id);
            if (msg != null)
            {
                _context.Messages.Remove(msg);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: /Messages/Read/5
        public async Task<IActionResult> Read(int? id)
        {
            if (id == null) return NotFound();
            var msg = await _context.Messages.FindAsync(id);
            if (msg == null) return NotFound();
            return View(msg);
        }
    }
}
