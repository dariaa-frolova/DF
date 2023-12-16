Console.Write("Enter the coordinate a = ");
float a = float.Parse(Console.ReadLine());

Console.Write("Enter the coordinate b = ");
float b = float. Parse(Console.ReadLine());

if ((b >= -3) && (b <= (2 * a) + 2) && (b >= (-2 * a) + b))
    Console.WriteLine("The point belongs to the region");
else
    Console.WriteLine("The point does not belong to the region");