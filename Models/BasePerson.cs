using OOPSimpleExample.Models.Interfaces;


namespace Models
{


    public abstract class BasePerson : IPerson
    {

        public int PersonID { get; set; }


        public string FirstName { get; set; }


        public string LastName { get; set; }


        public string Phone { get; set; }




        /// <summary>
        /// Use this Constructor for Create New Object As new
        /// </summary>
        /// <returns></returns>
        public BasePerson()
        {

            this.PersonID = 0;
            this.FirstName = null;
            this.LastName = null;
            this.Phone = null;

        }


        /// <summary>
        /// Use this Constructor for Find Or Update Data 
        /// </summary>
        /// <returns></returns>
        private BasePerson(int PersonID, string FirstName, string LastName, string Phone)
        {

            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"PersonID: {this.PersonID}");
            Console.WriteLine($"FirstName: {this.FirstName}");
            Console.WriteLine($"LastName: {this.LastName}");
            Console.WriteLine($"Phone: {this.Phone}");
        }


    }
}

