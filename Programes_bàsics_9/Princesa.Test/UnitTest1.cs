using FluentAssertions;
using Xunit.Sdk;
namespace princesa;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var princes = new Princesa();
        string [] armes = {""};
        var resultat = princes.contararmes(armes);
        for (int i = 0; i < resultat.Length; i++){
            Assert.Equal(0, resultat[i]);
        }
    }

    [Theory]
    
    [InlineData (10,89,30,20,3)]
    [InlineData (9,4,2,0,1)]
    [InlineData (23,0,50,-23,100)]
    [InlineData (49,21,30,20,39)]
    [InlineData (-69,-50,-94,-5,-30)]
    [InlineData (91,19,30,20,49)]
    [InlineData (-1,8,099,205,0)]
    [InlineData (0,89,30,20,0)]
    public void TestData (int a, int b, int c, int d, int e){
        var test = new Princesa();
        int [] armesnostres = {};
        armesnostres [0] = a;
        armesnostres [1] = b; 
        armesnostres [2] = c;
        armesnostres [3] = d;
        armesnostres [4] = e;
        int [] resultat = test.enviartropes(armesnostres);  //No he pogut testejar el Theory perque em diu que no pot convertir en aquesta linia de codi, de 'int[]' a 'string[]'. 
                                                            //No se perque ho diu si no hi ha cap array d'strings ni definida ni amb possibilitat de que ell per si sol la defineixi.
        for (int i = 0; i < resultat.Length; i++){
            Assert.False(resultat[i] < 0);
        }
    }
}