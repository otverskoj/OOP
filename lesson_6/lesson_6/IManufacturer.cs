namespace lesson_6
{
    public interface IManufacturer
    {
        ManufacturerNames Name { get; set; }
        Countries Country { get; set; }
        int EmployeesNumber { get; set; }
    }
}