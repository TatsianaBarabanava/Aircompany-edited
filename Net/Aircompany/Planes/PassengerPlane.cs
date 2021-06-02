using System;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        public int passengersCapacity; //deleted _ from passengersCapacity

        public PassengerPlane(string Model, int MaxSpeed, int MaxFlightDistance, int MaxLoadCapacity, int PassengersCapacity)
            :base(Model, MaxSpeed, MaxFlightDistance, MaxLoadCapacity) // capitalized first letters in Model, MaxSpeed, MaxFlightDistance, MaxLoadCapacity, PassengersCapacity
        {
            passengersCapacity = PassengersCapacity; //deleted _ from passengersCapacity, capitalized first letter in PassengersCapacity
        }

        public override bool Equals(object obj)
        {
            var plane = obj as PassengerPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   passengersCapacity == plane.passengersCapacity; //deleted _ from passengersCapacity
        }

        public override int GetHashCode()
        {
            var hashCode = 751774561;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + passengersCapacity.GetHashCode(); //deleted _ from passengersCapacity
            return hashCode;
        }

        public int passengersCapacityIs() //lowercased passengers in passengersCapacityIs
        {
            return passengersCapacity; //deleted _ from passengersCapacity
        }

        public override string ToString()
        {
            return base.ToString().Replace("}",", passengersCapacity= " + passengersCapacity +'}'); //deleted _ from passengersCapacity, made 1 line from 3
        }       
        
    }
}
