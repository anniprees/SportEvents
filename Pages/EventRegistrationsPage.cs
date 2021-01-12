using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.ViewFactories;
using SportEvents.Facade.Views;
using SportEvents.Pages.Common;

namespace SportEvents.Pages
{
    public abstract class EventRegistrationsPage : CommonPage<IEventRegistrationsRepository, EventRegistration, EventRegistrationView, EventRegistrationData>
    {
        public IEnumerable<SelectListItem> Events { get; }
        public IEnumerable<SelectListItem> Participants { get; }
        public IEnumerable<SelectListItem> OpenEvents { get; }

        protected EventRegistrationsPage(IEventRegistrationsRepository r, IEventsRepository e, IParticipantsRepository p) : base(r)
        {
            PageTitle = "Registrations";
            Events = CreateSelectList<Event, EventData>(e);
            Participants = CreateSelectList<Participant, ParticipantData>(p);
            OpenEvents = CreateOpenEventsSelect(e);
        }

        public override string ItemId => Item?.Id ?? string.Empty;

        protected internal override string GetPageUrl() => "/Sport/Registrations";

        protected internal override EventRegistration ToObject(EventRegistrationView view) => EventRegistrationViewFactory.Create(view);

        protected internal override EventRegistrationView ToView(EventRegistration obj) => EventRegistrationViewFactory.Create(obj);

        protected internal static IEnumerable<SelectListItem> CreateOpenEventsSelect(IRepository<Event> r)
        {
            var items = r.Get().GetAwaiter().GetResult();
            return items.Where(x=> x.RegisteredParticipants < x.MaxParticipants)
                .OrderBy(x=>x.EventDate)
                .Select(m => new SelectListItem(m.Data.Name, m.Data.Id)).ToList();
        }

        public string GetEventName(string eventId)
        {
            foreach (var e in Events)
                if (e.Value == eventId)
                    return e.Text;
            return "Unspecified";
        }

        public string GetParticipantName(string participantId)
        {
            foreach (var p in Participants)
                if (p.Value == participantId)
                    return p.Text;
            return "Unspecified";
        }


    }
}
