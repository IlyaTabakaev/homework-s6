


Console.WriteLine("input b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input k2");
double k2 = Convert.ToDouble(Console.ReadLine());
 
 
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 

 
Console.WriteLine($"lines cross in: ({x};{y})");