using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SportEvents.Facade.Common;

namespace SportEvents.Facade.Views
{
    public sealed class ParticipantView : NamedEntityView
    {
        [Required] public string Email { get; set; }
        [DisplayName("Phone Number")]public string PhoneNumber { get; set; }
    }
}
