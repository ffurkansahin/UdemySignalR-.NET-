using SignalR.DataAccessLayer;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer;

public class FeatureManager : IFeatureService
{
    private readonly IFeatureDAL featureDAL;

    public FeatureManager(IFeatureDAL featureDAL)
    {
        this.featureDAL = featureDAL;
    }

    public void TAdd(Feature entity)
    {
        featureDAL.Add(entity);
    }

    public void TDelete(Feature entity)
    {
        featureDAL.Delete(entity);
    }

    public Feature TGetById(int id)
    {
        return featureDAL.GetById(id);
    }

    public List<Feature> TGetList()
    {
        return featureDAL.GetList();
    }

    public void TUpdate(Feature entity)
    {
        featureDAL.Update(entity);
    }
}
