namespace DotnetExam.Entities
{
    public class Alumno : Persona
    {
        public int AlumnoId { get; set; }
        public string Legajo { get; set; }
        public int Nota { get; set; }


        public List<Persona> NombreCompleto(string buscar)
        {

            var lista = new List<Persona>();

            //Carga de datos en Email()

            for (int i = 0; i < 100; i++)
            {
                lista.Add(new Alumno()
                {
                    Id = i,
                    Nombre = $"Leonel",
                    Apellido = $"MESSI"


                });
            }

            return lista;
        }


        public bool Aprobado()
        {

            if (Nota>=6)
            {
                return true;
            }
            else
            {
                return false;
            }


        }




    }

    
}