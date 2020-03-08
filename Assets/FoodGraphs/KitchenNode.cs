using UnityEngine;
using System.Collections.Generic;

namespace XNode.FoodNodes
{
    public class KitchenNode : XNode.Node
    {
        [Output] public List<KitchenNode> NextNodes;
        [Input] public List<KitchenNode> PreviousNodes;

        public string Name;
        [System.NonSerialized] public KitchenItem kitchenItem;

        public List<LocationNode> GetNextFoodLocations()
        {
            List<LocationNode> foodLocations = new List<LocationNode>();

            var nextNodes = GetOutputs("NextNodes");
            foreach (var node in nextNodes)
            {
                LocationNode foodLocNode = node as LocationNode;
                if (foodLocNode != null)
                {
                    foodLocations.Add(foodLocNode);
                }
            }
            return foodLocations;
        }

        /// <summary>
        /// Get port outputs by name
        /// </summary>
        /// <param name="portName"></param>
        /// <returns></returns>
        public KitchenNode[] GetOutputs(string portName)
        {
            KitchenNode[] outputs = null;
            NodePort port = GetOutputPort(portName);
            if (port != null && port.ConnectionCount > 0)
            {
                var ports = port.GetConnections();
                outputs = new KitchenNode[ports.Count];
                for (int i = 0; i < ports.Count; i++)
                {
                    outputs[i] = ports[i].node as KitchenNode;
                }
            }

            return outputs;
        }

        /// <summary>
        /// Get port inputs by name
        /// </summary>
        /// <param name="portName"></param>
        /// <returns></returns>
        public KitchenNode[] GetInputs(string portName)
        {
            KitchenNode[] inputs = null;
            NodePort port = GetInputPort(portName);
            if (port != null && port.ConnectionCount > 0)
            {
                var ports = port.GetConnections();
                inputs = new KitchenNode[ports.Count];
                for (int i = 0; i < ports.Count; i++)
                {
                    inputs[i] = ports[i].node as KitchenNode;
                }
            }

            return inputs;
        }

    }
}