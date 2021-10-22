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
        public string Color { get; set; }
    }
    public class DataModel
    {
        //connect an id here to the guid in databooks class
        [ForeignKey("DatabookId")]
        public Databooks Databooks { get; set; }

        public string Title{  get; set; }
        public string Description {  get; set; }
    }
}   
