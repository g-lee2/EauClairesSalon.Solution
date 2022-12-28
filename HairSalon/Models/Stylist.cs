using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearsOfExperience { get; set; }
    public string Rank { get; set; }
    public string Specialty { get; set; }
  }
}