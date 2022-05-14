open System

let rec multup a =
    match a with
    | 0->1
    | a -> (a%10)*multup(a/10)

let rec MaxUp a = 
    match a with 
    | a when a<>0->
        let a1 = MaxUp (a/10)
        match a1 with
        | _ when a%10>a1 -> a%10
        | a1-> a1
    | a->0
    
let rec MinUp a = 
    match a with 
    | a when a<>0->
        let a1 = MinUp (a/10)
        match a1 with
        | _ when a%10<a1 -> a%10
        | a1 -> a1
    | a->9

let rec minup a n = 
    match a with
    | a when a=0 -> n
    | a when a%10<n -> minup (a/10) (a%10)
    | a when a%10>n -> minup (a/10) n

let rec multdown x = 
    let rec multrc x a =
        match x with
        | x when x= 0-> a
        | x->           
           let x1 = x/10
           let a1 = a*(x%10)
           multrc x1 a1
    multrc x 1

let rec MinDown x =
    let rec mindown a n = 
        match a with
        | a when a=0 -> n
        | a when a%10<n ->
            let a1 =a/10
            let a2 = a%10
            mindown a1 a2
        | a ->
            let  a1 = a/10            
            mindown a1 n
    mindown  x 9

let rec MaxDown x =
     let rec maxdown a n = 
         match a with
         | a when a=0 -> n
         | a when a%10>n ->
             let a1 =a/10
             let a2 = a%10
             maxdown a1 a2
         | a ->
             let  a1 = a/10
             maxdown a1 n
     maxdown  x 0
    
[<EntryPoint>]
let main argv = 
    printfn "Введите число: "
    let x = System.Convert.ToInt32(Console.ReadLine())
    printfn "Рекурсия вниз: "
    printfn "Произведение цифр: "
    printfn "%d" (multdown x)
    printfn "Максимальное число: "
    printfn "%d" (MaxDown x)
    printfn "Минимальное число: "
    printfn "%d" (MinDown x)
    printfn "Рекурсия вверх: "
    printfn "Произведение цифр: "
    printfn "%d" (multup x)
    printfn "Минимальное число: "
    printfn "%d" (MinUp x)
    printfn "Максимальное число: "
    printfn "%d" (MaxUp x)
    0
