using LagoMusicalDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LagoMusicalENT;

namespace LagoMusicalBLL
{
    public class clsCancion : ICancion
    {
        public string getRestoCancion(string valuesonido)
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty( valuesonido))return string.Empty;

            CancionENT primerCancion = clsCancionDAO.Canciones.ToList().Where(x => x.sonidos.Contains(valuesonido)).FirstOrDefault();
            int indexSonido = primerCancion.sonidos.ToList().IndexOf(valuesonido);
            
            if (indexSonido>-1)
            {
                for (int i = indexSonido + 1; i < primerCancion.sonidos.Length; i++)
                {
                    result += primerCancion.sonidos[i] + ",";
                }    
            }
            
            if (result.Length>0) result = result.Substring(0, result.Length - 1);

            return result;

        }
    }
}
