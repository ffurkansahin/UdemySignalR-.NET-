using SignalR.DataAccessLayer;
using SignalR.EntityLayer;

namespace SignalR.BusinessLayer;

public class SocialMediaManager : ISocialMediaService
{
    private readonly ISocialMediaDAL socialMediaDAL;

    public SocialMediaManager(ISocialMediaDAL socialMediaDAL)
    {
        this.socialMediaDAL = socialMediaDAL;
    }

    public void TAdd(SocialMedia entity)
    {
        socialMediaDAL.Add(entity);
    }

    public void TDelete(SocialMedia entity)
    {
        socialMediaDAL.Delete(entity);
    }

    public SocialMedia TGetById(int id)
    {
        return socialMediaDAL.GetById(id);
    }

    public List<SocialMedia> TGetList()
    {
        return socialMediaDAL.GetList();
    }

    public void TUpdate(SocialMedia entity)
    {
        socialMediaDAL.Update(entity);    
    }
}
