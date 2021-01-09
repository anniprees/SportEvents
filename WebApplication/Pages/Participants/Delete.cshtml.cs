using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportEvents.Data;
using SportEvents.Domain.Interfaces;
using SportEvents.Infra;
using SportEvents.Pages;

namespace SportEvents.WebApplication.Pages.Participants
{
    public class DeleteModel : ParticipantsPage
    {
        public DeleteModel(IParticipantsRepository p) : base(p) {}

        public async Task<IActionResult> OnGetAsync(string id)
        {
            await GetObject(id);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            await DeleteObject(id);
            return RedirectToPage("./Index");
        }
    }
}
