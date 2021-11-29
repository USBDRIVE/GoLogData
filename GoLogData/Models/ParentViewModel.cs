using System.ComponentModel.DataAnnotations;

namespace GoLogData.Models
{
    public class ParentViewModel
    {

        public Databooks? Databook { get; set; }

        public Datacell? Datacell { get; set; }

        public DataModel? DataModel {  get; set; }
        [Key]
        public Guid ParentViewModelId {  get; set; }
    }
}
