using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /**
    * This class represents a dog that can sleep, wake, and make a sound, so it's pretty much like most dogs,
    * with a few essential methods missing. Thankfully.
    */
    public class Dog
    {
        private bool isSleeping;


        public Dog()
        {
           isSleeping = false;
        }


        public bool IsSleeping
        {
            get
            {
                return isSleeping;
            }
            private set
            {
                isSleeping = value;
            }
        }


        public string MakeSound()
        {
            if (isSleeping == false)
            {
                return "woof!";
            }
            else
            {
                return "Zzzzz...";
            }
        }

        public void Sleep()
        {
            isSleeping = true;
        }

        public void WakeUp()
        {
            isSleeping = false;
        }
    }
}
