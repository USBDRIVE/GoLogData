using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoLogData.Models
{
    public class Databooks
    {
        [Key]
        public Guid Id { get; set;  }
        public string Title { get; set; }
        public string Description { get; set; }
        public Boolean MultipleModels { get; set; }
    }
    
}   
