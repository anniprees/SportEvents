using AidMethods;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Facade.Views;

namespace SportEvents.Facade.ViewFactories
{
    public static class ParticipantViewFactory
    {
        public static Participant Create(ParticipantView v)
        {
            var d = new ParticipantData();
            Copy.Members(v, d);
            return new Participant(d);
        }

        public static ParticipantView Create(Participant o)
        {
            var v = new ParticipantView();
            Copy.Members(o?.Data, v);
            return v;
        }
    }
}
