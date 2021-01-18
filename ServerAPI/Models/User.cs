
using System.ComponentModel.DataAnnotations;

namespace ServerAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
