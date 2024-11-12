using Models;
using Models.Users;
using OOPSimpleExample.Models.Interfaces;

namespace OOPSimpleExample
{
    //simple Example for OOP as Simple requriement of Online Store App
    internal class Program
    {
        static void Main(string[] args)
        {

            // clsBaseUser user = new clsBaseUser();  //error abstract class // not allowed to create instance

            clsBaseUser user = new clsUser();
            //prop from clsPerson class
            user.FirstName = "Saleh";

            //prop from clsBase user
            user.UserName = "Ssss";

            user.PrintInfo();

            //principles of polymorphism user comes be seller
            user = new clsSeller(new clsCompany("SpotLight"));

            Console.WriteLine(((clsSeller)user).Company.Name);

            clsSeller seller = new clsSeller()
            {
                //initialize prop of clsPerson class
                FirstName = "Saleh",
                LastName = "Alyazidy",

                //initialize prop of clsBaseUser class
                UserName = "spsps",
                Password = "00000",

                //initialize prop of clsSeller class
                Company = new clsCompany("SpotLight"),
            };

            //to insert data in db you must following these steps:
            //seller is a user
            //user is a person
            seller.AddNewSeller((IPerson)seller, (IUser)seller);
            seller.AddNewSeller((BasePerson)seller, (clsUser)seller);

            seller.SellerID = AddNewSeller(seller, (BasePerson)seller, (clsUser)seller);
            //Function in seller business layer must be as this lien:

            // this.SellerID = clsSellerAccessLayer.CreateNewSeller(((BasePerson)this), ((clsUser)this), this, this.Company);

            //This is an example of how an object is transformed from one form to another==>principles of polymorphism.
            //clsSellerAccessLayer.
            //    CreateNewSeller((IPerson)seller, (IUser)seller, seller, seller.Company);

            seller.PrintInfo();

            // don't repate code
            /*
           //method in PersonClass
           public virtual void PrintInfo()
           {
               Console.WriteLine($"PersonID: {this.PersonID}");
               Console.WriteLine($"FirstName: {this.FirstName}");
               Console.WriteLine($"LastName: {this.LastName}");
               Console.WriteLine($"Phone: {this.Phone}");
           }

           //method in BaseUser Class
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

           //method in seller Class
           public override void PrintInfo()
           {
               base.PrintInfo();
               Console.WriteLine($"SellerID: {SellerID}");
               Console.WriteLine($"Company.Name: {Company.Name}");
           }
          */
        }


        static int AddNewSeller(ISeller seller, IPerson person, IUser user) => 1;
    }
}
