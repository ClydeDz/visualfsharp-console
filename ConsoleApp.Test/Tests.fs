namespace ConsoleApp.Test

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open ConsoleApp.Service

[<TestClass>]
type CalculatorServiceTestClass () =
    
    // Add

    [<TestCategoryAttribute("Addition")>]
    [<TestMethod>]
    member this.``Add two numbers`` () =
        let result = (Calculator.Add 10 5) |> int;
        Assert.AreEqual(result, 15);
    
    [<TestCategoryAttribute("Addition")>]
    [<TestMethod>]
    member this.``Add a postive and negative number`` () =
        let result = (Calculator.Add 5 -2) |> int;
        Assert.AreEqual(result, 3);
    
    [<TestCategoryAttribute("Addition")>]
    [<TestMethod>]
    member this.``Add zero and a positive number`` () =
        let result = (Calculator.Add 0 7) |> int;
        Assert.AreEqual(result, 7);


    // Subtract 

    [<TestCategoryAttribute("Subtraction")>]
    [<TestMethod>]
    member this.``Subtract two numbers`` () =
        let result = Calculator.Sub 10 5;
        Assert.AreEqual(result, 5);
    
    [<TestCategoryAttribute("Subtraction")>]
    [<TestMethod>]
    member this.``Subtract a postive and negative number`` () =
        let result = (Calculator.Sub 5 -2) |> int;
        Assert.AreEqual(result, 7);
    
    [<TestCategoryAttribute("Subtraction")>]
    [<TestMethod>]
    member this.``Subtract zero and a positive number`` () =
        let result = (Calculator.Sub 0 7) |> int;
        Assert.AreEqual(result, -7);


    // Divide

    [<TestCategoryAttribute("Division")>]
    [<TestMethod>]
    member this.``Divide two numbers``() =
        let result = Calculator.Div 10 5;
        Assert.AreEqual(result, 2);
    
    [<TestCategoryAttribute("Division")>]
    [<TestMethod>]
    member this.``Divide a postive and negative number`` () =
        let result = (Calculator.Div 10 -5) |> int;
        Assert.AreEqual(result, -2);
    
    [<TestCategoryAttribute("Division")>]
    [<TestMethod>]
    member this.``Divide zero and a positive number`` () =
        let result = (Calculator.Div 0 7) |> int;
        Assert.AreEqual(result, 0);



    // Multiply 

    [<TestCategoryAttribute("Multiplication")>]
    [<TestMethod>]
    member this.``Multiply two numbers`` () =
        let result = Calculator.Mul 10 5;
        Assert.AreEqual(result, 50);

    [<TestCategoryAttribute("Multiplication")>]
    [<TestMethod>]
    member this.``Multiply a postive and negative number`` () =
        let result = (Calculator.Mul 10 -5) |> int;
        Assert.AreEqual(result, -50);
    
    [<TestCategoryAttribute("Multiplication")>]
    [<TestMethod>]
    member this.``Multiply zero and a positive number`` () =
        let result = (Calculator.Mul 0 7) |> int;
        Assert.AreEqual(result, 0);