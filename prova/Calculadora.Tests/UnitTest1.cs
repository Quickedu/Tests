namespace TestDiana;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var p1 = 10;
        var p2 = 0;
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

        int [] tira = tirada (diana,r1,r2);

        tira[0].should()
    }

}