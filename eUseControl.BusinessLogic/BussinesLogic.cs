using eUseControl.BusinessLogic.Core;

namespace eUseControl.BusinessLogic
{
    public class BusinessLogic
    {
        public AdminApi Admin => new AdminApi();
        public UserApi User => new UserApi();
        public SessionBL Session => new SessionBL();
    }
}
