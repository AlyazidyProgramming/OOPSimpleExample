using OOPSimpleExample;
using OOPSimpleExample.Models.Interfaces;


namespace Models
{
    public abstract class clsBaseUser : BasePerson, IUser
    {

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public enUserType UserType { get; set; }
        byte IUser.UserType { get; set; }


        /// <summary>
        /// Use this Constructor for Create New Object As new
        /// </summary>
        /// <returns></returns>
        public clsBaseUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.Email = null;
            this.Password = null;
            this.IsActive = true;
            this.CreatedAt = DateTime.Now;
            this.UserType = enUserType.User;
        }

        public new virtual void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"UserID: {UserID}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine($"IsActive: {IsActive}");
            Console.WriteLine($"CreatedAt: {CreatedAt}");
            Console.WriteLine($"UserType: {UserType}");

        }

    }
}


