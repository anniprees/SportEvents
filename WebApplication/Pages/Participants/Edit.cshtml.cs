using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportEvents.Data;
using SportEvents.Domain.Interfaces;
using SportEvents.Infra;
using SportEvents.Pages;

namespace SportEvents.WebApplication.Pages.Participants
{
    public class EditModel : ParticipantsPage
    {
        public EditModel(IParticipantsRepository p) : base(p) { }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null) { return NotFound(); }

            await GetObject(id);

            if (Item == null) { return NotFound(); }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await UpdateObject();
            return RedirectToPage("./Index");
        }

    }
}
