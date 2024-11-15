using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI TextMeshPro1;
    public TextMeshProUGUI TextMeshPro2;
    public TextMeshProUGUI TextMeshPro3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshPro1.text = "Money: " + DataManager.money;
        TextMeshPro2.text = "TableLVL: " + DataManager.tableLevel;
        TextMeshPro3.text = "TskLVL: " + DataManager.taskLevel;
    }
}
