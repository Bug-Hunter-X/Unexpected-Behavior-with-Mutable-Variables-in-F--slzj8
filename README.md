# Unexpected Behavior with Mutable Variables in F#

This repository demonstrates a common, yet subtle, error in F# related to the behavior of mutable variables.  When working with mutable variables, it's crucial to understand that the expression's result isn't dynamically updated after the variable's mutation.  The initial calculation of the expression is fixed.