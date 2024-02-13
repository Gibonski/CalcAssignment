namespace CalculatorLibrary.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        Calculator calculator = new Calculator();

        decimal result = calculator.Add(3, 4);

        Assert.Equal(7, result);
    }
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        Calculator calculator = new Calculator();

        decimal result = calculator.Add(13, 10);

        Assert.Equal(23, result);
    }
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        Calculator calculator = new Calculator();

        decimal result = calculator.Add(2, 9);

        Assert.Equal(11, result);
    }
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        Calculator calculator = new Calculator();

        decimal result = calculator.Add(5, 2);

        Assert.Equal(7, result);
    }
    [Fact]
    public void AddTest()
    {
        Calculator calculator = new Calculator();

        decimal result = calculator.Add(8, 8);

        Assert.Equal(16, result);
    } 
    [Fact]
    public void SubtractTest()
    {
        Calculator calculator = new Calculator();

         decimal result = calculator.Subtract(8, 3);

        Assert.Equal(5, result);
    }
    [Fact]
    public void SubtractTest()
    {
        Calculator calculator = new Calculator();

         decimal result = calculator.Subtract(12, 4);

        Assert.Equal(3, result);
    }
    [Fact]
    public void SubtractTest()
    {
        Calculator calculator = new Calculator();

         decimal result = calculator.Subtract(18, 2);

        Assert.Equal(9, result);
    }
    [Fact]
    public void SubtractTest()
    {
        Calculator calculator = new Calculator();

         decimal result = calculator.Subtract(120, 5);

        Assert.Equal(24, result);
    }
    [Fact]
    public void SubtractTest()
    {
        Calculator calculator = new Calculator();

         decimal result = calculator.Subtract(64, 8);

        Assert.Equal(8, result);
    }
    [Fact]
    public void MultiplyTest()
    {
        Calculator calculator = new Calculator();

         decimal result = calculator.Multiply(2, 3);

       Assert.Equal(6, result);
    }
    [Fact]
    public void MultiplyTest()
    {
        Calculator calculator = new Calculator();

         decimal result = calculator.Multiply(4, 3);

       Assert.Equal(12, result);
    }
    [Fact]
    public void MultiplyTest()
    {
        Calculator calculator = new Calculator();

         decimal result = calculator.Multiply(2, 9);

       Assert.Equal(18, result);
    }
    [Fact]
    public void MultiplyTest()
    {
        Calculator calculator = new Calculator();

         decimal result = calculator.Multiply(20, 5);

       Assert.Equal(100, result);
    }
    [Fact]
    public void MultiplyTest()
    {
        Calculator calculator = new Calculator();

         decimal result = calculator.Multiply(7, 1);

       Assert.Equal(7, result);
    }
    [Fact]
    public void DivideTest()
    {
        Calculator calculator = new Calculator();

        decimal result = calculator.Divide(10, 2);

        Assert.Equal(5, result);
    }
    [Fact]
    public void DivideTest()
    {
        Calculator calculator = new Calculator();

        decimal result = calculator.Divide(15, 3);

        Assert.Equal(5, result);
    }
    [Fact]
    public void DivideTest()
    {
        Calculator calculator = new Calculator();

        decimal result = calculator.Divide(27, 9);

        Assert.Equal(3, result);
    }
    [Fact]
    public void DivideTest()
    {
        Calculator calculator = new Calculator();

        decimal result = calculator.Divide(100, 5);

        Assert.Equal(20, result);
    }
    [Fact]
    public void DivideTest()
    {
        Calculator calculator = new Calculator();

        decimal result = calculator.Divide(81, 9);

        Assert.Equal(9, result);
    }
}