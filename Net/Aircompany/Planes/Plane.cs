using System.Collections.Generic;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        public string model; //deleted _ from model
        public int maxSpeed; //deleted _ from maxSpeed
        public int maxFlightDistance; //deleted _ from maxFlightDistance
        public int maxLoadCapacity; //deleted _ from maxLoadCapacity

        public Plane(string Model, int MaxSpeed, int MaxFlightDistance, int MaxLoadCapacity) //capitalized first letters in Model, MaxSpeed, MaxFlightDistance, MaxLoadCapacity
        {
            model = Model; //deleted _ from model
            maxSpeed = MaxSpeed; //deleted _ from maxSpeed
            maxFlightDistance = MaxFlightDistance; //deleted _ from maxFlightDistance
            maxLoadCapacity = MaxLoadCapacity; //deleted _ from maxLoadCapacity
        }

        public string getModel() //lowercased get in getModel
        {
            return model; //deleted _ from model
        }

        public int getMaxSpeed() //renamed getMS to getMaxSpeed, lowercased get in getMaxSpeed
        {
            return maxSpeed; //deleted _ from maxSpeed
        }

        public int maximumFlightDistance() //renamed MAXFlightDistance to maximumFlightDistance
        {
            return maxFlightDistance; //deleted _ from maxFlightDistance
        }

        public int maximumLoadCapacity() //renamed MAXLoadCapacity to maximumLoadCapacity
        {
            return maxLoadCapacity; //deleted _ from maxLoadCapacity
        }

        public override string ToString()
        {
            return "Plane{" + "model='" + model + '\'' + ", maxSpeed=" + maxSpeed + ", maxFlightDistance=" + maxFlightDistance + ", maxLoadCapacity=" + maxLoadCapacity + '}'; //deleted _ from model, maxSpeed, maxFlightDistance, maxLoadCapacity, made 1 string from 5
        }

        public override bool Equals(object obj)
        {
            var plane = obj as Plane;
            return plane != null &&
                   model == plane.model &&
                   maxSpeed == plane.maxSpeed &&
                   maxFlightDistance == plane.maxFlightDistance &&
                   maxLoadCapacity == plane.maxLoadCapacity; //deleted _ from model, maxSpeed, maxFlightDistance, maxLoadCapacity
        }

        public override int GetHashCode() //renamed GetHashCode to getHashCode
        {
            var hashCode = -1043886837;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(model); //deleted _ from model
            hashCode = hashCode * -1521134295 + maxSpeed.GetHashCode(); //deleted _ from maxSpeed
            hashCode = hashCode * -1521134295 + maxFlightDistance.GetHashCode(); //deleted _ from maxFlightDistance
            hashCode = hashCode * -1521134295 + maxLoadCapacity.GetHashCode(); //deleted _ from maxLoadCapacity
            return hashCode;
        }        

    }
}
