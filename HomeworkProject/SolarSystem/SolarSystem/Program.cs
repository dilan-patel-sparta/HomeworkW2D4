using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceEntity[] SolarSystem = {
                new SpaceEntity("Asteroid", 5),
                new SpaceEntity("Meteor", 2),
                new Star("Sun", 1391983, 5505.0),
                new Planet("Mercury", 4879, 88, 57909227), 
                new Planet("Venus", 4879, 88, 108209475), 
                new Planet("Earth", 4879, 88, 149598262),
                new Planet("Mars", 4879, 88, 227943824),
                new Planet("Jupiter", 4879, 88, 778340821),
                new Planet("Saturn", 4879, 88, 1426666422),
                new GasGiant("Uranus", 4879, 88, 2870658186, "Hydrogen", 88, "Helium", 12),
                new GasGiant("Neptune", 4879, 88, 4498396441, "Hydrogen", 94, "Helium", 6)
            };

            Star st = new Star("Star1", 50, 5000);
            st.populateRedDwarfStars();
            st.populateMorStars();

            SpaceEntity solarSystemWhole = new SpaceEntity();
            solarSystemWhole.createSolarSystemDict();

        }
    }

    // Parent class of all space objects.
    class SpaceEntity
    {
        private string entityName;
        private int entityDiameter;

        public SpaceEntity()
        {
        }

        public SpaceEntity(string name, int diameter)
        {
            entityName = name;
            entityDiameter = diameter;
        }

        public string EntityName { get => entityName; set => entityName = value; }
        public int EntityDiameter { get => entityDiameter; set => entityDiameter = value; }

        Dictionary<int, string> solarSystemDict = new Dictionary<int, string>();

        public void createSolarSystemDict()
        {
            solarSystemDict.Add(0, "Sun");
            solarSystemDict.Add(1, "Mercury");
            solarSystemDict.Add(2, "Venus");
            solarSystemDict.Add(3, "Earth");
            solarSystemDict.Add(4, "Mars");
            solarSystemDict.Add(5, "Jupiter");
            solarSystemDict.Add(6, "Saturn");
            solarSystemDict.Add(7, "Uranus");
            solarSystemDict.Add(8, "Neptune");
        }
    }


    class Star : SpaceEntity
    {
        private double starTemperature;

        public Star(string name, int diameter, double temp)
        {
            starTemperature = temp;
        }

        public double StarTemperature { get => starTemperature; set => starTemperature = value; }

        public void populateRedDwarfStars()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Star " + i);
            }
        }

        public void populateMorStars()
        {
            int i = 10;
            while(i > 1)
            {
                Console.WriteLine("Creating infinite stars."); // This should not run.
            }
        }
    }

    class Planet : SpaceEntity
    {
        private int lengthOfYear;
        private long distanceFromSun;

        public Planet()
        {
   
        }

        public Planet(string name, int diameter, int days, long distance)
        {
            int lengthInYears = days;
            long distanceFromSun = distance;
        }

        public int LengthOfYear { get => lengthOfYear; set => lengthOfYear = value; }
        public long DistanceFromSun { get => distanceFromSun; set => distanceFromSun = value; }

        ArrayList solarSystemList = new ArrayList();

        public void SystemCollection()
        {
            solarSystemList.Add(new Planet("Mercury", 4879, 88, 57909227));
            solarSystemList.Add(new Planet("Venus", 4879, 88, 108209475));
            solarSystemList.Add(new Planet("Mars", 4879, 88, 227943824));
            solarSystemList.Add(new Planet("Jupiter", 4879, 88, 778340821));
            solarSystemList.Add(new Planet("Saturn", 4879, 88, 1426666422));
            solarSystemList.Add(new GasGiant("Uranus", 4879, 88, 2870658186, "Hydrogen", 88, "Helium", 12));
            solarSystemList.Add(new GasGiant("Neptune", 4879, 88, 4498396441, "Hydrogen", 94, "Helium", 6));

            solarSystemList.Insert(0, new Star("Sun", 1391983, 5505.0));
            solarSystemList.Insert(3, new Planet("Earth", 4879, 88, 149598262));

            Object planetJupiter = solarSystemList[4];

        }
    }

    class GasGiant : Planet
    {
        private string primaryGasElement;
        private int primaryGasPercentage;
        private string secondaryGasElement;
        private int secondaryGasPercentage;

        public GasGiant(string name, int diameter, int days, long distance, string gas1, int gasPer1, string gas2, int gasPer2)
        {
            string primaryGasElement = gas1;
            int primaryGasPercentage = gasPer1;
            string secondaryGasElement = gas2;
            int secondaryGasPercentage= gasPer2;
        }

        public string PrimaryGasElement { get => primaryGasElement; set => primaryGasElement = value; }
        public int PrimaryGasPercentage { get => primaryGasPercentage; set => primaryGasPercentage = value; }
        public string SecondaryGasElement { get => secondaryGasElement; set => secondaryGasElement = value; }
        public int SecondaryGasPercentage { get => secondaryGasPercentage; set => secondaryGasPercentage = value; }
    }
}
