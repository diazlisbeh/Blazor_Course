using System.ComponentModel.DataAnnotations;

namespace Blazor_Course.Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
    [Required]
        public string ProductId{ get; set; }
        [StringLength(100)]
    [Required]
        public string ProductName{ get; set; }
        [StringLength(600)]
        public string ProductDescription{ get; set; }
        public int  TotalQuantity{ get; set; }
    [Required]
        public string  CategotyId {get;set;}
        public CategoryEntity Category{get;set;}
        public ICollection<StorageEntity> Storages {get;set;}
    }
}