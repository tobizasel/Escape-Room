 class Escape{

    public static int estadoJuego {set; get;} = 0; 

    public static void InicializarJuego(){
        string[] respuestas = {"ESCAPE",""};
        string[] pistas = {"",""};

        estadoJuego = 1;
    }

    public static bool ResolverSala(int numSala, string respuesta){

        if (numSala != estadoJuego)
        {
            return false;
        }



        return true;
    }
    
}