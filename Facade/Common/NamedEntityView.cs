using System.ComponentModel.DataAnnotations;

namespace SportEvents.Facade.Common
{
    public abstract class NamedEntityView : UniqueEntityView
    {
        [Required(ErrorMessage = "Name is required")] 
        [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name Should be 3-50 characters long")] 
        public string Name { get; set; }

    }
}
