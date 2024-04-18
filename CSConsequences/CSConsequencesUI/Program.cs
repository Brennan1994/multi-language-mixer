using CSConsequencesEngine;

int A = 1;
int B = 2;
ComplexInput input = new() { A = A, B = B };
ComplexInputStruct inputStruct = new() { A = A, B = B };

int primsResult = Computer.Add(A, B);
int objResult = Computer.Add(input);
int structResult = Computer.Add(inputStruct);
ComplexInput output = Computer.AddAndSetSum(input);
ComplexInputStruct outputStruct = Computer.AddAndSetSum(inputStruct);

Console.WriteLine(primsResult + objResult + structResult + output.Sum + outputStruct.Sum);