using Microsoft.AspNetCore.Mvc;
using CommunicationForm.Models;
using System;
using CommunicationForm.Data;

namespace CommunicationForm.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(Contact contact)
        {
            Console.WriteLine(contact);
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Contact.Add(contact);
                    _context.SaveChanges();
                    Console.WriteLine("Data saved successfully.");
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    Console.WriteLine($"Error saving data: {ex.Message}");
                    ModelState.AddModelError("", "An error occurred while saving data.");
                    // Return to the same view to display error message
                    return View("Index", contact);
                }
            }
            else
            {
                // ModelState is invalid, return to the same view with validation errors
                Console.WriteLine("Validation failed.");
                return View("Index", contact);
            }
        }

    }
}
