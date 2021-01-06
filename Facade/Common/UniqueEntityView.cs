using System;
using System.ComponentModel.DataAnnotations;

namespace SportEvents.Facade.Common
{
    public abstract class UniqueEntityView
    {
        protected UniqueEntityView() => Id = Guid.NewGuid().ToString();
        [Required] public string Id { get; set; }
    }
}
