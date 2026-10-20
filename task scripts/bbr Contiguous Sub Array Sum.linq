<Query Kind="Statements" />

List<int> nums = new List<int>{6,-5,-9,2,2,-4,3,-8,6,3,3,2,-5,-8,-6,-6};

int sum = 0;
for(int i = 1; i < nums.Count; i++){
	for(int j = 0; j < nums.Count; j++){
		sum = Math.Max(nums.Skip(j).Take(i).Sum(), sum);
	}
}
Console.Write(sum);