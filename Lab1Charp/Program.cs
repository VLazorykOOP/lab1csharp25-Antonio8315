// See https://aka.ms/new-console-template for more information

 static void main()
 {
    Console.Write("\nInput # of task: ");
    int n = int.Parse(Console.ReadLine()!);
    switch (n){
        case 1: task1(); break;
        case 2: task2(); break;
        case 3: task3(); break;
        case 4: task4(); break;
        case 5: task5(); break;
        case 6: task6(); break;
        default: break;
    }
    main();
}
 static void task1(){
    Console.Write("Perimetr: ");
    float P = float.Parse(Console.ReadLine()!);
    float a = P / 3; //сторона трикутника
    double S = a * a * Math.Sqrt(3) / 4;
    Console.WriteLine("Area = " + S);
}

 static void task2(){
    Console.WriteLine("Input number: ");
    int num = int.Parse(Console.ReadLine()!);
    if(num % 2 == 0){
    Console.WriteLine("Parne");
    }
    else{
    Console.WriteLine("Not Parne");
    }
}

 static void task3()
 {
    Console.Write("x = ");
    float x = float.Parse(Console.ReadLine()!);
    Console.Write("y = ");
    float y = float.Parse(Console.ReadLine()!);
    if (x * x + y * y < 81 && x > 0)
    Console.WriteLine("Yes");
    else if (x * x + y * y > 81 || x < 0)
    Console.WriteLine("No");
    else Console.WriteLine("On a edge");
 }

 static void task4()
 {
    Console.Write("Input # of day: ");
    int day = int.Parse(Console.ReadLine()!);
    Console.WriteLine(30-day);
}

 static void task5()
 {
    static int subtraction(int a, int b){
    return a-b;
    }

    Console.Write("Input 1-st num: ");
    int num1 = int.Parse(Console.ReadLine()!);
    Console.Write("Input 2-nd num: ");
    int num2 = int.Parse(Console.ReadLine()!);
    Console.Write(subtraction(num1, num2));
 }

 static void task6()
 { //x,y != 0
    Console.Write("Input x: ");
    float x = float.Parse(Console.ReadLine()!);
    Console.Write("Input y: ");
    float y = float.Parse(Console.ReadLine()!);
    float answer = ((1 / (x*y))+(1 / (x*x + 1))) * (x + y);
    Console.Write("Answer: " + answer);
 }


Console.WriteLine("Lab 1 !");
main();