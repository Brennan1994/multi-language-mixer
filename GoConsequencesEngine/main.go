package main

import "fmt"

// #cgo CFLAGS: -g -Wall
// #include <stdlib.h>
import "C"

func main() {
	fmt.Println("main ran")
}

//export AddInts
func AddInts(a int, b int) int {
	return a + b
}

//export AddStructs
func AddStructs(input ComplexInput) int {
	return input.A + input.B
}

//export AddAndModStructs
func AddAndModStructs(input *ComplexInput) {
	input.Sum = input.A + input.B
}

//export InitComplexInput
func InitComplexInput(a int, b int) ComplexInput{
return ComplexInput{
	A = a 
	B = b
}
}

type ComplexInput struct {
	A   int
	B   int
	Sum int
}
