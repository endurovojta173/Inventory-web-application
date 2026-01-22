using Inventory.API.Models;

namespace Inventory.API.Data
{
    public static class DbInitializer
    {  
        public static void Initialize(InventoryContext context)
        {
            // Ensure the database is created
            context.Database.EnsureCreated();
            if (context.Employees.Any())
            {
                return; // DB has been seeded
            }
            var roleAdmin = new EmployeeInventoryRole { RoleName = "Admin" };
            var roleManager = new EmployeeInventoryRole { RoleName = "Manager" };
            var roleUser = new EmployeeInventoryRole { RoleName = "User" };

            var jobDev = new Job { Name = "Developer" };
            var jobManager = new Job { Name = "Manager" };
            var jobSkladnik = new Job { Name = "Logistics operator" };

            var typeNotebook = new ItemType { ItemTypeName = "Notebook", Borrowable = true };
            var typeMonitor = new ItemType { ItemTypeName = "Monitor", Borrowable = false };
            var typeFurniture = new ItemType { ItemTypeName = "Furniture", Borrowable = false };

            var statusFine = new ItemStatus { StatusName = "Fine" };
            var statusBroken = new ItemStatus { StatusName = "Broken" };
            var statusLost = new ItemStatus { StatusName = "Lost" };
            var statusReserved = new ItemStatus { StatusName = "Reserved" };
            var statusBorrowed = new ItemStatus { StatusName = "Borrowed" };
            var statusInRepair = new ItemStatus { StatusName = "In Repair" };
            var statusFreeToUse = new ItemStatus { StatusName = "Free to Use" };
            var statusUsedNow = new ItemStatus { StatusName = "Used Now" };

            var manipCreate = new ItemManipulationType { ManipulationTypeName = "Create" };
            var manipTransfer = new ItemManipulationType { ManipulationTypeName = "Transfer" };
            var manipRepair = new ItemManipulationType { ManipulationTypeName = "Repair" };
            var manipBorrow = new ItemManipulationType { ManipulationTypeName = "Borrow" };
            var manipReturn = new ItemManipulationType { ManipulationTypeName = "Return" };

            var buildingQ = new Building { BuildingName = "A" };
            var floor1 = new Floor { FloorName = "1. Floor", Building = buildingQ };
            var floor2 = new Floor { FloorName = "2. Floor", Building = buildingQ };

            var department = new Department { DepartmentName = "Department of Development" };
            
           //Manager
            var boss = new Employee
            {
                FirstName = "Karel",
                LastName = "Šéfovský",
                Email = "karel.sef@inventorywebapp.cz",
                PhoneNumber = "+420 123 456 789",
                HomeOffice = true,
                PasswordHash = "tajnehesloHash123",
                Department = department, 
                Job = jobManager,
                EmployeeInventoryRole = roleManager
            };


            // Basic employee
            var pepa = new Employee
            {
                FirstName = "Josef",
                LastName = "Skladník",
                Email = "pepa@inventorywebapp.cz",
                PhoneNumber = "+420 987 654 321",
                HomeOffice = false,
                PasswordHash = "pepa123Hash",
                Department = department,
                Job = jobSkladnik,
                EmployeeInventoryRole = roleUser
            };

            var roomQ101 = new Room { RoomName = "01 - (Server room)", Floor = floor1, RoomManager = boss };
            var roomQ205 = new Room { RoomName = "02 - (Office)", Floor = floor2, RoomManager = pepa };

            var NotebookLenovo = new Item
            {
                ItemName = "Lenovo ThinkPad T14",
                ItemType = typeNotebook,
                Owner = boss,           
                CurrentHolder = pepa,  
                Room = roomQ205        
            };

            var monitorDell = new Item
            {
                ItemName = "Dell UltraSharp 27",
                ItemType = typeMonitor,
                Owner = pepa,
                CurrentHolder = pepa,
                Room = roomQ205
            };

            //Save entities to context, EF Core will handle relationships and automaticly fill in foreign keys
            context.Buildings.Add(buildingQ);
            context.Departments.Add (department); //With this we will add everyone related to department (boss, pepa)
            context.Items.AddRange(NotebookLenovo, monitorDell);
            
            //Add statuses,manipulation types, roles, jobs, types
            context.EmployeeInventoryRoles.AddRange(roleAdmin, roleManager, roleUser);
            context.Jobs.AddRange(jobDev, jobManager, jobSkladnik);
            context.ItemTypes.AddRange(typeNotebook, typeMonitor, typeFurniture);
            context.ItemStatuses.AddRange(statusFine, statusBroken, statusLost, statusReserved, statusBorrowed, statusInRepair, statusFreeToUse, statusUsedNow);
            context.ItemManipulationTypes.AddRange(manipCreate, manipTransfer, manipBorrow, manipRepair, manipReturn);

            //Save all to database
            context.SaveChanges();
            department.HeadOfDepartment = boss;
            context.SaveChanges();
            
            
        }
    }
}