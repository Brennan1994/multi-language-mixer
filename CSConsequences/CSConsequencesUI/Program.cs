using CSConsequencesEngine;
using System.Text;

int A = 1;
int B = 2;
ComplexInput input = new() { A = A, B = B };
ComplexInputStruct inputStruct = new() { A = A, B = B };

int primsResult = Computer.Add(A, B);
int objResult = Computer.Add(input);
int structResult = Computer.Add(inputStruct);
ComplexInput output = Computer.AddAndSetSum(input);
ComplexInputStruct outputStruct = Computer.AddAndSetSum(inputStruct);
StringBuilder sb = new();
sb.Append(primsResult);
sb.Append(objResult);
sb.Append(structResult);
sb.Append(output.Sum);
sb.Append(outputStruct.Sum);

Console.WriteLine(sb.ToString());


[global::System.Runtime.InteropServices.DllImport("computer", EntryPoint = "CSharp_OSGeofGDAL_StringListDestroy___")]
 static extern void StringListDestroy(IntPtr jarg1);