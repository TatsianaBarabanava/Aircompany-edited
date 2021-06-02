using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        public MilitaryType type; //deleted _ from type

        public MilitaryPlane(string Model, int MaxSpeed, int MaxFlightDistance, int MaxLoadCapacity, MilitaryType Type)
            : base(Model, MaxSpeed, MaxFlightDistance, MaxLoadCapacity)  // capitalized first letters in Model, MaxSpeed, MaxFlightDistance, MaxLoadCapacity, Type
        {
            type = Type; //deleted _ from type, capitalized first letter in Type
        }

        public override bool Equals(object obj)
        {
            var plane = obj as MilitaryPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   type == plane.type; //deleted _ from type
        }

        public override int GetHashCode()
        {
            var hashCode = 1701194404;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + type.GetHashCode(); //deleted _ from type
            return hashCode;
        }

        public MilitaryType planeTypeIs() //lowercased plane in planeTypeIs
        {
            return type; //deleted _ from type
        }

        public override string ToString()
        {
            return base.ToString().Replace("}",", type= " + type +'}'); //deleted _ from type, made 1 line from 3
        }        
    }
}
