namespace USParksAPI.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string ParkType { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Description { get; set; }
  }
}