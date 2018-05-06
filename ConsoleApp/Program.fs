open System
open ConsoleApp.Service

[<EntryPoint>]
let main argv =
    printfn "The F# Calculator"
    printfn "Enter first number"
    let inputA = Console.ReadLine() |> int
    printfn "Enter second number"
    let inputB = Console.ReadLine() |> int
    printfn "Now type the operation you want to perform on these numbers"
    printfn "Type in any one of the following: +  -  /  *"
    let operation = Console.ReadLine()
    
    if (operation = "+") then
        printfn "Sum is: %i" (Calculator.Add inputA inputB)
    elif (operation = "-") then
        printfn "Sum is: %i" (Calculator.Sub inputA inputB)
    elif (operation = "/") then
        printfn "Sum is: %i" (Calculator.Div inputA inputB)
    else
        printfn "Sum is: %i" (Calculator.Mul inputA inputB)
    
    Console.ReadLine() |> ignore
    0

