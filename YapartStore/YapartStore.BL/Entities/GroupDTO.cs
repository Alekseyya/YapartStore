using System.ComponentModel.DataAnnotations;

namespace YapartStore.BL.Entities
{
    public class GroupDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Maximum length")]
        public string Name { get; set; }
    }
}