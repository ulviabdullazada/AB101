#region DataTypes

//char character = 'ü';
//string text = "AB 101";
//int number1 = -5;
//sbyte b = -100;
//byte num2 = 255;
//num2++;
//int num3 = 2147483647;
//num3 += 5000;
//Console.WriteLine(num3);
//decimal num4 = 50505050m;
//float num5 = 3485f;
//double num6 = 74623487d;

//int tam = 475;
//float heqiqi = 678.901f;
////heqiqi = tam;
//tam = heqiqi;
//byte num1 = 99;
//int num2 = 300;
//long num3 = 223372036854775808;
//num2 = Convert.ToInt32(num3);

//string a = "Salam";

//a = 8475694564548;

//dynamic a = "Salam";
//Console.WriteLine(a);
//a = true;
//Console.WriteLine(a);



#endregion

#region Conditions
//int age = 16;
//if (age > 16)
//{
//    Console.WriteLine("Xosh geldiniz");
//}
//else if (age == 16)
//{
//    Console.WriteLine("Boyu gelersen");
//}
//else
//{
//    Console.WriteLine("Xosh getdiniz");
//}
//Console.WriteLine("Enter day of week : ");
//int dayOfWeek = Convert.ToInt32(Console.ReadLine());
//switch (dayOfWeek)
//{
//	case 1:
//		Console.WriteLine("Monday");
//		break;
//	case 2:
//		Console.WriteLine("Tuesday");
//		break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6: case 7:
//        Console.WriteLine("Weekend");
//        break;
//    default:
//		Console.WriteLine("Wrong input");
//		break;
//}

#endregion

#region Loops
#region For
//for (int i = 0; i < 10; i++)
//{
//	if (i%2==0)
//	{
//		Console.WriteLine("Even : " + i);
//	}
//	else
//	{
//		Console.WriteLine("Odd : " + i);
//	}
//}

//for (; ; )  //infinite loop (for)
//{
//    Console.WriteLine("Yazi");
//}
#endregion


#region While
//int index = 0;

//while (index < 10)
//{
//	if (index % 2 == 0)
//	{
//        Console.WriteLine("Even : " + index);
//    }
//	else
//	{
//        Console.WriteLine("Odd : " + index);
//    }
//	index++;
//}

//while (true) //infinity loop while
//{
//	index+=5;
//    Console.WriteLine(index);
//}
#endregion


#region Do-While

//int num = 5;

//while (num > 5)
//{
//    num++;
//    Console.WriteLine(num);
//}

//do
//{
//    num++;
//    if (num%2==0)
//    {
//        break;
//    }
//    Console.WriteLine(num);
//} while (num > 5);
//string name = "";
//do
//{
//    Console.WriteLine("Ad daxil edin (Elxan olmaz)");
//    name = Console.ReadLine();
//} while (name == "Elxan");

//Console.WriteLine("End = " + name);
#endregion


#endregion

#region Arrays && Foreach
//string[] names = { "Elkhan", "Tural", "Sanan", "Farid" };

//string[] names = new string[5];

//names[4] = "Araz";
//names[1] = "Seymur";
//names[2] = "Tarlan";
//names[3] = "Shamil";

//for (int i = 0; i < names.Length; i++)
//{
//    names[i] = Console.ReadLine();
//}



//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}
//for (int i = 0; i < names.Length; i++)
//{
//    string name = names[i];
//    Console.WriteLine(name);
//}
//int index = 1;
//foreach (string name in names)
//{
//    Console.WriteLine(index + ". " + name);
//    index++;
//}

#endregion