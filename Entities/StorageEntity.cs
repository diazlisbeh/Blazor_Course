using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_Course.Entities
{
    public class StorageEntity
    {
        [Key]
       public string StorageId{ get; set; } 
    [Required]
       public string WherehoueseId{ get; set; }
       public WherehouseEntity Wherehouse {get;set;}
    [Required]
       public string ProductId {get;set;}
       public ProductEntity Product{get;set;}

       public ICollection<InputOutputEntity> InputOutputs {get;set;}
    }
}