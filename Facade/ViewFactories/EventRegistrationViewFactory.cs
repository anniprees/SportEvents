using AidMethods;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Facade.Views;

namespace SportEvents.Facade.ViewFactories
{
    public static class EventRegistrationViewFactory
    {
        public static EventRegistration Create(EventRegistrationView v)
        {
            var d = new EventRegistrationData();
            Copy.Members(v, d);
            return new EventRegistration(d);
        }

        public static EventRegistrationView Create(EventRegistration o)
        {
            var v = new EventRegistrationView();
            Copy.Members(o?.Data, v);
            v.EventDate = o?.Event.EventDate;
            v.MaxParticipants = o.Event.MaxParticipants;
            v.Registrations = o.Event.RegisteredParticipants;
            return v;
        }
    }
}
