using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_GENERAL.CLASES
{
    internal class Global
    {
        static public string bd = "BD_ESCOLAR";
        static public string server = @"E5\S1";
        static public string User = "sa";
        static public string Password="hola1234";
        static public string seguridad = "Persist Security Info=True";
        static public string miconexion = "Data Source=" + server + ";Initial Catalog=" + bd + ";"+
            seguridad+";User ID=" + User+";Password="+Password+";Encrypt=False";
        
        //Data Source=e5\s1;Initial Catalog=BD_ESCOLAR;Persist Security Info=True;User ID=sa;Password=***********;Encrypt=False
    }//data adapter almacena 4 comandos. 
}
