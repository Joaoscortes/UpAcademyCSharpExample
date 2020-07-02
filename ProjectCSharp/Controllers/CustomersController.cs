using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectCSharp.Data;
using ProjectCSharp.Models;

namespace ProjectCSharp.Controllers {
    public class CustomersController : Controller {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public CustomersController (ApplicationDbContext context, ILogger<HomeController> logger) {
            _context = context;
            _logger = logger;
        }

        // GET: Customers
        public async Task<IActionResult> Index () {
            return View (await _context.Customers.ToListAsync ());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details (string id) {
            if (id == null) {
                return NotFound ();
            }

            var customers = await _context.Customers
                .FirstOrDefaultAsync (m => m.CustomerId == id);
            if (customers == null) {
                return NotFound ();
            }

            return View (customers);
        }

        // GET: Customers/Create
        public IActionResult Create () {
            return View ();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create ([Bind ("CustomerId,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax")] Customers customers) {
            if (ModelState.IsValid) {
                _context.Add (customers);
                await _context.SaveChangesAsync ();
                return RedirectToAction (nameof (Index));
            }
            return View (customers);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit (string id) {
            if (id == null) {
                return NotFound ();
            }

            var customers = await _context.Customers.FindAsync (id);
            if (customers == null) {
                return NotFound ();
            }
            return View (customers);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (string id, [Bind ("CustomerId,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax")] Customers customers) {
            if (id != customers.CustomerId) {
                return NotFound ();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update (customers);
                    await _context.SaveChangesAsync ();
                } catch (DbUpdateConcurrencyException) {
                    if (!CustomersExists (customers.CustomerId)) {
                        return NotFound ();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction (nameof (Index));
            }
            return View (customers);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete (string id) {
            if (id == null) {
                return NotFound ();
            }

            var customers = await _context.Customers
                .FirstOrDefaultAsync (m => m.CustomerId == id);
            if (customers == null) {
                return NotFound ();
            }

            return View (customers);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName ("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed (string id) {
            var customers = await _context.Customers.FindAsync (id);
            _context.Customers.Remove (customers);
            await _context.SaveChangesAsync ();
            return RedirectToAction (nameof (Index));
        }

        private bool CustomersExists (string id) {
            return _context.Customers.Any (e => e.CustomerId == id);
        }
    }
}