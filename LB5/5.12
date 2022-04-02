(* Задание 12 Предыдущую программу реализовать в функции main с
помощью только оператора суперпозиции, потом только с помощью
оператора каррирования.*)

open System

[<EntryPoint>]
let main argv =
    let otvet s =
        match s with
        | "F#" ->  "Подлиза!"
        | "Prolog" -> "Подлиза!"
        | s -> "Хороший выбор"

    printfn "Ваш любимый язык?"
    let s = Console.ReadLine()
    printfn "Каррирование:"
    printfn "%s" (otvet s) 
    printfn "Суперпозиция:"
    (Console.ReadLine >> otvet >> Console.WriteLine)()
    0
