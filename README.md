# Calculator

# String and Number Manipulation

## Multiplication

Create a console application that, given a comma separated list of
strings, prints the result of multiplying the values together.

### Example Test Cases:

- `1,2,3` → `6`
- `2,4,5` → `40`

## Squares

Add an option asking the user whether to multiply (previous case) or
square the numbers being passed in. If the user chooses square, each
number in the list should be multiplied by itself and then returned as a comma separated list.

### Example Test Cases:

- `1,2,3` → `1,4,9`
- `2,4,5` → `4,16,25`

Hint:

`int.Parse` and `string.Split(",")`

Have your app use it's own shorthand to specify the operation to perform.

- `* 2,4,5` → `40`
- `^2 2,4,5` → `4,16,25`

Have your app support sum(`+`) and division(`/`) operations.

- `+ 30,10,2` → `42`

Have your app support the average(`avg`) operation.
