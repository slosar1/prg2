using System;
using System.Collections.Generic;

namespace prg2._2_oop
{
     public class VendingMachine : ConsumableMaker
    {
        public VendingMachine()
        {
            Ingredients = new Dictionary<System.Type,Consumable>();
            MaxIngredients = new Dictionary<System.Type,double>();

            Ingredients[typeof(Chips)] = new Chips();
            Ingredients[typeof(Pretzles)] = new Pretzles();
            Ingredients[typeof(Soda)] = new Soda();
            Ingredients[typeof(Candy)] = new Candy();
            Ingredients[typeof(Lighters)] = new Lighters();
            Ingredients[typeof(Crackers)] = new Crackers();
            Ingredients[typeof(Cookies)] = new Cookies();

            MaxIngredients[typeof(Chips)] = 20.0;
            MaxIngredients[typeof(Pretzles)] = 20.0;
            MaxIngredients[typeof(Soda)] = 20.0;
            MaxIngredients[typeof(Candy)] = 20.0;
            MaxIngredients[typeof(Lighters)] = 20.0;
            MaxIngredients[typeof(Crackers)] = 20.0;
            MaxIngredients[typeof(Cookies)] = 20.0;
        }
        public void AddChips(double AmountOfChips)
        {
            if(Ingredients[typeof(Chips)].Quantity + AmountOfChips > MaxIngredients[typeof(Chips)])
            {
                throw new Exception("Too much Chips!!!");
            }
            else
            {
                Ingredients[typeof(Chips)].Quantity += AmountOfChips;
            }
        }
        public void AddPretzles(double AmountOfPretzles)
        {
            if(Ingredients[typeof(Pretzles)].Quantity + AmountOfPretzles > MaxIngredients[typeof(Pretzles)])
            {
                throw new Exception("Too much Pretzles!!!");
            }
            else
            {
                Ingredients[typeof(Pretzles)].Quantity += AmountOfPretzles;
            }
        }
        public void AddSoda(double AmountOfSoda)
        {
            if(Ingredients[typeof(Soda)].Quantity + AmountOfSoda > MaxIngredients[typeof(Soda)])
            {
                throw new Exception("Too much Soda!!!");
            }
            else
            {
                Ingredients[typeof(Soda)].Quantity += AmountOfSoda;
            }                   
        }
        public void AddCandy(double AmountOfCandy)
        {
            if(Ingredients[typeof(Candy)].Quantity + AmountOfCandy > MaxIngredients[typeof(Candy)])
            {
                throw new Exception("Too much Candy!!!");
            }
            else
            {
                Ingredients[typeof(Candy)].Quantity += AmountOfCandy;
            }                   
        }
        public void AddLighters(double AmountOfLighters)
        {
            if(Ingredients[typeof(Lighters)].Quantity + AmountOfLighters > MaxIngredients[typeof(Lighters)])
            {
                throw new Exception("Too much Lighters!!!");
            }
            else
            {
                Ingredients[typeof(Lighters)].Quantity += AmountOfLighters;
            }                   
        }
        public void AddCrackers(double AmountOfCrackers)
        {
            if(Ingredients[typeof(Crackers)].Quantity + AmountOfCrackers > MaxIngredients[typeof(Crackers)])
            {
                throw new Exception("Too much Crackers!!!");
            }
            
            else
            {
                Ingredients[typeof(Crackers)].Quantity += AmountOfCrackers;
            }                   
        }
        public void AddCookies(double AmountOfCookies)
        {
            if(Ingredients[typeof(Cookies)].Quantity + AmountOfCookies > MaxIngredients[typeof(Cookies)])
            {
                throw new Exception("Too much Cookies!!!");
            }
            else
            {
                Ingredients[typeof(Cookies)].Quantity += AmountOfCookies;
            }                   
        }
        public override Consumable Make()
        {
            Ingredients[typeof(Chips)].Quantity = Ingredients[typeof(Chips)].Quantity;
            Ingredients[typeof(Chips)].Quantity = 5;
            Ingredients[typeof(Pretzles)].Quantity = Ingredients[typeof(Pretzles)].Quantity;
            Ingredients[typeof(Pretzles)].Quantity = 8;
            Ingredients[typeof(Soda)].Quantity = Ingredients[typeof(Soda)].Quantity;
            Ingredients[typeof(Soda)].Quantity = 1;
            Ingredients[typeof(Candy)].Quantity = Ingredients[typeof(Candy)].Quantity;
            Ingredients[typeof(Candy)].Quantity = 3;
            Ingredients[typeof(Lighters)].Quantity = Ingredients[typeof(Lighters)].Quantity;
            Ingredients[typeof(Lighters)].Quantity = 7;
            Ingredients[typeof(Cookies)].Quantity = Ingredients[typeof(Cookies)].Quantity;
            Ingredients[typeof(Cookies)].Quantity = 12;
            return Ingredients[typeof(VendingMachine)];
        }
        public Consumable deliver(int code)
        {
            if(code == 375)
            {
                return Ingredients[typeof(Chips)];
            }
                else   if(code == 489)
                {
                    return Ingredients[typeof(Pretzles)];                 
                }
            
                else   if(code == 333)
                {
                   return Ingredients[typeof(Soda)];
                }
            
                else   if(code == 214)
                {
                    return Ingredients[typeof(Candy)];
                }                
                else   if(code == 186)
                {
                    return Ingredients[typeof(Lighters)];
                }
                else   if(code == 274)
                {
                   return Ingredients[typeof(Crackers)];               
                }
                else   if(code == 487)
                {
                    return Ingredients[typeof(Cookies)];
                }
                else
                {
                    return null;
                }
            }
        }

    }    