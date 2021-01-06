using System.ComponentModel;
using SportEvents.Facade.Common;

namespace SportEvents.Facade.Views
{
    public sealed class SportsCategoryView : NamedEntityView
    {
        public string Location { get; set; }
        [DisplayName("Number of spots")]public int MaxParticipants { get; set; }

    }
}
