using OOPSimpleExample.Models.Interfaces;

namespace Models.Users
{
    public class clsSeller : clsUser, ISeller
    {
        public int SellerID { get; set; }
        public ICompany Company { get; set; }
        public clsSeller(ICompany company)
        {
            this.Company = company;
        }
        public clsSeller()
        {

        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"SellerID: {SellerID}");
            Console.WriteLine($"Company.Name: {Company.Name}");
        }
        public int AddNewSeller(IPerson person, IUser user)
        {
            return -1;
        }
        public bool AddNewSeller()
        {
            //get new Id from AccessLayer.
            //  this.SellerID = clsSellerAccessLayer.CreateNewSeller(((BasePerson)this), ((clsUser)this), this, this.Company);
            return this.SellerID > 0;
        }
    }
}
