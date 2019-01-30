using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program

    {
        static void Main(string[] args)
        {
            countryside blue = new countryside();
        }
    }
    class Village
    {
        // Node is an ADT
        // what KIND of DATA do we need in a NODE?
        public Village nextVillage;
        public String Villagename;
        public String previousVillage;
        public bool isAstrildeHere = false;

    }

    class countryside
    {
        Village Maple = new Village();
        Village Toronto = new Village();
        Village Ajax = new Village();
        Village First;
        Village Last;
        Village Temp;



        public void Launch()
        {
            Village First = Maple;
            Village Last = Ajax;
            Maple.Villagename = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousVillage = null;
            Toronto.Villagename = "Toronto";
            Toronto.nextVillage = Ajax;
            Toronto.previousVillage = "Maple";
            Ajax.Villagename = "Ajax";
            Ajax.nextVillage = null;
            Ajax.previousVillage =" Toronto";

            Console.WriteLine(this.displayMap());

        }
        public string displayMap()
        {
            string listofCities = "";
            // we need to print ALL the cities in your Area
            
                listofCities = listofCities + First.Villagename + "------- ";
                    Temp = First.nextVillage;
            listofCities = listofCities + Temp.Villagename+ "-------" ;
            
            return listofCities;
        }
    }
}
