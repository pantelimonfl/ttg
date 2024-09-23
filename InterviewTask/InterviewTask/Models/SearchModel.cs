using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace InterviewTask.Models
{
    public class SearchModel
    {
        [Required(ErrorMessage = "Number of guests should be specified.")]
        [JsonPropertyName("numberOfGuests")]
        public int NumberOfGuests { get; set; }

        [ValidateNever]
        [JsonPropertyName("productName")]
        public string ProductName { get; set; }

        [ValidateNever]
        [JsonPropertyName("destinationName")]
        public string DestinationName { get; set; }

        [ValidateNever]
        [JsonPropertyName("supplier")]
        public string Supplier { get; set; }

        [ValidateNever]
        [JsonPropertyName("maxProductPrice")]
        public decimal? MaxProductPrice { get; set; }

        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; } = 10;

        [JsonPropertyName("pageIndex")] 
        public int PageIndex { get; set; }
    }
}
/*•	Number of guests – filter the products whose maximal number of guests (capacity) is equal to or higher than this parameter
•	(Optional) Product name
•	(Optional) Destination name
•	(Optional) Supplier (can be one of the three values relating to the provided JSON files)
•	(Optional) Max price of a product
•	(Optional) Page size (default to 10 if not specified) 
•	(Optional) Page index (default to 0 if not specified)
*/