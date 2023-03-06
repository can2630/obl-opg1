using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obl1
{
    public class Car
    {
        public int Id { get; set; } 
        public string? Model { get; set; }    
        public int  Price { get; set; }  
        public string? LicensPlate { get; set; }



        public bool ValidateId()
        {
            return Id > 0;

        }
        
        
        public bool ValidateModel()
        {
            return !string.IsNullOrEmpty(Model) && Model.Length >= 4;

        }


        public bool ValidatePrice()
        {
            return Price > 0;

        }
        

        public bool ValidatelicensePlate()
        {
            return !string.IsNullOrEmpty(LicensPlate) && LicensPlate.Length >= 2 && LicensPlate.Length<= 7;

        }
      



        public void Validate()
        {
            ValidateId();
            ValidateModel();
            ValidatePrice();
            ValidatelicensePlate();
        }










    }
}
