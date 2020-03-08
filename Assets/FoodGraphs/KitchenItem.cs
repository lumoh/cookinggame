using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode.FoodNodes;

public class KitchenItem : MonoBehaviour
{
    protected KitchenNode _kitchenNode;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        _kitchenNode = Kitchen.instance.graph.GetNodeByName(gameObject.name);
        _kitchenNode.kitchenItem = this;
    }

    public List<FoodLocation> GetNextFoodLocations()
    {
        List<FoodLocation> nextFoodLocations = new List<FoodLocation>();
        var nodes = _kitchenNode.GetNextFoodLocations();
        foreach(var node in nodes)
        {
            FoodLocation foodLoc = node.kitchenItem as FoodLocation;
            if (foodLoc != null)
            {
                nextFoodLocations.Add(foodLoc);
            }
        }
        return nextFoodLocations;
    }
}
