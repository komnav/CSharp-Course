// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography;

Console.WriteLine("x1");//16
var x1=double.Parse(Console.ReadLine());
Console.WriteLine("x2");
var x2=double.Parse(Console.ReadLine());
double a=(x1 + x2) / 2;
Console.WriteLine(a);

Console.WriteLine("y1");//17
var y1 = double.Parse(Console.ReadLine());
Console.WriteLine("y2");
var y2 = double.Parse(Console.ReadLine());
Console.WriteLine("y3");
var y3 = double.Parse(Console.ReadLine());
double dlina_y1_y3=y1 + y2+y3;
double dlina_y2_y3=y2 + y3;
double summ=dlina_y1_y3 + dlina_y2_y3;
Console.WriteLine(dlina_y1_y3);
Console.WriteLine(dlina_y2_y3);
Console.WriteLine(summ);


Console.WriteLine("a1");//18
var a1 = double.Parse(Console.ReadLine());
Console.WriteLine("b2");
var b2 = double.Parse(Console.ReadLine());
Console.WriteLine("c3");
var c3 = double.Parse(Console.ReadLine());
double a_c = c3 - a1;
double b_c = c3 - b2;
double zarb=a_c*b_c;
Console.WriteLine(zarb);


Console.WriteLine("q1");//19
var q1 = double.Parse(Console.ReadLine());
Console.WriteLine("g1");
var g1 = double.Parse(Console.ReadLine());
Console.WriteLine("q2");
var q2 = double.Parse(Console.ReadLine());
Console.WriteLine("g2");
var g2 = double.Parse(Console.ReadLine());
double x=(q1+q2)/2;
double y=(g1+g2)/2;
double p=2*(x+y);
double s = x + y;
Console.WriteLine(p);
Console.WriteLine(s);

Console.WriteLine("w1");//20
var w1 = double.Parse(Console.ReadLine());
Console.WriteLine("e1");
var e1 = double.Parse(Console.ReadLine());
Console.WriteLine("w2");
var w2 = double.Parse(Console.ReadLine());
Console.WriteLine("e2");
var e2 = double.Parse(Console.ReadLine());
double v = Math.Sqrt(Math.Pow((w2 - w1),2) + Math.Pow((e2 - e1),2));
Console.WriteLine(v);

