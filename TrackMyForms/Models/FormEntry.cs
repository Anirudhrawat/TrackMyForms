using System.ComponentModel.DataAnnotations;

namespace TrackMyForms.Models
{
    public class FormEntry
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
    }
}
