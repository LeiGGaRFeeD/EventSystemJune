using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceModification : MonoBehaviour
{
    public ResourceManager resourceManager;
    public Dropdown resourceDropdown;
    public InputField amountInputField;
    public ResourceDisplay resourceDisplay;

    public void AddResource()
    {
        int amount = int.Parse(amountInputField.text);
        resourceManager.AddResource((ResourceType)resourceDropdown.value, amount);
        resourceDisplay.UpdateResourceDisplay();
        ResetInputs();
    }

    public void RemoveResource()
    {
        int amount = int.Parse(amountInputField.text);
        resourceManager.RemoveResource((ResourceType)resourceDropdown.value, amount);
        resourceDisplay.UpdateResourceDisplay();
        ResetInputs();
    }

    private void ResetInputs()
    {
        resourceDropdown.value = 0;
        amountInputField.text = "";
    }
}
