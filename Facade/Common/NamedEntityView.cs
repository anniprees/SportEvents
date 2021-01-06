using System.ComponentModel.DataAnnotations;

namespace SportEvents.Facade.Common
{
    public abstract class NamedEntityView : UniqueEntityView
    {
        [Required] public string Name { get; set; }

    }
}
