using InterviewTask.DataProviders.Models;
using InterviewTask.Models;

namespace InterviewTask.BLL.Contract
{
    public interface ITourService
    {
        public Task<List<ProductResponse>> GetProducts(SearchModel searchModel);
    }
}
