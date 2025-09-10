using UnityEngine;

[CreateAssetMenu(fileName = "HexData", menuName = "Scriptable Objects/HexData")]
public class HexData : ScriptableObject
{
    public string hexName;
    public Hex.HexTypes type;
    public Sprite[] terrainSprites;
    public Sprite[] forestSprites;
    public int[] resourceYield;
    public int moveCost;
}
