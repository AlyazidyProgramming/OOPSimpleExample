using OOPSimpleExample.Models.Interfaces;

namespace Models
{
    public class clsCompany :  ICompany
    {
        public clsCompany(string name)
        {
            Name = name;
        }

        public int CompanyID { get; set; }
        public string Name { get; set; }
        public int? AccountID { get; set; }
        public int CategoryID { get; set; }
    }
}
