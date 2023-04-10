
using System;
using System.Collections.Generic;
 
public class BolaOcho
{
    public static void Main()
    {
        Console.WriteLine("ingrese una pregunta que pueda responderse con si o no");
        string pregunta = Console.ReadLine();

        List<string> respuestas = new List<string>(){ "Sí, definitivamente", "Es cierto", "Es decididamente así", 
            "Sin lugar a dudas","Puedes confiar en ello","Como yo lo veo, sí", "Lo más probable"," Perspectiva buena"," Sí",
            "Las señales apuntan a que sí"," Respuesta confusa"," vuelve a intentarlo"," Vuelve a preguntar más tarde",
            "Mejor no decirte ahora"," No se puede predecir ahora", "Concéntrate y vuelve a preguntar","No cuentes con ello",
            " Mi respuesta es no"," Mis fuentes dicen que no"," Las perspectivas no son muy buenas", " Muy dudoso"};




        Random rnd = new Random();
        int indiceAleatorio = rnd.Next(respuestas.Count);
        string random = respuestas[indiceAleatorio];

        Console.WriteLine(random);
    }
}