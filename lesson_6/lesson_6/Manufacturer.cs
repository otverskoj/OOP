namespace lesson_6
{
    public class Manufacturer : IManufacturer
    {
        public ManufacturerNames Name { get; set; }
        public Countries Country { get; set; }
        public int EmployeesNumber { get; set; }

        public Manufacturer()
        {
            this.Name = ManufacturerNames.Microsoft;
            this.Country = Countries.USA;
            this.EmployeesNumber = 1;
        }

        public Manufacturer(ManufacturerNames name, Countries country, int employeesNumber)
        {
            this.Name = name;
            this.Country = country;
            this.EmployeesNumber = employeesNumber;
        }
    }
}