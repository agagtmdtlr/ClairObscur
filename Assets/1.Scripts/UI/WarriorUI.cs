using TMPro;
using UnityEngine;

public class WarriorUI : MonoSingleton<WarriorUI>
{
    [SerializeField] TMP_Text rankText;
    
    
    string[] rankList = {"D", "C" , "B", "A", "S"};
    
    Color zeroGaugeColor = new Color(0f, 0f, 0f, 1f); // Gray color for zero gauge
    Color maxGaugeColor = new Color(1f, 0f, 0f, 1f); // Gray color for zero gauge
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetGauge(0);
        SetRank(0);
    }
    
    public int GetMaxRank() => rankList.Length - 1;
    
    public void SetGauge(float value)
    {
        rankText.colorGradient = new VertexGradient(Color.Lerp(zeroGaugeColor, maxGaugeColor, value));
    }
    
    public void SetRank(int rankIndex)
    {
        if (rankIndex < 0 || rankIndex >= rankList.Length)
        {
            Debug.LogError("Invalid rank index");
            return;
        }
        
        rankText.text = rankList[rankIndex];
    }

    
}
