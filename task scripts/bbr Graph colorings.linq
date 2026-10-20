<Query Kind="Program" />

void Main()
{
	int numVerticies = 10; 
	int[,] edgeMap = {{6,7},{0,1},{0,6},{5,9},{3,8},{3,7},{6,8},{2,5},{1,7},{4,5},{6,9},{2,3},{3,9},{3,4},{1,2},{1,4}};
	
	
	//int numVerticies = 4; 
	//int[,] edgeMap = {{0, 2}, {0, 3}, {1, 2}, {1, 3}};
	
	
	var Verticies = new List<Vertex>(numVerticies);
	
	for(int i = 0; i < numVerticies; i++){
		var vertex = new Vertex(){Id = i};
		Verticies.Add(vertex);
	}
	
	for(int j = 0; j < edgeMap.Length/2; j++){
	//Console.WriteLine(j);
		var vertex1 = Verticies.First(v => v.Id == edgeMap[j,0]);
		var vertex2 = Verticies.First(v => v.Id == edgeMap[j,1]);
		vertex1.AddNeighbor(vertex2, true);
	}
	
	Verticies[0].Color = false;
	foreach(Vertex v in Verticies){
		v.ColorProp();
	}
	var isValid = Verticies.All(v => v.NeighborsDiffer());
	Console.WriteLine(isValid);
	//Console.WriteLine(Verticies);
	foreach(Vertex v in Verticies){
		Console.Write(v.Color.Value ? 1 : 0);
	}
}

// You can define other methods, fields, classes and namespaces here

class Vertex{
	public int Id { get; set; }
	public List<Vertex> Neighbors { get; set; } = new List<Vertex>();
	public bool? Color { get; set; } = false;
	
	public void AddNeighbor(Vertex other, bool callOther = false){
		if(!Neighbors.Any(n => n.Id == other.Id)){
			Neighbors.Add(other);
		}
		if(callOther){
			other.AddNeighbor(this, false);
		}
	}
	
	public void ColorProp(){
		foreach(Vertex v in Neighbors){
			v.Color = !this.Color;
		}
	}
	
	public bool NeighborsDiffer(){
		return Neighbors.All(n => n.Color != this.Color);
	}
}