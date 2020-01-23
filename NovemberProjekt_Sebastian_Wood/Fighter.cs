using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProjekt_Sebastian_Wood
{
    class Fighter : Pokemon
    {

        //November projektet https://docs.google.com/document/d/1yq2iMCWW1evud5j2w06oY-7UlK2kkZyRHN2aPLlqpwE/edit
        //länk till förbättring av uppgift https://docs.google.com/document/d/1vGPFEwBT7Cgsr2GRepkBtxf4BHQ0uAZSRrCgae3Cj0o/edit
        //Förbättringar jag kan göra Fightsim https://docs.google.com/document/d/1ZdpWBHRACxliu96YqYZsBaieMKhUzs6eLG--nlUT-4s/edit
        //bra info
        //konstruktor är en metod inom klass som kör när en klass instans kör. 
        //Arv är egentligen på hur man använder en klass till en annan som skapas då samtidigt. 

        private string names = "Sebastian"; //private string som returnas i metoden nedan så den kan användas i main
        public string TaNamn() //metod inom klass
        {
            return names; //returnerar names så att den kan användas
        }



            public Fighter()  //publika värden som kan användas i main. 
        {
            namn = "Nu skriv in namn på din fighter!"; //gjorde den här string arvet från pokemon som en ConsoleWriteline bara för att testa. 
            
          liv = 10; //arvs från klassen pokemon och som kan användas inom main. 

        damage = 5;
    }

    //this.liv = liv;


    public void PrintInfo()
        {
            
            Console.WriteLine(GetNamn());
            Console.WriteLine(GetLand()); //hämtar land från metoden GetLand i Pokemon klassen. 
        }

       
        public int Attack() //en metod som skulle användas till själva fighting sekvensen. 
        {

            return damage;


        }

        public void Hurt() //samma tillanvändo som metoden Attack ovan. 
        {




        }



        public int GetHp() //med hjälp av bool 
        {

            return liv;



        }

        


        public bool IsAlive() //med hjälp av bool skulle man kunna returna om det är sant eller falsk ifall fightern lever. 
        {
            return liv > 0; //returnar liv ifall den är över noll. 
        }


    }
}
