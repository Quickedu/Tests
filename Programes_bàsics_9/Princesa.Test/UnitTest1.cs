namespace princesa;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var princes = new Princesa();
        string [] armes = {""};
        var final = princes.contararmes(armes);
        Assert.Equal(0 , final [0]);
    }
}