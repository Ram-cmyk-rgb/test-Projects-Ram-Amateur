using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppSQL
{
    static class  VariablesGlobales
    {
        
        // Variable privada para almacenar el valor
        private static string _globalusuario;

        // Propiedad pública para acceder y modificar el valor
        public static string globalusuario
        {
            get => _globalusuario;
            set => _globalusuario = value;
        }


        private static int _globalproductoid;

        // Propiedad pública para acceder y modificar el valor
        public static int globalproductoid
        {
            get => _globalproductoid;
            set => _globalproductoid = value;
        }

         private static int _globalclienteid;

        // Propiedad pública para acceder y modificar el valor
        public static int globalclienteid
        {
            get => _globalclienteid;
            set => _globalclienteid = value;
        }
    }
   
    
      
    

}
