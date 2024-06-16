using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public int wood = 0;
    public int stone = 0;
    public int food = 0;

    public void ResetResources()
    {
        wood = 0;
        stone = 0;
        food = 0;
    }

    public void AddResource(ResourceType type, int amount)
    {
        switch (type)
        {
            case ResourceType.Wood:
                wood += amount;
                break;
            case ResourceType.Stone:
                stone += amount;
                break;
            case ResourceType.Food:
                food += amount;
                break;
        }
    }

    public void RemoveResource(ResourceType type, int amount)
    {
        switch (type)
        {
            case ResourceType.Wood:
                wood = Mathf.Max(wood - amount, 0);
                break;
            case ResourceType.Stone:
                stone = Mathf.Max(stone - amount, 0);
                break;
            case ResourceType.Food:
                food = Mathf.Max(food - amount, 0);
                break;
        }
    }
}
