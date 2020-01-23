using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjekt_Sebastian_Wood
{
    class Pokemon
    {

        private string förNamn = "";

        public void SkrivNamn()
        {
            Console.WriteLine(this.förNamn); //this förtydligar att det är en metod


        }


        private string land = "Frankrike"; //private string som används inom metoden GetLand och sedan hämtas till Fighter. 

        public int liv { get; set; } //är proporties och gör att man kan bästa hur värdena ska typ användas genom att sätta eller ta något. 
        public int damage { get; set; } 
        public string namn;
        public string name; //vanlig public string
        public int base_experience; //gör så att vi kan använda detta genom API senare då det skrivs inom main
        public string namePokemon = "Wood"; //samma som ovan. 




        public string GetNamn()
        {
            return namePokemon;
            

        }

        public string GetLand()
        {
            return land;

        }


    }
}
