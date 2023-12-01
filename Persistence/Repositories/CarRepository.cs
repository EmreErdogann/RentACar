using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Persistence.Contexts;

public class CarRepository : EfRepositoryBase<Car, Guid, BaseDbContext>, ICarRepository
{
    public CarRepository(BaseDbContext context) : base(context)
    {

    }
}