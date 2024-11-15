using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI TextMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshPro.text = "Money: " + DataManager.money;
    }
}
