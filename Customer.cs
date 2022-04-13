using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace Packt.Shared
{
  public class Customer
  {
    // these properties map to columns in the database 
    public int CustomerID { get; set; }
    public string CompanyName { get; set; } // NOT CustomerName !!
    // defines a navigation property for related rows
    public virtual ICollection<Customer> Customers { get; set; }
    public Customer()
    {
      // to enable developers to add products to a Customer we must
      // initialize the navigation property to an empty collection 
      this.Customers = new HashSet<Customer>();
    }
  }
}