using System.Text.Json.Serialization;

namespace InterviewTask.DataProviders.Models
{
    public class SomeOtherGuyModel
    {
        [JsonPropertyName("Products")]
        public List<SomeOtherGuyProduct> Products { get; set; }
    }

    public class SomeOtherGuyProduct
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("productDescription")]
        public string ProductDescription { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("discountPercentage")]
        public decimal DiscountPercentage { get; set; }

        [JsonPropertyName("capacity")]
        public int Capacity { get; set; }
    }
}

/*"Products": [
      {
        "id": 1,
        "name": "Bangkok Grand Palace and Wat Arun Tour",
        "productDescription": "Discover the iconic Grand Palace and Wat Arun in Bangkok.",
        "ratingStatistics": {
          "totalNumberOfReviews": 200,
          "totalRating": 900
        },
        "price": 50.00,
        "discountPercentage": 10,
        "capacity": 20,
        "imageUrls": [
          "tour1_1.jpg",
          "tour1_2.jpg",
          "tour1_3.jpg"
        ]
      },*/