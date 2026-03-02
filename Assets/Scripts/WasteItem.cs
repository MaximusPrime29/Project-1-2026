using UnityEngine;

[CreateAssetMenu(fileName = "WasteItem", menuName = "Scriptable Objects/WasteItem")]
public class WasteItem : ScriptableObject
{
    public string itemName;
    public WasteType type;
    
}
