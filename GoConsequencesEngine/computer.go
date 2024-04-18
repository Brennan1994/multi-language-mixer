package main

import "fmt"

func main() {
	fmt.Println("main ran")
}

func AddInts(a int, b int) int {
	return a + b
}

func AddStructs(input ComplexInput) int {
	return input.A + input.B
}

func AddAndModStructs(input *ComplexInput) {
	input.Sum = input.A + input.B
}

type ComplexInput struct {
	A   int
	B   int
	Sum int
}
