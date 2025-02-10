let mutable x = 10
let mutable y = 20

let add x y = x + y

let result = add x y
printfn "%d" result //This will print 30

x <- 100 //Modifying x after it is passed to the function
y <- 200 //Modifying y after it is passed to the function

let result2 = add x y
printfn "%d" result2 //This will still print 30