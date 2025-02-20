namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try // para manejar errores
            {
                Console.WriteLine("Ingrese una operacion (+,-,*,/)");
                var operacion = Console.ReadLine();
                Console.WriteLine("Ingrese un numero");
                var num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                var num2 = Convert.ToDouble(Console.ReadLine());
                var resultado = Calcular(num1,num2,operacion);
                Console.WriteLine("El resultado es:" + resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }
             
            static double Calcular(double num1,double num2, string operacion)
            {
                var resultado = 0.0;
                switch (operacion)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;

                    case "-":
                        resultado = num1 - num2;
                        break;

                    case "*":
                        resultado = num1 * num2;
                        break;

                    case "/":
                        resultado = num1 / num2;
                        break;
                    
                }

                return resultado;

            }




        }
    }
}
