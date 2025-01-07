let mutable x = 10
let mutable y = 20
let z = ref (x + y) // Use a mutable reference
printf "%d\n" !z // Output: 30
x <- 100
y <- 200
printf "%d\n" !z // Output: 30 (Incorrect, should be updated)
// Update the reference
z := x + y
printf "%d\n" !z // Output: 300 (Correct) 

// Alternatively use a function:
let calculateZ x y = x + y
let mutable x = 10
let mutable y = 20
let z = calculateZ x y
printf "%d\n" z
x <- 100
y <- 200
let z2 = calculateZ x y
printf "%d\n" z2 // Output: 300
