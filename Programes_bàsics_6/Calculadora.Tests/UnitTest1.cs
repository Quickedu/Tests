using FluentAssertions;

namespace TestDiana;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var test = new Testos();

        int r1 = 10;
        int r2 = 0;
        int [,] diana = new [,] {
        {0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0},
        {0 , 1 , 1 , 1 , 1 , 1 , 1 , 1 , 0},
        {0 , 1 , 2 , 2 , 2 , 2 , 2 , 1 , 0},
        {0 , 1 , 2 , 5 , 5 , 5 , 2 , 1 , 0},
        {0 , 1 , 2 , 5 , 10 , 5 , 2 , 1 , 0},
        {0 , 1 , 2 , 5 , 5 , 5 , 2 , 1 , 0},
        {0 , 1 , 2 , 2 , 2 , 2 , 2 , 1 , 0},
        {0 , 1 , 1 , 1 , 1 , 1 , 1 , 1 , 0},
        {0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0}
        };

        int tira = test.tirada (diana,r1,r2);

        tira.Should().NotBe(null);
    }
    [Theory]
    [InlineData (0,8)] //Limits
    [InlineData (-1,9)] //Fora rang
    [InlineData (1,7)] //Dins Rang
    public void TestBoundaryDiana (int r1, int r2){
        int [,] diana = new [,] {
            {0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0},
            {0 , 1 , 1 , 1 , 1 , 1 , 1 , 1 , 0},
            {0 , 1 , 2 , 2 , 2 , 2 , 2 , 1 , 0},
            {0 , 1 , 2 , 5 , 5 , 5 , 2 , 1 , 0},
            {0 , 1 , 2 , 5 , 10 , 5 , 2 , 1 , 0},
            {0 , 1 , 2 , 5 , 5 , 5 , 2 , 1 , 0},
            {0 , 1 , 2 , 2 , 2 , 2 , 2 , 1 , 0},
            {0 , 1 , 1 , 1 , 1 , 1 , 1 , 1 , 0},
            {0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0}
        };
        var test = new Testos();
        var resultat = test.tirada(diana,r1,r2);
        resultat.Should().NotBe(null);
    }
}