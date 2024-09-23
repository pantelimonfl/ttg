using System.Xml.Linq;
using InterviewTask.DataProviders.Models;
using InterviewTask.Models;

namespace InterviewTask.BLL
{
    public static class ProductFilters
    {
        public static List<ProductResponse> ApplyFilters(this List<ProductResponse> products, SearchModel filters)
        {
            return products.FilterByNumberOfGuests(filters.NumberOfGuests)
                .FilterByProductName(filters.ProductName)
                .FilterByDestination(filters.DestinationName)
                .FilterBySupplier(filters.Supplier)
                .FilterByMaxPrice(filters.MaxProductPrice)
                .ApplyPaging(filters.PageSize, filters.PageIndex);
        }

        private static List<ProductResponse> FilterByNumberOfGuests(this List<ProductResponse> productResponse, int noGuests)
        {
            return productResponse.Where(item => item.Capacity >= noGuests).ToList();
        }

        private static List<ProductResponse> FilterByProductName(this List<ProductResponse> productResponse, string name)
        {
            if (!String.IsNullOrEmpty(name) && !String.IsNullOrWhiteSpace(name))
            {
                    return productResponse.Where(item => item.ProductName.IndexOf(name, 0, StringComparison.OrdinalIgnoreCase) != -1).ToList();
            }
            return productResponse;
        }

        private static List<ProductResponse> FilterByDestination(this List<ProductResponse> productResponse, string destination)
        {
            if (!String.IsNullOrEmpty(destination) && !String.IsNullOrWhiteSpace(destination))
            {
                return productResponse.Where(item => item.Destination.IndexOf(destination, 0, StringComparison.OrdinalIgnoreCase) != -1).ToList();
            }
            return productResponse;
        }

        private static List<ProductResponse> FilterBySupplier(this List<ProductResponse> productResponse, string supplier)
        {
            if (!String.IsNullOrEmpty(supplier) && !String.IsNullOrWhiteSpace(supplier))
            {
                return productResponse.Where(item => item.SupplierName.IndexOf(supplier, 0, StringComparison.OrdinalIgnoreCase) != -1).ToList();
            }
            return productResponse;
        }

        private static List<ProductResponse> FilterByMaxPrice(this List<ProductResponse> productResponse, decimal? price)
        {
            if (price.HasValue)
            {
                return productResponse.Where(item => item.Price <= price).ToList();
            }
            return productResponse;
        }

        private static List<ProductResponse> ApplyPaging(this List<ProductResponse> productResponse, int pageSize, int pageIndex)
        {
            return productResponse.Skip(pageSize * (pageIndex-1)).Take(pageSize).ToList();
        }
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