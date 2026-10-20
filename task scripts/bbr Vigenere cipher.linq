<Query Kind="Program" />

void Main()
{
	string plainText = "FRAMEPOPUPTABLEMACROMODEM";
	string key = "WEBMASTER";
	StringBuilder sb = new StringBuilder();
	for(int i = 0; i < plainText.Length; i++){
		sb.Append( GetVignereValue(plainText[i], key[i % key.Length]) );
	}
	Console.WriteLine(sb.ToString());
}

// You can define other methods, fields, classes and namespaces here

public char[] GetVignereRow(char offset){
	int charOffset = offset - 'A';
	string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	char[] cipherRow = new char[alpha.Length];
	for(int i = 0; i < alpha.Length; i++){
		cipherRow[i] = alpha[(i + charOffset) % alpha.Length];
	}
	return cipherRow;
}

public char GetVignereValue(char row, char col){
	return GetVignereRow(row)[col - 'A'];
}