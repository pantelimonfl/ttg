using InterviewTask.BLL.Contract;
using InterviewTask.DataProviders.Contract;
using InterviewTask.DataProviders.Models;
using InterviewTask.Models;

namespace InterviewTask.BLL.Implementation
{
    public class TourService : ITourService
    {
        private readonly IDataProvider _dataProvider;

        public TourService(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public async Task<List<ProductResponse>> GetProducts(SearchModel searchModel)
        {
            var products = await _dataProvider.GetProductsAsync();

            if (products != null) 
            {
                products = products.ApplyFilters(searchModel);
            }

            return products;
        }
    }
}
