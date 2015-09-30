using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace Pfunware.Models
{
    public class DefinitionViewModel
    {
        [Key]
        public int DefinitionId { get; set; }
        public int Order { get; set; }
        public string Category { get; set; }
        public string Technology { get; set; }
        public string Word { get; set; }
        public string Definition { get; set; }
    }
}