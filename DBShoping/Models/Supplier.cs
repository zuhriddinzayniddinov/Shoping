namespace DBShoping.Models;

class Supplier
{
  public Guid SupplierId { get; set; }
  public string CompanyName { get; set; }
  public string City { get; set; }
  public string Region { get; set; }
  public string Country { get; set; }
  public string Phone { get; set; }
  public ICollection<Product> Products { get; set; }
}