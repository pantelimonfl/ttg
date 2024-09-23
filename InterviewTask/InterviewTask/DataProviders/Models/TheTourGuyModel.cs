using System.Text.Json.Serialization;

namespace InterviewTask.DataProviders.Models
{
    public class TheTourGuyModel
    {
        [JsonPropertyName("data")]
        public List<TheTourGuyProduct> Data { get; set; }
    }

    public class TheTourGuyProduct
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("regularPrice")]
        public decimal RegularPrice { get; set; }

        [JsonPropertyName("discountPrice")]
        public decimal DiscountPrice { get; set; }

        [JsonPropertyName("maximumGuests")]
        public int MaximumGuests { get; set; }
    }
}
/*"id": 373680,
        "title": "Chichen Itza Adventure",
        "description": "Explore the ancient Mayan city of Chichen Itza, one of the New Seven Wonders of the World.",
        "averageRating": 4.97,        
        "regularPrice": 145.00,
        "discountPrice": 133.40,
        "maximumGuests": 15,*/