

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoLogData.Models
{
    public class DataModel
    {
        //connect an id here to the guid in databooks class
        [ForeignKey("DatabookId")]
        public Databooks Databooks { get; set; }

        public string Title { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        [Key]
        public Guid ModelId { get; set; }
    }
    public class DataCell
    {
        [ForeignKey ("ModelId")]
        public DataModel? Model { get; set; }

        public int DataInput { get; set; }
        [Key]
        public Guid DataCellId { get; set; }

    }
}
