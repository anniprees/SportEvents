using System;
using System.Collections.Generic;
using System.Text;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.ViewFactories;
using SportEvents.Facade.Views;
using SportEvents.Pages.Common;

namespace SportEvents.Pages
{
    public abstract class ParticipantsPage : CommonPage<IParticipant, Participant, ParticipantView, ParticipantData>
    {
        protected ParticipantsPage(IParticipant r) : base(r)
        {
            PageTitle = "Participants";
        }

        protected internal override string GetPageUrl() => "/Sport/Participants";

        protected internal override Participant ToObject(ParticipantView view) => ParticipantViewFactory.Create(view);

        protected internal override ParticipantView ToView(Participant obj) => ParticipantViewFactory.Create(obj);

    }
}
