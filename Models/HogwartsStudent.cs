#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Practice.Models;
public class HogwartsStudent
{
    [Required]
    [MinLength(3)]
    public string Name {get;set;}
    public string House {get;set;}
    public int CurrentYear {get;set;}
}
