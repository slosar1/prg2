using System;
using prg2._1_intro;
using prg2._2_oop;
using prg2._3_design_patterns;
using prg2._4_functional_programming;
using prg2._5_database_design;

using System.Collections.Generic;

namespace _0_main
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*Console .WriteLine("Launching main");*/
            NodeTest();
            /*Console.ReadKey();*/
        
        }
        static void NodeTest()
        {
            Node<int> List = new Node<int>(0);
            List.next = new Node<int>(1,List.root);
            List++;
            List.next = new Node<int>(2,List.root);
            List++;
            List.next = new Node<int>(3,List.root);
            List++;
            List.next = new Node<int>(4,List.root);
            List++;
            List.next = new Node<int>(5,List.root);
            List++;
            List = List.root;
            List.next.Print();
            Swapper<int>.Swap(List, List.next);
            Console.WriteLine("This is swapp version");
            List.next.Print();
        }
            /*Console.WriteLine("IM resting node");
            string done= "";

            Node<double> n0 = new Node<double>(3.0);
            n0.next = new Node<double>(5.0,n0.root);         
            n0++;
            n0.next = new Node<double>(15.0,n0.root);
            n0++;
            n0 = n0.root;

            n0[0].Print();
            n0[1].Print();
            n0[400].Print();
            
            Node<double> tempvar = n0[0];

            Node<double> k = n0[15];
            
            if (n0 == n1)
            {
                Console.WriteLine("they are equal");
            }
            else
            {
                Console.WriteLine("they are not equal");
            }


            /*Node<int> linkedList = new Node<int>(0);
            Node<int> root = linkedList;
            while(done != "y")
            {
                Console.WriteLine("Insert an integer for Linked List");
                int value = Convert.ToInt32(Console.ReadLine());
                linkedList.next = new Node<int>(value,root);
                linkedList = linkedList.next;
                Console.WriteLine("Are you done adding y/n");
                done = Console.ReadLine().ToLower();
            }
        }
        linkedList.Print();
        linkedList.PrintAll();        
        static void CoffeeTest()
        {
            run();
           //MrCoffee lifesaver = new  MrCoffee();
           CoffeeMaker lifesaver = new CoffeeMaker();
           

           lifesaver.AddGrains(5.0);
           lifesaver.AddWater(12);
           lifesaver.InsertFilter();

           lifesaver.Make();

           //int k = lifesaver.AddGrains(4000000);
        }
        
        static void Hw3Test()
        {

        }
        static void test(string [] args)
        {
            Intro i = new Intro(args);
            OOP o = new OOP(args);
            Design_Patterns d = new Design_Patterns(args);
            Functional_Programming f = new Functional_Programming(args);
            Database_Design dd = new Database_Design(args);
        }
         public static void run()
         {
            Console.WriteLine("Print out year if youu want");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year % 4 == 0 )
            {
                if(year % 100 == 0)
                {         
                    if(year % 400 == 0)
                    {
                        Console.WriteLine("It is leap year");
                        Console.WriteLine("The next 20 leap year is...");
                        int nleap = year;
                        int cout = 0;
                        while(cout != 20)
                            {    
                            nleap +=4;
                            Console.WriteLine(nleap);
                            cout++;
                            }
                    } 
                    else 
                    {
                        Console.WriteLine("It is NOT leap year");  
                        int cyear = year;
                        for(int x = 0; x < 4; x++)
                            {
                                cyear ++;
                                if(cyear % 4 == 0 || cyear % 400 == 0)
                                    break;
                            }
                            Console.WriteLine("The next Leap year is" + cyear);
                            Console.WriteLine("The next twenith leap year is...");
                            int nleap = cyear;
                            int cout = 0;
                            while(cout != 20)
                            {    
                                nleap +=4;
                                Console.WriteLine(nleap);
                                cout++;
                            }
                        }
                    }             
            }
            else 
            {
                Console.WriteLine("It is leap year");
                Console.WriteLine("The next four leap year is...");
                int nleap = year;
                int cout = 0;
                    while(cout != 20)
                    { 
                        nleap +=4;
                        Console.WriteLine(nleap);
                        cout++;
                    }
                }
            }
         }         
            if(year % 4 != 0) 
            {
                Console.WriteLine("It is NOT leap year");   
                int cyear = year;
                        for(int x = 0; x < 4; x++)
                            {
                                cyear ++;
                                if(cyear % 4 == 0 || cyear % 400 == 0)
                                    break;
                                
                            }
                            Console.WriteLine("The next Leap year is" + cyear);
                            Console.WriteLine("The next 20 leap year is...");
                            int nleap = cyear;
                            int cout = 0;
                            while(cout != 20)
                            {    
                                nleap +=4;
                                Console.WriteLine(nleap);
                                cout++;
                            }
                        }
                    }    
                }
            }        
        }*/
    }
}