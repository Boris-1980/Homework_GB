// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double xa = 7;
double ya = -5;
double za = 0;

double xb = 1;
double yb = -1;
double zb = 9;

double S = ((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb));
S = Math.Sqrt(S);
Console.WriteLine("{0:f}", S);

