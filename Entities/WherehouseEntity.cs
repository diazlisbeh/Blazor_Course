using System.ComponentModel.DataAnnotations;

namespace Blazor_Course.Entities;

public class WherehouseEntity{
    [Key]
    public string  WherehoueseId{ get; set; }
    [StringLength(50)]
    [Required]
    public string  WherehoueseName{ get; set; }
    public ICollection<StorageEntity> Storages{get;set;}
}

