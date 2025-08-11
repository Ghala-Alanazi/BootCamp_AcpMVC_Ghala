using System.ComponentModel.DataAnnotations;

namespace BootCamp_AcpMVC_Ghala.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

    }
}
