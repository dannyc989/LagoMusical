using LagoMusicalENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LagoMusicalDAO
{
    public static class clsCancionDAO
    {
        public static List<LagoMusicalENT.CancionENT> Canciones = new List<LagoMusicalENT.CancionENT> 
        {
            new LagoMusicalENT.CancionENT
                { 
                    sonidos = new string[] {"brr","fiu","cric-cric","brrah"}
                    
                },
            new LagoMusicalENT.CancionENT 
                {   sonidos = new string[] {"pep","birip","trri-trri","croac"}
                },
            new LagoMusicalENT.CancionENT 
                { 
                    sonidos = new string[] {"bri-bri","plop","cric-cric","brrah"}

                },
        };
    }
}
