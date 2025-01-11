using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace TestDiana{

public class Program{

    public static void Main (){
        var test = new Testos();
        test.run();
        var p1 = test.p1;
        var p2 = test.p2;
        test.final(p1,p2);
        }
    } 
}