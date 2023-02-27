using System.ComponentModel.DataAnnotations;

namespace IndustrialMachineparkAzure.Shared.Entities
{
    public class Machine
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("n");

        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Type { get; set; } = string.Empty;

        public bool Status
        {
            get; set;
        }
        public DateTime? Updated
        {
            get; set;
        }
    }
}