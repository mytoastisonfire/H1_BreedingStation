using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreedingStation
{
    internal abstract class Animal
    {
        protected byte numberOfLegs;
        protected byte dischargeAge;
        protected ESex sexOfAnimal;
        protected EHairType hairType;
        protected EReproductionMethod classOfAnimal;

        protected byte NumberOfLegs { get { return numberOfLegs; } }
        protected byte DischargeAge {  get { return dischargeAge; } }
        protected ESex SexOfAnimal { get { return sexOfAnimal; } }
        protected EHairType HairType { get { return hairType; } }
        protected EReproductionMethod ReproductionMethod { get { return classOfAnimal; } }
        protected Animal(byte numberOfLegs, byte dischargeAge, ESex sexOfAnimal, EHairType hairType, EReproductionMethod reproductionMethod)
        {
            this.numberOfLegs = numberOfLegs;
            this.dischargeAge = dischargeAge;
            this.sexOfAnimal = sexOfAnimal;
            this.hairType = hairType;
            this.classOfAnimal = reproductionMethod;
        }
    }
}
