using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packt.Shared
{
    public class Category
    {
        //these properties map to columns in the database
        public int CategoryID {get; set;}
        public string CategoryName {get; set;}

        [Column(TypeName = "ntext")]
        public string Description {get; set;}

        //defines a nav property for related rows
        public virtual ICollection<Product> Products {get; set;}

        public Category()
        {
            //to enable devs to add products to a Category we must
            //initialize the nav property to an empty collection
            this.Products = new HashSet<Product>();
        }
    }
}