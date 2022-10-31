using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_Course.Entities;

public class InputOutputEntity{
    [Key]
    public string InputOutputId{ get; set; }
    [Required]
    public DateTime Date{ get; set; }
    public int Quantity{ get; set; }
    [Required]
    public bool IsInput{ get; set; }
    // [ForeignKey("")]
   // public string StorageId{ get; set; }
    [Required]

    public string StorageId {get;set;}
    public StorageEntity Storage {get;set;}
}