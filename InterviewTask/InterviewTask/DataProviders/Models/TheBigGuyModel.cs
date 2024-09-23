using System.Text.Json.Serialization;

namespace InterviewTask.DataProviders.Models
{
    public class TheBigGuyModel
    {
        [JsonPropertyName("ProductData")]
        public List<TheBigGuyProductData> ProductData { get; set; }
    }

    public class TheBigGuyProductData
    {
        [JsonPropertyName("productDetailData")]
        public TheBigGuyProductDetailData ProductDetailData { get; set; }

        [JsonPropertyName("price")]
        public TheBigGuyPrice Price { get; set; }
    }

    public class TheBigGuyProductDetailData
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("productDescription")]
        public string ProductDescription { get; set; }

        [JsonPropertyName("capacity")]
        public int Capacity { get; set; }
    }
    public class TheBigGuyPrice
    {
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        [JsonPropertyName("appliedDiscount")]
        public decimal AppliedDiscount { get; set; }
    }
}


/*"ProductData": [
        {
            "productDetailData": {
                "id": 121145,
                "name": "Golden Circle Full-Day Tour with Gullfoss, Geysir, and Þingvellir",
                "productDescription": "Explore Iceland's natural wonders including the Gullfoss waterfall, the Geysir geothermal area, and Þingvellir National Park.",
                "averageStars": 4.95,
                "capacity": 7
            },
            "price": {                
                "amount": 159.45,
                "appliedDiscount": 0.1
            },
            "photos": [
                "64b0deea-f2b7-4a73-8967-deeae9da8b34.jpg",
                "c02dd763-69bc-42eb-9595-931df6a4c17f.jpg",
                "57cbd826-2f73-4be4-a031-5926b0e63278.jpg",
                "a7c59cc2-675d-40b2-a284-ba4107d58161.jpg",
                "e0793f68-3fee-40bd-b387-94416dea0063.jpg"
            ]
        },*/