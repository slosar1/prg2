using System;

namespace prg2._2_oop
{
    public class Coffee : Consumable
    {
        public double Caffiene;

        public string RoastLever;

        public Coffee()
          {
             Quantity = 0;
             Caffiene = 0;
             RoastLever = "Non existant";
          }
          public Coffee(Water w, Grain g, PaperFilter pf)
          {
              this.RoastLever = g.RoastLever;
              
          }
    }
}
