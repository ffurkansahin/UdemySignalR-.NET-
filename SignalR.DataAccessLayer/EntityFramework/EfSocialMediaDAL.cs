using SignalR.EntityLayer;

namespace SignalR.DataAccessLayer;

public class EfSocialMediaDAL : IGenericRepository<SocialMedia> , ISocialMediaDAL
{
    public EfSocialMediaDAL(SignalRContext context) : base(context)
    {
    }
}
