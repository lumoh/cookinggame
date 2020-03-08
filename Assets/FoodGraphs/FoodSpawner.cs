using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode.FoodNodes;

public class FoodSpawner : KitchenItem
{
    protected SpawnFoodNode spawnNode;

    protected override void Start()
    {
        base.Start();
        spawnNode = _kitchenNode as SpawnFoodNode;
    }

    // when tapped, spawn food.
    // check if locations are open
    // spawn food there
    protected void OnMouseDown()
    {
        var nextFoodLocations = GetNextFoodLocations();
        foreach(var loc in nextFoodLocations)
        {
            if(loc.IsOpen())
            {
                spawnFoodAtLocation(loc);
                break;
            }
        }
    }

    protected FoodItem spawnFood()
    {
        FoodItem foodPrefab = Resources.Load<FoodItem>("Foods/" + spawnNode.FoodName);
        var newFood = Instantiate(foodPrefab);
        return newFood;
    }

    protected void spawnFoodAtLocation(FoodLocation foodLocation)
    {
        FoodItem newFood = spawnFood();
        foodLocation.SetFood(newFood);
    }
}
