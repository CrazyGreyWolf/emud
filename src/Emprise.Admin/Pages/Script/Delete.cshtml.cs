﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emprise.Admin.Data;
using Emprise.Domain.Room.Entity;
using Emprise.Domain.Script.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Emprise.Admin.Pages.Script
{
    public class DeleteModel : PageModel
    {
        protected readonly EmpriseDbContext _db;

        public DeleteModel(EmpriseDbContext db)
        {
            _db = db;
        }

        public ScriptEntity Script { get; set; }

        public string SueccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public void OnGet(int id = 0)
        {
            Script = _db.Scripts.Find(id);
        }

        public async Task<IActionResult> OnPostAsync(int id = 0)
        {
            SueccessMessage = "";
            ErrorMessage = "";
            if (!ModelState.IsValid)
            {
                ErrorMessage = ModelState.Where(e => e.Value.Errors.Count > 0).Select(e => e.Value.Errors.First().ErrorMessage).First();
                return Page();
            }

             _db.Scripts.Remove(Script);
            await _db.SaveChangesAsync();

            SueccessMessage = $"删除成功！";

            return RedirectToPage("Index");


        }
    }
}