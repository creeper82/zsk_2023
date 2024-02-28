using static Input.UserInput;
using static Operations.OpsClass;
using static Operations.LogicClass;

int a = GetIntFromUser("Podaj nieujemne całkowite a");
int b = GetIntFromUser("Podaj nieujemne całkowite b");

Operation adding = new(Add);
Operation substracting = new(Substract);
Operation multipication = new(Multiply);
Operation division = new(Divide);

DisplayResult(adding, a, b);
DisplayResult(substracting, a, b);
DisplayResult(multipication, a, b);
DisplayResult(division, a, b);

Logic and = new(And);

