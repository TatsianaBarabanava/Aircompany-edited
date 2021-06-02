using Aircompany;
using Aircompany.Models;
using Aircompany.Planes;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AircompanyTests.Tests
{
    [TestFixture]
    public class AirportTest
    {
        private List<Plane> planes = new List<Plane>()
        {// transferred { from line 10
           new PassengerPlane("Boeing-737", 900, 12000, 60500, 164),
           new PassengerPlane("Boeing-737-800", 940, 12300, 63870, 192),
           new PassengerPlane("Boeing-747", 980, 16100, 70500, 242),
           new PassengerPlane("Airbus A320", 930, 11800, 65500, 188),
           new PassengerPlane("Airbus A330", 990, 14800, 80500, 222),
           new PassengerPlane("Embraer 190", 870, 8100, 30800, 64),
           new PassengerPlane("Sukhoi Superjet 100", 870, 11500, 50500, 140),
           new PassengerPlane("Bombardier CS300", 920, 11000, 60700, 196),
           new MilitaryPlane("B-1B Lancer", 1050, 21000, 80000, MilitaryType.Bomber), //changed BOMBER to Bomber
           new MilitaryPlane("B-2 Spirit", 1030, 22000, 70000, MilitaryType.Bomber), //changed BOMBER to Bomber
           new MilitaryPlane("B-52 Stratofortress", 1000, 20000, 80000, MilitaryType.Bomber), //changed BOMBER to Bomber
           new MilitaryPlane("F-15", 1500, 12000, 10000, MilitaryType.Fighter), //changed FIGHTER to Fighter
           new MilitaryPlane("F-22", 1550, 13000, 11000, MilitaryType.Fighter), //changed FIGHTER to Fighter
           new MilitaryPlane("C-130 Hercules", 650, 5000, 110000, MilitaryType.Transport) //changed TRANSPORT to Transport
        };//moved } to the right to be aligned with { on line 11

        //moved line private PassengerPlane planeWithMaxPassengerCapacity = new PassengerPlane("Boeing-747", 980, 16100, 70500, 242); to testGetPassengerPlaneWithMaxCapacity()

        [Test]
        public void testGetTransportMilitaryPlanes() //renamed MyTest1 to testGetTransportMilitaryPlanes
        //edited the Test
        {
            Airport airport = new Airport(planes);
            List<MilitaryPlane> transportMilitaryPlanes = airport.getTransportMilitaryPlanes().ToList();
            Assert.IsTrue(transportMilitaryPlanes.All(transportMilitaryPlane => transportMilitaryPlane.type == MilitaryType.Transport));
        }

        [Test]
        public void testGetPassengerPlaneWithMaxPassangerCapacity()//renamed MyTest2() to testGetPassengerPlaneWithMaxCapacity()
        {
            Airport airport = new Airport(planes);
            PassengerPlane planeWithMaxPassengerCapacity = new PassengerPlane("Boeing-747", 980, 16100, 70500, 242); //removed private
            PassengerPlane expectedPlaneWithMaxPassengersCapacity = airport.getPassengerPlaneWithMaxPassengersCapacity(); //lowercased get in getPassengerPlaneWithMaxPassengersCapacity          
            Assert.AreEqual(expectedPlaneWithMaxPassengersCapacity, planeWithMaxPassengerCapacity);//added assert
        }

        [Test]
        public void testSortByMaxLoadCapacity()//renamed MyTest3() to testSortByMaxLoadCapacity()
        //edited the Test
        {
            Airport airport = new Airport(planes);
            List<Plane> sortedPlanes = new List<Plane>()
           {
               new MilitaryPlane("F-15", 1500, 12000, 10000, MilitaryType.Fighter),
               new MilitaryPlane("F-22", 1550, 13000, 11000, MilitaryType.Fighter),
               new PassengerPlane("Embraer 190", 870, 8100, 30800, 64),
               new PassengerPlane("Sukhoi Superjet 100", 870, 11500, 50500, 140),
               new PassengerPlane("Boeing-737", 900, 12000, 60500, 164),
               new PassengerPlane("Bombardier CS300", 920, 11000, 60700, 196),
               new PassengerPlane("Boeing-737-800", 940, 12300, 63870, 192),
               new PassengerPlane("Airbus A320", 930, 11800, 65500, 188),
               new MilitaryPlane("B-2 Spirit", 1030, 22000, 70000, MilitaryType.Bomber),
               new PassengerPlane("Boeing-747", 980, 16100, 70500, 242),
               new MilitaryPlane("B-1B Lancer", 1050, 21000, 80000, MilitaryType.Bomber),
               new MilitaryPlane("B-52 Stratofortress", 1000, 20000, 80000, MilitaryType.Bomber),
               new PassengerPlane("Airbus A330", 990, 14800, 80500, 222),
               new MilitaryPlane("C-130 Hercules", 650, 5000, 110000, MilitaryType.Transport),
           };
            Assert.AreEqual(airport.sortByMaxLoadCapacity().getPlanes(), sortedPlanes);
        }
    }
}
