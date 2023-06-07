 class Escape{

    public static int estadoJuego {set; get;} = 0; 
    public static string[] respuestas = {"no respuesta","ESCAPE",""};

    public static void InicializarJuego(){
        string[] pistas = {"",""};

        estadoJuego = 1;
    }
    
    public static bool ResolverSala(int numSala, string respuesta){

        Console.WriteLine(numSala + " " + respuesta + "peterico" + respuestas[numSala-1] + " " + estadoJuego);

        if ((numSala == estadoJuego) && respuestas[numSala - 1] == respuesta.ToUpper())
        {
            return true;
        }
        return false;
    }
    
}