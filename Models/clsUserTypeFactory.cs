using Models.Users;
using OOPSimpleExample;

namespace Models.People
{
    public class clsUserTypeFactory
    {
        public clsUser CreateUserFactory(enUserType userType)
        {

            switch (userType)
            {
                case enUserType.User:
                    return new clsUser();
                case enUserType.Customer:
                    return new clsCustomer();
                case enUserType.Seller:
                    return new clsSeller();
                case enUserType.Admin:
                    return new clsOwner();
                default:
                    return new clsUser();
            }

        }

    }
}
