using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer;

public class EfFeatureDAL : IGenericRepository<Feature>, IFeatureDAL
{
    public EfFeatureDAL(SignalRContext context) : base(context)
    {
    }
}
