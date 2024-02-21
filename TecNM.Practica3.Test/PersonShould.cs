using TecNM.Practica3.Core.Enums;
using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Services;

namespace TecNM.Practica3.Test;

public class PersonShould {
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_0_AndLessThan_7735_Returns_Type1()
    {
        //arrange
        var expectedIsrType =  ISRType.type1;
        var person = new Person { salario = 0.01};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.isrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_7735_AndLessThan_65651_Returns_Type2()
    {
        //arrange
        var expectedIsrType =  ISRType.type2;
        var person = new Person { salario = 7736};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.isrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_65651_AndLessThan_115375_Returns_Type3()
    {
        //arrange
        var expectedIsrType =  ISRType.type3;
        var person = new Person { salario = 65652};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.isrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_115375_AndLessThan_134119_Returns_Type4()
    {
        //arrange
        var expectedIsrType =  ISRType.type4;
        var person = new Person { salario = 115376};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.isrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_134119_AndLessThan_160577_Returns_Type5()
    {
        //arrange
        var expectedIsrType =  ISRType.type5;
        var person = new Person { salario = 134124};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.isrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_160577_AndLessThan_323862_Returns_Type6()
    {
        //arrange
        var expectedIsrType =  ISRType.type6;
        var person = new Person { salario = 160579};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.isrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_323862_AndLessThan_510451_Returns_Type7()
    {
        //arrange
        var expectedIsrType =  ISRType.type7;
        var person = new Person { salario = 323869};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.isrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_510451_AndLessThan_974535_Returns_Type8()
    {
        //arrange
        var expectedIsrType =  ISRType.type8;
        var person = new Person { salario = 510459};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.isrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_974535_AndLessThan_1299380_Returns_Type9()
    {
        //arrange
        var expectedIsrType =  ISRType.type9;
        var person = new Person { salario = 974539};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.isrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_1299380_AndLessThan_3898140_Returns_Type10()
    {
        //arrange
        var expectedIsrType =  ISRType.type10;
        var person = new Person { salario = 1299389};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.isrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_3898140_Returns_Type11()
    {
        //arrange
        var expectedIsrType =  ISRType.type11;
        var person = new Person { salario = 3898149};
        var sut = new ISRService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.isrType);
    }
}