# Unexpected Behavior with Mutable Variables in F# Functions

This example demonstrates a common pitfall in F#: the behavior of mutable variables when passed as arguments to functions.  In F#, function arguments are passed by value, meaning the function receives a copy of the variable's value, not a reference to the variable itself.  Therefore, modifications to the variable *after* it's passed to the function won't affect the function's calculations.

The `bug.fs` file contains code illustrating this. The `bugSolution.fs` provides a solution using techniques like passing the mutable variables as refs or using mutable function parameters to get the desired behavior.

## How to Reproduce

1.  Compile and run `bug.fs`.
2.  Observe the output.  You'll see that even though `x` and `y` are modified after being passed to `add`, the function's result remains unchanged.

## Solution

The `bugSolution.fs` demonstrates how to achieve the intended behavior, either using refs to modify the variable within the function or creating a mutable function parameter.