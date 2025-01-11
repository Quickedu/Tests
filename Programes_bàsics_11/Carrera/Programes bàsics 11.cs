namespace Carrera.Test;

public class Program{
    public static void Main (){
        var carrera = new Carrera();
        carrera.intro ();
        carrera.jugador(carrera.marcas);
        carrera.escriuresposta (carrera.jugadors);

    }

}