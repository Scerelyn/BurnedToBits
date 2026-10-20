<Query Kind="Statements" />

var num = 677617323;
var pfactors = new List<int> {1};

for(int i = 2; i < num/2; i++){
	if(num % i == 0){
		pfactors.Add(i);
		pfactors.Add(num / i);
	}
}
Console.Write(pfactors);