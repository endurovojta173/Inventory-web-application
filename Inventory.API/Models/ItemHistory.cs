namespace Inventory.API.Models
{
    public class ItemHistory
    {
        public int Id {get; set; }

        public DateTime ActionDatetime { get; set; } = DateTime.Now;

        // Foreign Key to ItemManipulationType
        public int ItemManipulationTypeId { get; set; }
        public ItemManipulationType ItemManipulationType { get; set; } = null!;

        // Foreign Key to Employee
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;

        // Foreign Key to Item
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;


    }
}