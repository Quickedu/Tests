namespace princesa;
public class Program{
    public static void Main (){
        var princes = new Princesa();
        princes.contararmes(princes.armes);
        princes.Run();
        princes.armesnostres = princes.contararmes(princes.armes);
    }
}