using System;
using System.Collections.Generic;

namespace Lab3App
{
	internal class MagicWand : Tool
	{
        public MagicWand(string description) : base(description) { }

        public override void Display()
        {
            Console.WriteLine($"MagicWand {Description} is displayed");
            
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }


    }
}

