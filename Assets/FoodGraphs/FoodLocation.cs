using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode.FoodNodes;

public class FoodLocation : KitchenItem
{
    public LocationNode locationNode;
    public FoodItem food;
    public Transform SpawnPoint;

    protected override void Start()
    {
        base.Start();
        locationNode = _kitchenNode as LocationNode;
    }

    public bool IsOccupied()
    {
        bool isOccupied = food != null;
        return isOccupied;
    }

    public bool IsOpen()
    {
        bool isOpen = food == null;
        return isOpen;
    }

    public void SetFood(FoodItem f)
    {
        food = f;
        food.transform.SetParent(SpawnPoint);
        food.transform.localPosition = Vector3.zero;
        food.transform.localScale = Vector3.one;
        food.transform.localRotation = Quaternion.identity;
    }
}
