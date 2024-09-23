using InterviewTask.DataProviders.Models;

namespace InterviewTask.DataProviders.Contract
{
    public interface IDataProvider
    {
        public Task<List<ProductResponse>> GetProductsAsync();
    }
}