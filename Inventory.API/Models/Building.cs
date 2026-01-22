namespace Inventory.API.Models
{
    public class Building
    {
        public int Id { get; set; }
        public string BuildingName { get; set; } = string.Empty;

        // Navigation property
        public List<Floor> Floors { get; set; } = new List<Floor>();
    }
}