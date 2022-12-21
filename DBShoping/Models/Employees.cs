namespace DBShoping.Models;

public class Employee
{
  public Guid EmployeeId { get; set; }
  public string  LastName { get; set; }
  public string FirstName { get; set; }
  public DateTimeOffset BirthDate { get; set; }
  public DateTimeOffset HireDate { get; set; }
  public string Region { get; set; }
  public string City { get; set; }
  public string Country { get; set; }
  public string HomePhone { get; set; }
  public ICollection<Order> Orders { get; set; }
}