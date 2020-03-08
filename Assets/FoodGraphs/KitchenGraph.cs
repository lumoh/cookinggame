using System;
using System.Collections.Generic;
using UnityEngine;
using XNode.FoodNodes;

[Serializable, CreateAssetMenu(fileName = "NewKitchenGraph", menuName = "Cooking/Create Kitchen Graph")]
public class KitchenGraph : XNode.NodeGraph
{
    public List<KitchenNode> GetNodes()
    {
        List<KitchenNode> kitchenNodes = new List<KitchenNode>();
        foreach(var node in nodes)
        {
            KitchenNode kNode = node as KitchenNode;
            if(kNode != null)
            {
                kitchenNodes.Add(kNode);
            }
        }
        return kitchenNodes;
    }

    public KitchenNode GetNodeByName(string name)
    {
        KitchenNode node = null;
        var kitchenNodes = GetNodes();
        foreach (var kNode in kitchenNodes)
        {
            if (kNode.Name == name)
            {
                node = kNode;
                break;
            }
        }

        return node;
    }
}