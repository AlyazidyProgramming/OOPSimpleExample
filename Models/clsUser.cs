
using OOPSimpleExample.Models.Interfaces;

namespace Models
{
    public class clsUser : clsBaseUser
    {
        public clsUser() : base()
        {

        }

        /// <summary>
        /// Use this Constructor for Find Or Update Data 
        /// </summary>
        /// <returns></returns>
        public clsUser(IPerson personInfo, string email
        , string Password, bool IsActive, DateTime CreatedAt)
        {

            this.UserID = -1;
            this.PersonID = personInfo.PersonID;
            this.Email = email;
            this.Password = Password;
            this.IsActive = IsActive;
            this.CreatedAt = CreatedAt;
        }

        private clsUser(int userID, int personID, string userName, string email, string password, bool isActive, DateTime createdAt)
        {
            UserID = userID;
            PersonID = personID;
            UserName = userName;
            Email = email;
            Password = password;
            IsActive = isActive;
            CreatedAt = createdAt;
        }

    }
}


