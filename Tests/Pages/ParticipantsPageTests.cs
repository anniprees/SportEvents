using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.Views;
using SportEvents.Pages;
using SportEvents.Pages.Common;
using Tests.Pages.Common;

namespace Tests.Pages
{[TestClass]
    public class ParticipantsPageTests: AbstractPageTests<ParticipantsPage, CommonPage<IParticipantsRepository, Participant, ParticipantView, ParticipantData>>
    {
       
    }
}
