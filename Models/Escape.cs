 class Escape{

    public static int estadoJuego {set; get;} = 0; 
    public static string[] respuestas = {"no","ESCAPE","no", "223176", "respuesta5", "respuesta6"};

    public static string InicializarSala(int numPista){
        string[] pistas = {"Suerte en el juego!","Presta atención a las notas con letras rojas", "Busca la llave oculta", "Acordate de abrir la puerta!!", "Cada palabra representa un número", "pista6"};

        return pistas[numPista -1];
    }


    
    public static bool ResolverSala(int numSala, string respuesta){

        Console.WriteLine(numSala + " " + respuesta + "peterico" + respuestas[numSala-1] + " " + estadoJuego);

        if (respuestas[numSala - 1] == respuesta.ToUpper())
        {
            return false;
        }
        return true;
    }
    
}