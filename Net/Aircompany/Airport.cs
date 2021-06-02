using Aircompany.Models;
using Aircompany.Planes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aircompany
{
    public class Airport
    {
        public List<Plane> planes; //lowercased first letter in planes

        public Airport(IEnumerable<Plane> Planes) //uppercased first letter in planes
        {
            planes = Planes.ToList(); 
        }

        public List<PassengerPlane> getPassengersPlanes() //lowercased get in getPassengersPlanes
        {
            List<PassengerPlane> passengerPlanes = new List<PassengerPlane>();
            for (int i=0; i < planes.Count; i++) //lowercased first letter in planes
            {
                if (planes[i].GetType() == typeof(PassengerPlane)) //lowercased first letter in planes
                {
                    passengerPlanes.Add((PassengerPlane)planes[i]); //lowercased first letter in planes
                }
            }
            return passengerPlanes;
        }

        public List<MilitaryPlane> getMilitaryPlanes() //lowercased get in getMilitaryPlanes
        {
            List<MilitaryPlane> militaryPlanes = new List<MilitaryPlane>();
            for (int i = 0; i < planes.Count; i++) //lowercased first letter in planes
            {
                if (planes[i].GetType() == typeof(MilitaryPlane)) //lowercased first letter in planes
                {
                    militaryPlanes.Add((MilitaryPlane)planes[i]); //lowercased first letter in planes
                }
            }
            return militaryPlanes;
        }

        public PassengerPlane getPassengerPlaneWithMaxPassengersCapacity() //lowercased get in getPassengerPlaneWithMaxPassengersCapacity
        {
            List<PassengerPlane> passengerPlanes = getPassengersPlanes(); //lowercased get in getPassengersPlanes
            return passengerPlanes.Aggregate((w, x) => w.passengersCapacityIs() > x.passengersCapacityIs() ? w : x);  //lowercased passengers in passengersCapacityIs           
        }

        public List<MilitaryPlane> getTransportMilitaryPlanes() //lowercased get in getTransportMilitaryPlanes
        {
            List<MilitaryPlane> transportMilitaryPlanes = new List<MilitaryPlane>();
            List<MilitaryPlane> militaryPlanes = getMilitaryPlanes(); //lowercased get in getMilitaryPlanes
            for (int i = 0; i < militaryPlanes.Count; i++)
            {
                MilitaryPlane plane = militaryPlanes[i];
                if (plane.planeTypeIs() == MilitaryType.Transport) //lowercased plane in planeTypeIs, changed TRANSPORT to Transport
                {
                    transportMilitaryPlanes.Add(plane);
                }
            }
            return transportMilitaryPlanes;
        }

        public Airport sortByMaxDistance() //lowercased sort in sortByMaxDistance
        {
            return new Airport(planes.OrderBy(w => w.maximumFlightDistance())); //lowercased first letter in planes, renamed MAXFlightDistance to maximumFlightDistance 
        }

        public Airport sortByMaxSpeed() //lowercased sort in sortByMaxSpeed
        {
            return new Airport(planes.OrderBy(w => w.getMaxSpeed())); //lowercased first letter in planes, renamed GetMS to getMaxSpeed
        }

        public Airport sortByMaxLoadCapacity() //lowercased sort in sortByMaxLoadCapacity
        {
            return new Airport(planes.OrderBy(w => w.maximumLoadCapacity())); //lowercased first letter in planes, renamed MAXLoadCapacity to maximumLoadCapacity
        }


        public IEnumerable<Plane> getPlanes() //lowercased get in getPlanes
        {
            return planes; //lowercased first letter in planes
        }

        public override string ToString()
        {
            return "Airport{" +  "planes=" + string.Join(", ", planes.Select(x => x.getModel())) + '}'; //lowercased first letter in planes, renamed GetModel to getModel, made 1 line from 3
        }
    }
}
