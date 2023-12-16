Console.Write("Enter the coordinate a = ");
float a = float.Parse(Console.ReadLine());

Console.Write("Enter the coordinate b = ");
float b = float. Parse(Console.ReadLine());

if (a <= 3 && a>= -1 && b <= 4 && b >= -2)
    Console.WriteLine("The point belongs to the region");
else 
    Console.WriteLine("The point does not belong to the region");