namespace DotnetExam.Entities
{
    public class Materia
    {
        public int MateriaId { get; set; }
        public string Nombre { get; set; }
        public List<Alumno> Alumnos { get; set; }


        public Materia(int materiaId, string nombre)
        {
            MateriaId = materiaId;
            Nombre = nombre;

            Alumnos = new List<Alumno>();
        }


        public Materia()
        {
            Alumnos = new List<Alumno>();        
        }

        public List<Materia>  Cargar(string text)
        {

            var materias = new List<Materia>();

            //Carga de datos en Email()

            for (int i = 0; i < 100; i++)
            {

                    if (i < 25)
                    {
                    materias.Add(new Materia()
                    {
                        MateriaId = i,
                        Nombre = $"Lengua {text} {i}"
                    });


                }else if (i >= 25 && i < 45)
                    {
                    materias.Add(new Materia()
                    {
                        MateriaId = i,
                        Nombre = $"Matemática {text} {i}"
                    });
                }else if (i >= 45 && i < 70)
                    {
                    materias.Add(new Materia()
                    {
                        MateriaId = i,
                        Nombre = $"Geografía {text} {i}"
                    });
                }else
                    {
                        materias.Add(new Materia()
                        {
                            MateriaId = i,
                            Nombre = $"Programación {text} {i}"
                        });
                    }
                    
            }


        }
}
}