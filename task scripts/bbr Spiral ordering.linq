<Query Kind="Statements" />

int[,] nums = 
{
        {23,34,15,40,42},
        { 9,29, 4,18,50},
        {26,39,36,41,40},
        {14,47,27,30, 3},
        {22,21,25,50,40},
        { 4,32,24,44,27},
        { 1,50, 7,40,19},
        {26,23,17, 1, 6},
        {44,24,30,47,27},
        {48,39,30,31,10},
        {31,23,44,49,18},
        {14,29,19,26,34},
        {48,19,50,39, 1},
        {26, 4,49,11,42},
        {38,50,36,10,31}
    };
//int[,] nums1 = {{1,2,3},{4,5,6},{7,8,9}};
var y = nums.GetLength(0);
var x = nums.GetLength(1);
var total = nums.Length;

var numsFlattened = new List<int>();
foreach(int num in nums){
	numsFlattened.AddRange(num);
}
//numsFlattened.Sort();

int[,] mapperArr = new int[y,x];
int curX = 0, curY = 0, minX = -1, minY = -1, maxX = x, maxY = y;
var forwards = false;
var horizontal = false;
for(int i = 0; i < total; i++){
//Console.WriteLine(i+": "+curX + ","+curY);
	mapperArr[curY,curX] = i;
	//mapperArr[curY,curX] = numsFlattened[i];
	if(horizontal){
		if(forwards){
			if(curX + 1 == maxX){
				curY++;
				minY++;
				horizontal = false;
			}
			else {
				curX++;
			}
		}
		else {
			if(curX  == minX){
				curY--;
				maxY--;
				horizontal = false;
			}
			else {
				curX--;
			}
		}
	}
	else {
		if(forwards){
			if(curY + 1 == maxY){
				curX--;
				maxX--;
				horizontal = true;
				forwards = false;
			}
			else {
				curY++;
			}
		}
		else {
			if(curY - 1 == minY){
				curX++;
				minX++;
				horizontal = true;
				forwards = true;
			}
			else {
				curY--;
			}
		}
	}
}

//Console.WriteLine(mapperArr);

int[] result = new int[total];
for(int i = 0; i < y; i++){
	for(int j = 0; j < x; j++){
		result[ mapperArr[i,j] ] = nums[i,j];
	}
}
//Console.WriteLine(result);
Console.Write("[");
foreach(int i in result){
	Console.Write(i + ", ");
}