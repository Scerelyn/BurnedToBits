<Query Kind="Statements" />

string input = "OOOOO6666666666iiiiwwwwwwwweppppppppnn00VFFfffffffPHHkk4yyyyMWWWWWWWWWWWkk77777";

var counter = 1;
var curChar = input.First();
var output = new StringBuilder();
for(int i = 1; i < input.Length; i++){
	if(input[i] != curChar || counter == 9){
		output.Append(counter);
		output.Append(curChar);
		curChar = input[i];
		counter = 1;
	}
	else {
		counter++;
	}
}
output.Append(counter);
output.Append(curChar);

Console.WriteLine(output);