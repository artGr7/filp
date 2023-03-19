open System

let rec nod a b =
    if a % b = 0 then b
    else
        nod b (a%b)

let Euler x func init=
    let rec EulerRec x func init beg=
        if beg = 0 then init
        else
            let initnew = 
                if nod x beg = 1 then func init 
                else init
            let begnew = beg-1
            EulerRec x func initnew begnew
    EulerRec x func init x

let Div x func init=
    let rec DivRec x func init beg=
        if beg = 0 then init
        else
            let initnew = 
                if nod x beg = 1 then func beg init 
                else init
            let begnew = beg-1
            DivRec x func initnew begnew
    DivRec x func init x

[<EntryPoint>]
let main argv =
    let x = Convert.ToInt32(Console.ReadLine())
    let add = Div x (fun a b -> a+b) 0
    let mult = Div x (fun a b -> a*b) 1
    let eulernumb = Euler x (fun a -> a+1) 0
    printfn "Сумма делителей числа x, взаимно простых с ним:"
    printfn "%d" (add)
    printfn "Произведение делителей числа x, взаимно простых с ним:" 
    printfn "%d" (mult)
    printfn "Число Эйлера:"
    printfn "%d" (eulernumb)
    0
