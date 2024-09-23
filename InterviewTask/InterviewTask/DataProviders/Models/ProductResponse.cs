using System.Text.Json.Serialization;

namespace InterviewTask.DataProviders.Models
{
    public class ProductResponse
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Destination { get; set; }
        public decimal Price { get; set; }
        public string SupplierName { get; set; }

        [JsonIgnore]
        public int Capacity { get; set; }
    }
}


/*The result should contain:
•	Name of the product
•	Description of the product
•	Name of the destination where the product is located
•	Price of the product in the specified currency
•	Supplier name
*/