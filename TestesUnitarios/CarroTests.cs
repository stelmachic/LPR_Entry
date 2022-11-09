namespace TestesUnitarios;


public class CarroTests
{
    [Fact]
    public void Test1()
    {
        
    }

    [Theory]
    [InlineData("Nome", 19)]
    [InlineData("", 20)]
    public void AddCarroToUser_ShouldAddACarToAUser_WhenAUserRegistersACar(string nome, int idade)
    {
        // Arrange


        // Act
        void Action() => user.AddCarroToUser(carro);

        // Assert
        Assert.Equals(1, 1);
        Assert.Throws<Exception>(Action);
    }
}
