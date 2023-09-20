using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreedingStation
{
    internal class Dog:Animal
    {
        protected Dog(byte numberOfLegs, byte dischargeAge, ESex sexOfAnimal, EHairType hairType, EReproductionMethod reproductionMethod): base(numberOfLegs, dischargeAge, sexOfAnimal, hairType, reproductionMethod)
        {

        }
    }
}
