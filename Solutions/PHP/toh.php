<?php 
//PHP code to solve Tower of Hanoi problem. 

// Recursive Function to solve Tower of Hanoi 
function towerOfHanoi($n, $from_rod, $to_rod, $aux_rod) { 
	
	if ($n === 1) { 
	echo ("Move disk 1 from rod $from_rod to rod $to_rod \n"); 
	return; 
	} 
	
	towerOfHanoi($n-1, $from_rod, $aux_rod, $to_rod); 
	echo ("Move disk $n from rod $from_rod to rod $to_rod \n"); 
	towerOfHanoi($n-1, $aux_rod, $to_rod, $from_rod); 

} 

// Driver code 

// number of disks 
$n = 4; 

// A, B and C are names of rods 
towerOfHanoi($n, 'A', 'C', 'B'); 

// This code is contributed by akash7981 
?> 
