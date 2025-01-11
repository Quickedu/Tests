namespace Carreres;
using Xunit;
using FluentAssertions;

public class UnitTest1
{
    [Fact]
    public void Test_Path(){
        var carrera = new Projecte();
        var document = new string[] { "1,2,3,4,5" };
        var s = true;
        var marca = 0;
        var jugador = carrera.obtenirjugador(document, s, marca);
        Assert.Equal(1, jugador);
    }

    [Fact]
    public void Test_bucle(){
        var carrera = new Projecte();
        carrera.jugadors = new Dictionary<int, int>();
        carrera.llargadadocument = 5;
        carrera.document = ["1,2,3,4,5", "2,3,4,5,6", "5,4,2,6,9", "4,4,6,5,1", "0,1,1,2,3"];
        carrera.s = true;
        carrera.jugador(0);
        Assert.Equal(5, carrera.jugadors.Count);
        carrera.jugadors.Should().BeEquivalentTo(new Dictionary <int, int> {{0,2},{1,3},{2,3},{4,5},{5,7}});
    }
}