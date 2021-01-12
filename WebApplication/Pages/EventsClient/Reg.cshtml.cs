using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportEvents.Domain.Interfaces;
using SportEvents.Pages;

namespace SportEvents.WebApplication.Pages.EventsClient
{
    public class RegisterModel : EventRegistrationsPage
    {
        public RegisterModel(IEventRegistrationsRepository r, IEventsRepository e, IParticipantsRepository p)
         : base(r, e, p) { }

        //public async Task<IActionResult> OnGet(string id)
        //{
        //    if (id == null) { return NotFound(); }

        //    await GetObject(id);
        //    Item.EventId = id;
        //    Item.ParticipantId = "2";

        //    if (Item == null) { return NotFound(); }
        //    return Page();

        //}

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!await AddObject()) return Page();
        //    return RedirectToPage("./Index");
        //}
    }
}
