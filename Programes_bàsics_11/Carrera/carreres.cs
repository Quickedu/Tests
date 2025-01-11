namespace Carrera.Test;
public class Carrera{


    private string [] path = {
        "C:\\DAW\\Programació\\Programes bàsics 11\\carrera1.txt",
        "C:\\DAW\\Programació\\Programes bàsics 11\\carrera2.txt",
        "C:\\DAW\\Programació\\Programes bàsics 11\\carrera3.txt",
        "C:\\DAW\\Programació\\Programes bàsics 11\\carrerasimple.txt", 
        "C:\\DAW\\Programació\\Programes bàsics 11\\carrerasimple2.txt"
    };
    private string tipuscarrera = "";
    private int input = 0;
    private string [] document = {};
    private bool s = false;
    private int marca = 0;
    public Dictionary <int,int> jugadors {get; set;}
    private int llargadadocument = 0;
    public int marcas {get;set;} = 0;

    public void jugador(int marcas){
        for (marca=marcas;marca<llargadadocument;marca++){
            var j = (obtenirjugador(document,s,marca) - 1);
            if (jugadors.FirstOrDefault(x => x.Key == j).Key == j){
                jugadors[j] += obtenirdistancies(document,marca,s); 
            } else {
                jugadors.Add(j,obtenirdistancies(document,marca,s));
            }
        }
    }
    public void intro (){
        while (true){
            Console.WriteLine("Vols analitzar carreres simples o normals? (S/N)");
            tipuscarrera = Console.ReadLine().ToLower();
            if (tipuscarrera == "s"){
                Console.WriteLine("Indica quin numero de carrera simple vols analitzar (1, 2)");
                var ok = int.TryParse(Console.ReadLine(), out input);
                document=File.ReadAllLines(path[input+2]);
                llargadadocument=document.Length;
                s = true;
                break;
            }else if (tipuscarrera == "n"){
                    Console.WriteLine("Indica quin numero de carrera normal vols analitzar (1, 2, 3)");
                    var ok = int.TryParse(Console.ReadLine(), out input);
                    document=File.ReadAllLines(path[input-1]);
                    llargadadocument=(document.Length)-1;
                    marcas=1;
                    break;
                } else {
                    Console.WriteLine("No has introduit un valor correcte!");
                    }
        }
    }

    public void escriuresposta(Dictionary <int,int> jugadors)
    {
        var guanyador = 0;
        for (int i=0; i<jugadors.Count ; i++){
            if (guanyador < jugadors [i]){
                guanyador = jugadors [i];
            }
        }
        for (int i=0; i<jugadors.Count ; i++){
        Console.WriteLine($"Jugador {i+1} {jugadors [i]}");
        }

        Console.WriteLine($"El jugador guanyador ha sigut {guanyador}");
        return;
    }

    public int obtenirjugador (string [] document, bool s, int marca){
        var jugador = 0;
        jugador = int.Parse(obtenirnumeros(document,marca,s) [0]);
        return jugador;
    }

    public string [] obtenirnumeros (string [] document, int marca , bool s){
        string [] distanciaA;
        string [] distanciaB;
        if (!s){
        distanciaA = document[marca].Split("{ ");
        distanciaB = distanciaA[1].Split(", }");
        distanciaA = distanciaB[0].Split(","); 
        } else {
            distanciaA = document[marca].Split(",");
        }
        return distanciaA;
    }

    public int obtenirdistancies (string [] document , int marca , bool s){
        int mesgran = int.Parse(obtenirnumeros(document,marca,s)[1]);
        int mespetit = int.Parse(obtenirnumeros(document,marca,s)[1]);
        for (int i=1 ; i<=4 ; i++){
            if (mesgran<int.Parse(obtenirnumeros(document,marca,s)[i])){
                mesgran=int.Parse(obtenirnumeros(document,marca,s)[i]);
            }
            if (mespetit>int.Parse(obtenirnumeros(document,marca,s)[i])){
                mespetit=int.Parse(obtenirnumeros(document,marca,s)[i]);
            }
        }

        var distancia = mesgran-mespetit;
        return distancia;
    }
}