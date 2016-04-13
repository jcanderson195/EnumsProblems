using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsProblems
{
    class HumaneSociety
    {

        enum species {Dog, Cat, Rabbit, Bird }

        enum dogBreed {Beagel, Pitbull, Rotweiler }
        enum dogName {Spike, Bruce, Tory }
        

        enum catBreed {Persian, Bengal, Ragdoll }
        enum catName {Milo, Whiskers, Smoky }

        enum rabbitsBreed {Angora, Lop, American }
        enum rabbitName {Floppy, Thumper, Fluffy}

        enum birdBreed {Robin, Canary, Hummingbird }
        enum birdName {Robby, Carrie, Larry }

        public void DisplayTracker()
        {
            Console.WriteLine("Animal: "+species.Dog +"| Breed: "+dogBreed.Beagel +"| Name: "+dogName.Bruce +"| Age: 2");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Animal: " + species.Dog + "| Breed: " +dogBreed.Pitbull +"| Name: " +dogName.Spike +"| Age: 1");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Animal: " + species.Dog + "| Breed: " +dogBreed.Rotweiler +" Name: " +dogName.Tory +" Age: 1");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Animal: " +species.Cat +"| Breed: " +catBreed.Bengal +"| Name: " +catName.Milo +"| Age: 1");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Animal: " + species.Cat + "| Breed: " +catBreed.Persian +"| Name: " +catName.Smoky +"| Age: 2");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Animal: " + species.Cat + "| Breed: " +catBreed.Ragdoll +"| Name: " +catName.Whiskers +"| Age: 1");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Animal: " +species.Rabbit +"| Breed: " +rabbitsBreed.American +"| Name: " +rabbitName.Floppy +"| Age: 3");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Animal: " + species.Rabbit + "| Breed: " +rabbitsBreed.Angora +"| Name: " +rabbitName.Fluffy +"| Age: 3");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Animal: " + species.Rabbit + "| Breed: " +rabbitsBreed.Lop +"| Name: " + rabbitName.Thumper+"| Age: 3");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Animal: " + species.Bird + "| Breed: " +birdBreed.Canary +"| Name: " +birdName.Carrie +"| Age: 3");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Animal: " + species.Bird + "| Breed: " +birdBreed.Hummingbird +"| Name: " +birdName.Larry +"| Age: 3");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Animal: " + species.Bird + "| Breed: " +birdBreed.Robin +"| Name: " +birdName.Robby +"| Age: 3");
        }


    }

    
}
