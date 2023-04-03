namespace Clase1.Logica
{
    public class Calculadora
    {
        //metodo de instancia
        /*  public int Sumar(int a, int b) 
          {
              return a + b;
          }

      */
        //Metodo estatico

        public static int Sumar(int nro1, int nro2)
        {
            return nro1 + nro2;
        }
        //sobrecarga de metodo
        public static int Sumar(string val1, string val2)
        {
            return Sumar(int.Parse(val1), int.Parse(val2));
        }
    }
}