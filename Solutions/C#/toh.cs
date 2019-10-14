// C# recursive program for tower of hanoi
using System; 

class geek 
{ 
	static void towerOfHanoi(int n, char from_rod, 
							char to_rod, char aux_rod) 
	{ 
		if (n == 1) 
		{ 
			Console.WriteLine("Move disk 1 from rod " + from_rod 
										+ " to rod " + to_rod); 
			return; 
		} 
		towerOfHanoi(n-1, from_rod, aux_rod, to_rod); 
		Console.WriteLine("Move disk " + n + " from rod "
						+ from_rod + " to rod " + to_rod); 
		towerOfHanoi(n-1, aux_rod, to_rod, from_rod); 
	} 
	
	public static void Main() 
	{ 
		// Number of disks 
		int n = 4; 
		
		// A, B and C are names of rods 
		towerOfHanoi(n, 'A', 'C', 'B'); 
	} 
} 

// This code is contributed by Sandeep 
