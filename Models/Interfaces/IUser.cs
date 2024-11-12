namespace OOPSimpleExample.Models.Interfaces
{
    public interface IUser
    {
        int UserID { get; }
        byte UserType { get; set; }
        string UserName { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        bool IsActive { get; set; }
        DateTime CreatedAt { get; set; }
    }



}


