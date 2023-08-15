using FoodCard.Application.Services.Interfaces;
using FoodCard.Application.ViewModels;
using FoodCard.Domain.Interfaces.Repositories;

namespace FoodCard.Application.Services
{
    public class FoodCardServiceService : IFoodCardServiceService
    {
        private readonly IFoodCardServiceRepository _repository;

        public FoodCardServiceService(IFoodCardServiceRepository repository)
        {
            _repository = repository;
        }

        public Task<List<FoodCardServiceViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        //public Task<List<FoodCardServiceViewModel>> GetAll()
        //{
        //    //var search = _repository.GetAllAsync();

        //    //return search
        //    //    .Result
        //    //    .Select(x => new FoodCardServiceViewModel(x.Id, ))
        //    //    .ToList();

        //}
    }
}
