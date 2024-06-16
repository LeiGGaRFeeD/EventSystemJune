using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceDisplay : MonoBehaviour
{
    public ResourceManager resourceManager;
    public GameObject resourceItemPrefab;
    public Transform contentParent;

    private void Start()
    {
        UpdateResourceDisplay();
    }

    public void UpdateResourceDisplay()
    {
        foreach (Transform child in contentParent)
        {
            Destroy(child.gameObject);
        }

        CreateResourceItem("Wood", resourceManager.wood);
        CreateResourceItem("Stone", resourceManager.stone);
        CreateResourceItem("Food", resourceManager.food);
    }

    private void CreateResourceItem(string resourceName, int amount)
    {
        GameObject newItem = Instantiate(resourceItemPrefab, contentParent);
        newItem.GetComponent<Text>().text = $"{resourceName}: {amount}";
    }
}
