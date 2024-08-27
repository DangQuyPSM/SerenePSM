using MyRequest = SerenePSM.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenePSM.Administration.UserRow>;
using MyRow = SerenePSM.Administration.UserRow;

namespace SerenePSM.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}