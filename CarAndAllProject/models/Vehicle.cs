using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarAndAllProject.models;
[Table("Vehicles")]
public class Vehicle
{
    public int Id { get; set; }
    public string Merk { get; set; }
    public string Type { get; set; }
    public string Kenteken { get; set; }
    public string Kleur { get; set; }
    //set value between 1900 and 2025
    [Range(1900, 2025)]
    public int Aanschafjaar { get; set; }
    
    public string Soort { get; set; }
}