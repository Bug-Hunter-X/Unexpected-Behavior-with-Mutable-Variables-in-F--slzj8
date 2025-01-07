let mutable x = 10
let mutable y = 20
let mutable z = x + y
printf "%d\n" z // Output: 30
x <- 100
y <- 200
printf "%d\n" z // Output: 30 (This is unexpected)