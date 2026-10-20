<Query Kind="Statements" />

int[] prices = new int[]{
192,16,74,130,30,102
};

var maxProfit2Transactions = 0;
Console.WriteLine("Max for 2 transactions");
for(int o1b = 0; o1b < prices.Length-3; o1b++){
	for(int o1s = o1b+1; o1s < prices.Length-2; o1s++){
	
		for(int o2b = o1s+1; o2b < prices.Length-1; o2b++){
			for(int o2s = o2b+1; o2s < prices.Length; o2s++){
				maxProfit2Transactions = Math.Max(maxProfit2Transactions, (prices[o1s] - prices[o1b]) + (prices[o2s] - prices[o2b]) );
			}
		}
	
	}
}
Console.WriteLine(maxProfit2Transactions);


Console.WriteLine("Max for 1 transaction");
var maxProfit1Transaction = 0;
for(int i = 0; i < prices.Length-1; i++){
	for(int j = i+1; j < prices.Length; j++){
		maxProfit1Transaction = Math.Max(maxProfit1Transaction, prices[j] - prices[i]);
	}
}
Console.WriteLine(maxProfit1Transaction);