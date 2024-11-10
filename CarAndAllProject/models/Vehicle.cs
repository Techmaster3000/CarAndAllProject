using System.ComponentModel.DataAnnotations;
namespace CarAndAllProject.models;

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