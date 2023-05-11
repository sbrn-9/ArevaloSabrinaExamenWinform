using DotnetExam.Entities;

namespace DotnetExam.Tests
{
    public class Exam_44646824_ArévaloSabrinaAyelen
    {



        [Fact]
        public void Test_1_Teoria_Winform()
        {

            //Que es winform en .NET con sus palabras.  ¿Para que se utiliza?  ¿Donde se puede desplegar o ejecutar (en cuales clientes)?
            var respuesta = "Winform en .Net es una interfaz visual la cual se utiliza para poder correr el código en aplicaciones de escritorio, las cuales van a poder ser utilizadas por los usuarios finales";

            Assert.NotEmpty(respuesta);



        }


        [Fact]
        public void Test_2_Teoria_Eventos()
        {

            //¿Cuál es la diferencia entre el evento Click y el evento Load en un botón de WinForms?
            var respuesta = "La diferencia entre los eventos click y load es que para poder acceder los datos se debe generar un click en algún botón del Winform, en cambio con load el acceso a datos se da antes de la carga del formulario";

            Assert.NotEmpty(respuesta);



        }


        [Fact]
        public void Test_3_Teoria_Delegados()
        {

            //¿Qué es un delegado en C# y cuál es su propósito principal?
            var respuesta = "Un delegado en C# es como un puntero que tiene como propósito principal referenciar métodos con sus respectivos datos y parámetros";

            Assert.NotEmpty(respuesta);


        }



        [Fact]
        public void Test_4_DemoMaterias()
        {

            var materias = MateriaGenerador.Generar(cantidad: 100, alumnosPorMateria: 25);


            Assert.NotEmpty(materias);
            Assert.Equal(100, materias.Count());
            Assert.Equal("Materia 1", materias.First().Nombre);
            Assert.Equal(1, materias.First().Alumnos.First().AlumnoId);
            Assert.True(materias.First().Alumnos.First().Nota > 0);
            Assert.IsType<bool>(materias.First().Alumnos.First().Aprobado());


        }


    }
}