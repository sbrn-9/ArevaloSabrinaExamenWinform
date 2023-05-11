using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DotnetExam.Entities
{
    public abstract class Persona
    {

        /*Se requiere que el alumno presente:
Alumno herada de Persona 
PErsona tiene propiedades y una de ellas “NombreCompleto”, es un string (solo propiedad con get) 
Debe devolver la cadena concatenada con este formato de ejemplo: “[id] APELLIDO, Nombre”, ejemplo “[77] MESSI, Lionel”
Alumno tiene una propiedad también solo get con Aprobado, que debe devolver un bool.
 (y debe obtener si esta aprobado o no dependiendo si la nota es > 4)
Notas < 6 : Debe devolver false
Notas >= 6 : Debe devolver true


         */
       
            public int Id { get; set; }
            public string NombreCompleto { get;}
            public string Nombre { get; set; }
            public string Apellido { get; set; }


        

    }
}