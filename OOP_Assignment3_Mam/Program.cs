﻿using OOP_Assignment3_Mam.NodeA;
using OOP_Assignment3_Mam.NumExpression;

LinkedList l = new OOP_Assignment3_Mam.NodeA.LinkedList();
Console.WriteLine(l.GetMinNode().GetValue());
l.Append(8);
Console.WriteLine(l);
l.Unqueue();
Console.WriteLine(l);
//l.Append(97);
Console.WriteLine(l);
l.Append(43);
Console.WriteLine(l);
l.Append(490);
Console.WriteLine(l);
l.Append(10);
Console.WriteLine(l);
l.Sort();
Console.WriteLine(l);
//Console.WriteLine(l.GetMaxNode().GetValue());
//l.Pop();
//Console.WriteLine(l);
l.Prepend(200);
Console.WriteLine(l);
l.Sort();
l.Prepend(600);
l.Prepend(3);
l.Prepend(8);
l.Append(8);

Console.WriteLine(l);
Console.WriteLine(l.GetMinNode().GetValue());
Console.WriteLine(l.GetMaxNode().GetValue());
Console.WriteLine(l.IsCircular());
//Console.WriteLine(l.GetMinNode().GetValue());
//l.Append(890);
//Console.WriteLine(l);
//Console.WriteLine(l.GetMaxNode().GetValue());
//l.Pop();
//Console.WriteLine(l);
//Console.WriteLine(l.GetMaxNode().GetValue());
//l.Unqueue();
//Console.WriteLine(l);
//Console.WriteLine(l.GetMinNode().GetValue());
//NumericalExpression obj = new NumericalExpression(21001);
//Console.WriteLine(obj.ToString());
//Console.WriteLine(NumericalExpression.SumLetters(10));
//Console.WriteLine(NumericalExpression.SumLetters(obj));