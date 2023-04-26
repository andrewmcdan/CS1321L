/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               13A
*/

using System;

class Lab13A
{
    static void Main(string[] args)
    {
        BuildingBlueprint buildingOne = new BuildingBlueprint();
        BuildingBlueprint buildingTwo = new BuildingBlueprint(30, 30, 0.75f);

        Console.WriteLine("Year 2020:");
        Console.WriteLine("Building 1 has " + buildingOne.getStories() + " floors, " + buildingOne.getApartments() + " apartments, and is " + (100 * buildingOne.getOccupancyRate()) + "% occupied. Full? " + (buildingOne.getFull() ? "true" : "false"));
        Console.WriteLine("Building 2 has " + buildingTwo.getStories() + " floors, " + buildingTwo.getApartments() + " apartments, and is " + (100 * buildingTwo.getOccupancyRate()) + "% occupied. Full? " + (buildingTwo.getFull() ? "true" : "false"));

        buildingOne.setOccupancyRate(0);
        buildingTwo.setOccupancyRate(1);
        
        Console.WriteLine("\nMany years pass.\n");
        Console.WriteLine("Year 2043:");
        Console.WriteLine("Building 1 has " + buildingOne.getStories() + " floors, " + buildingOne.getApartments() + " apartments, and is " + (100 * buildingOne.getOccupancyRate()) + "% occupied. Full? " + (buildingOne.getFull() ? "true" : "false"));
        Console.WriteLine("Building 2 has " + buildingTwo.getStories() + " floors, " + buildingTwo.getApartments() + " apartments, and is " + (100 * buildingTwo.getOccupancyRate()) + "% occupied. Full? " + (buildingTwo.getFull() ? "true" : "false"));
        Console.WriteLine("\nLooks like people prefer taller buildings.");
    }
}

class BuildingBlueprint
{
    private int stories;
    private int apartments;
    private float occupancyRate;
    private bool full;

    public BuildingBlueprint()
    {
        stories = 10;
        apartments = 20;
        occupancyRate = 1.0f;
        full = true;
    }

    public BuildingBlueprint(int stories, int apartments, float occupancyRate)
    {
        this.stories = stories;
        this.apartments = apartments;
        this.occupancyRate = occupancyRate;
        full = occupancyRate == 1;
    }

    public float getOccupancyRate()
    {
        return occupancyRate;
    }

    public void setOccupancyRate(float value)
    {
        occupancyRate = value;
        full = occupancyRate == 1;
    }

    public int getStories()
    {
        return stories;
    }

    public int getApartments()
    {
        return apartments;
    }

    public bool getFull()
    {
        return full;
    }
}