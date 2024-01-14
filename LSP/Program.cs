using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args) /*Orange se ne moze zamjeniti Appleom kao sto to nalaze LSP,kada zamjenimo Orange i Apple
                                         * i pozovemo metodu GetColor ispisat ce se kriva boja.Rješenje je apstrakcija IFruit */
        {
            public class Apple
        {
            public virtual string GetColor()
            {
                return "Red";
            }
        }
        public class Orange : Apple
        {
            public override string GetColor()
            {
                return "Orange";
            }
        }
    }
    }
}
