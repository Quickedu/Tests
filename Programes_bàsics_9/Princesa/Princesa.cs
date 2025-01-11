namespace princesa;
public class Princesa{
    private string[] armes = {
    "Escut", "Casc", "Espasa", "Escut", "Espasa", "Casc", "Armadura", "Llança", "Escut", "Escut", "Casc", "Armadura", "Escut", "Llança", "Espasa", "Escut", "Llança", "Escut", "Espasa", "Casc", "Casc", "Escut", "Espasa", "Llança", "Llança", "Espasa", "Armadura", "Escut", "Escut", "Armadura", "Armadura", "Llança", "Armadura", "Espasa", "Escut", "Casc", "Escut", "Espasa", "Armadura", "Armadura", "Casc", "Casc", "Llança", "Casc", "Escut", "Escut", "Llança", "Llança", "Casc", "Espasa", "Armadura", "Casc", "Armadura", "Espasa", "Llança", "Casc", "Llança", "Llança", "Espasa", "Casc", "Espasa", "Casc", "Armadura", "Casc", "Casc", "Armadura", "Llança", "Escut", "Escut", "Armadura", "Llança", "Espasa", "Casc", "Llança", "Armadura", "Espasa", "Casc", "Escut", "Armadura", "Llança", "Llança", "Casc", "Casc", "Espasa", "Armadura", "Escut", "Armadura", "Espasa", "Armadura", "Espasa", "Espasa", "Armadura", "Escut", "Armadura", "Espasa", "Casc", "Llança", "Armadura", "Casc", "Armadura", "Llança", "Casc", "Escut", "Espasa", "Casc", "Casc", "Llança", "Llança", "Armadura", "Casc", "Llança", "Llança", "Espasa", "Llança", "Armadura", "Casc", "Casc", "Escut", "Casc", "Llança", "Casc", "Escut", "Llança", "Escut", "Espasa", "Escut", "Llança", "Armadura", "Casc", "Escut", "Espasa", "Llança", "Llança", "Casc", "Escut", "Casc", "Espasa", "Escut", "Escut", "Llança", "Llança", "Llança", "Llança", "Casc", "Escut", "Armadura", "Llança", "Casc", "Espasa", "Espasa",
    };
    public void Main()
    {
        final(armes);
    }    
    public void final (string [] armes){
        var trop = tropes(armes);
        Console.WriteLine($"Podem enviar {trop[0]} cavallers, {trop[1]} soldats i {trop[2]} pagesos.");
    }
    public int [] tropes (string [] armes){
        int [] troupe = enviartropes(armes);
        return troupe;
    }
    public int [] contararmes (string[] armes){
        int [] armesnostres = {0,0,0,0,0};
        for (int i=0; i<armes.Length ; i++)
            switch (armes [i]){
                case "Escut":
                armesnostres [0]++;
                break;
                case "Llança":
                armesnostres [1]++;
                break;
                case "Espasa":
                armesnostres [2]++;
                break;
                case "Casc":
                armesnostres [3]++;
                break;
                case "Armadura":
                armesnostres [4]++;
                break;
            }
        return armesnostres;
    }

    public int [] enviartropes (string [] armes){
        int[] tropes = {0,0,0};
        var armesnostres = contararmes(armes);
        while (true){
            if (armesnostres [3]>0 && armesnostres [0]>0 && armesnostres [4]>0 && armesnostres [1]>0){
                armesnostres [0]--;
                armesnostres [1]--;
                armesnostres [3]--;
                armesnostres [4]--;
                tropes [0] ++;
            } else if (armesnostres [3]>0 && armesnostres [0]>0 && armesnostres [2]>0){
                armesnostres [0]--;
                armesnostres [2]--;
                armesnostres [3]--;
                tropes [1] ++;
                } else if (armesnostres [1]>0){
                armesnostres [1]--;
                    tropes [2] ++;
                    } else {
                        break;
                    }
        }
        return tropes;
    }
}