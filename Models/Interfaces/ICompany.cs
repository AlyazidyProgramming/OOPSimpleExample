namespace OOPSimpleExample.Models.Interfaces
{
    public interface ICompany
    {
        int CompanyID { get; }
        int CategoryID { get; set; }
        string Name { get; set; }
        int? AccountID { get; set; }
    }



}


