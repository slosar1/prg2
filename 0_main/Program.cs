using System;
using prg2._1_intro;
using prg2._2_oop;
using prg2._3_design_patterns;
using prg2._4_functional_programming;
using prg2._5_database_design;



namespace prg2._0_main
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Launching main");
           coffeeTest() ;
           Clock programming = new Clock(5,30,0);
           programming.Tick();
           int x = 0;
           while(x!=5)
           {
               programming.Tick();
               x ++;
           }
           //Intro i = new Intro(args);
           //test(args);
          
           Console.ReadKey();
           /*
           To add a project, first add a new folder naming it the [projectname]
           then type 
           dotnet new classlib -o [projectname]
           then cd to 0_main and type
           dotnet add reference ../[projectname]/[projectname].csproj

           */
        
        }
        static void coffeeTest()
        {
            //CoffeeMaker lifesaver = new CoffeeMaker();

           // lifesaver.AddGrains(5.0);
            //int k = lifesver.AddGrains(4000000);
        }
        static void test(string [] args)
        {
              Intro i = new Intro(args);
              OOP o = new OOP(args);
              Design_Patterns d = new Design_Patterns(args);
              Functional_Programming f = new Functional_Programming(args);
              Database_Design dd = new Database_Design(args);
        }

    }
}
