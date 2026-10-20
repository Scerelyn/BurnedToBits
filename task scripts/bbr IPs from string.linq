<Query Kind="Program" />

void Main()
{
	var ints = "16825472113".ToList();
	var incrementer = new OctetIncrementer();
	var validIps = new List<string>();
	
	while(!incrementer.reset){
		var pos = 0;
		var intsCpy = new List<char>(ints);
		for(int i = 0; i < incrementer.vals.Length; i++){
			pos += incrementer.vals[i];
			if(pos > intsCpy.Count){
				continue;
			}
			intsCpy.Insert(pos, '.');
			pos++;
		}
		var sb = new StringBuilder();
		sb.Append(intsCpy.ToArray());
		var ipString = sb.ToString();
		if(IsValidIp(ipString)){
			Console.WriteLine(ipString);
		}
		incrementer.increment();
	}
}

class OctetIncrementer{
	public int[] vals = {1,1,1};
	public bool reset = false;
	public void increment(){
		vals[0]++;
		if(vals[0] >= 4){
			vals[0] = 1;
			vals[1]++;
			if(vals[1] >= 4){
				vals[1] = 1;
				vals[2]++;
				if(vals[2] >= 4){
					vals[2] = 1;
					reset = true;
				}
			}
		}
	}
}

bool IsValidIp(string ip){
	var octets = ip.Split(".");
	if(octets.Length != 4){
		return false;
	}
	if(octets.Any(sp => sp.Count() > 3)){
		return false;
	}
	if(octets.Any(sp => sp[0] == '0')){
		return false;
	}
	if(octets.Any(sp => int.TryParse(sp, out var num) && num > 255)){
		return false;
	}
	return true;
}