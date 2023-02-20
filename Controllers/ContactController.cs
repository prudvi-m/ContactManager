using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using ContactManager.Models;

namespace ContactManager.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext context { get; set; }

        public ContactController(ContactContext ctx) {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add() {
            ViewBag.Action = "Add";
            ViewBag.Categories = context.Categories.OrderBy(g => g.Name).ToList();
            return View("Edit", new Contact());
        }

        [HttpGet]
        public IActionResult Edit(int id) {
            ViewBag.Action = "Edit";
            ViewBag.Categories = context.Categories.OrderBy(g => g.Name).ToList();
            var contact = context.Contacts.Find(id);
            return View(contact);
        }

        [HttpGet]
        public IActionResult Detail(int id) {
            ViewBag.Action = "Detail";
            ViewBag.Categories = context.Categories.OrderBy(g => g.Name).ToList();
            var contact = context.Contacts.Find(id);
            return View(contact);
        }


        [HttpPost]
        public IActionResult Edit(Contact contact,bool detail = false) {

            if(detail) {
                ViewBag.Action = "Edit";
                ViewBag.Categories = context.Categories.OrderBy(g => g.Name).ToList();
                return View(contact);
            }
            
            if (ModelState.IsValid) {
                if (contact.ContactId == 0) 
                    context.Contacts.Add(contact);
                else 
                    context.Contacts.Update(contact);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            } else {
                ViewBag.Action = (contact.ContactId == 0) ? "Add": "Edit";
                ViewBag.Categories = context.Categories.OrderBy(g => g.Name).ToList();
                return View(contact);
            }
        }

        [HttpPost]
        public IActionResult DetailEdit(Contact contact) {
            return RedirectToAction("Edit", "Contact", new { id = contact.ContactId });
        }


        [HttpGet]
        public IActionResult Delete(int id) {
            var contact = context.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact contact) {
            context.Contacts.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}