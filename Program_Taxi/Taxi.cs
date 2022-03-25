using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Taxi
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : "+DriverName);
            String statusTaxi;
            if (OnDuty = true)
            {
                statusTaxi = "Yes";
            }
            else
            {
                statusTaxi = "No";
            }
            Console.WriteLine("On Duty : " + statusTaxi);
            Console.WriteLine("Number of Passenger : " + NumPassenger);
            Console.WriteLine("");
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("Jono Sedang Menjemput penumpang");
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("Jono selesai Mengantar penumpang");
        }

    }
}
