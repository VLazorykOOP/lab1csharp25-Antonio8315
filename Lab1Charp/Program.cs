// See https://aka.ms/new-console-template for more information
/*
 static void task11()
{
    Console.WriteLine("Task1 !");
    Console.Write("s= ");
    string? str = Console.ReadLine();
    float s = 0; 
    if (str != null) s = float.Parse(str);
    double p = 4 * Math.Sqrt(s);
    Console.WriteLine("p=" + p);

}
*/
 static void task()
 {
    Console.Write("Input # of task=");
    int n = int.Parse(Console.ReadLine());
    switch (n){
        case 1: task1(); break;
        case 2: task2(); break;
        case 3: task3(); break;
        default: break;
    }
    task();
}
 static void task1(){
    Console.WriteLine("Task1 !");
    Console.Write("Perimetr=");
    float P = float.Parse(Console.ReadLine());
    Console.WriteLine("" + P);
    float a = P / 3; //сторона трикутника
    double S = a * a * Math.Sqrt(3) / 4;
    Console.WriteLine("Area = " + S);
}

 static void task2(){
    Console.WriteLine("Input number");
    int num = int.Parse(Console.ReadLine());
    if(num % 2 == 0){
    Console.WriteLine("Parne");
    }
    else{
    Console.WriteLine("Not Parne");
    }
}

 static void task3()
 {
    Console.Write("x=");
    float x = float.Parse(Console.ReadLine());
    Console.Write("y=");
    float y = float.Parse(Console.ReadLine());
    if (x * x + y * y < 81 && x > 0)
    Console.WriteLine("Yes");
    else if (x * x + y * y > 81 || x < 0)
    Console.WriteLine("No");
    else Console.WriteLine("On a edge");
 }


Console.WriteLine("Lab 1 !");
task();