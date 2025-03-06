string[] s = Console.ReadLine().Split();
int A = int.Parse(s[0]);
int B = int.Parse(s[1]);
int V = int.Parse(s[2]);

Console.Write(Math.Ceiling((double)(V-B)/ (A - B)));