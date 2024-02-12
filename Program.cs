namespace Agregar_y_restar_dias_ej7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una fecha formato (DD/MM/YYYY)");
            DateTime fechaEscogida = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero de dias a sumar");
            int numeroASumar = Convert.ToInt32(Console.ReadLine());

            
            DateTime sumarFechas = fechaEscogida.AddDays(numeroASumar);
            Console.WriteLine("Dias sumados");
            Console.WriteLine(sumarFechas.Date);

            DateTime restarFechas = fechaEscogida.AddDays(-numeroASumar);
            Console.WriteLine("Dias restados");
            Console.WriteLine(restarFechas.Date);


        }
    }
}
