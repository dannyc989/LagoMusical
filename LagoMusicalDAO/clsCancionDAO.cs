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
                    //lstsonido= new List< SonidoENT> {  
                    //        new SonidoENT { sonido="brr" },
                    //        new SonidoENT { sonido="fiu" },
                    //        new SonidoENT { sonido="cric-cric" },
                    //        new SonidoENT { sonido="brrah" },
                    //    }
                    
                },
            new LagoMusicalENT.CancionENT 
                { 
                    sonidos = new string[] {"pep","birip","trri-trri","croac"}
                    //lstsonido= new List< SonidoENT> {  
                    //        new SonidoENT { sonido="pep" },
                    //        new SonidoENT { sonido="birip" },
                    //        new SonidoENT { sonido="trri-trri" },
                    //        new SonidoENT { sonido="croac" },
                    //    }
                },
            new LagoMusicalENT.CancionENT 
                { 
                    sonidos = new string[] {"bri-bri","plop","cric-cric","brrah"}
                    //lstsonido= new List< SonidoENT> {  
                    //        new SonidoENT { sonido="bri-bri" },
                    //        new SonidoENT { sonido="plop" },
                    //        new SonidoENT { sonido="cric-cric" },
                    //        new SonidoENT { sonido="brrah" },
                    //    }
                },
        };
    }
}
