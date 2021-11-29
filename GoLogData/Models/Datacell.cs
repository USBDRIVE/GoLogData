using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoLogData.Models
{
    public class Datacell
    {
        public string input { get; set; }
        [ForeignKey("DataModelId")]
        public DataModel? DataModel { get; set; }
        [Key]
        public Guid Id { get; set; }    
    }
}
