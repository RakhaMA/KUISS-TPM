using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Calculate : MonoBehaviour
{
    public TMP_InputField[] inputField;

    public TextMeshProUGUI luas;
    public TextMeshProUGUI keliling;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LuasLayang2()
    {
        float d1 = float.Parse(inputField[0].text);
        float d2 = float.Parse(inputField[1].text);
        // return 0.5f * d1 * d2;
        luas.text = "Luas   = " + (0.5f * d1 * d2).ToString();

    }

    public void KelilingLayang2(){
        float d1 = float.Parse(inputField[0].text);
        float d2 = float.Parse(inputField[1].text);
        // return 2f * Mathf.Sqrt(0.25f * Mathf.Pow(d1, 2f) + 0.25f * Mathf.Pow(d2, 2f)); // calculate perimeter using the formula
        keliling.text = "Kel    = " + (2f * Mathf.Sqrt(0.25f * Mathf.Pow(d1, 2f) + 0.25f * Mathf.Pow(d2, 2f))).ToString();
    }

    public void LuasSegitiga(){
        float a = float.Parse(inputField[0].text);
        float t = float.Parse(inputField[1].text);
        luas.text = "Luas   = " + (0.5f * a * t).ToString();
    }

    public void KelilingSegitiga(){
        Debug.Log("TESSS");
        //calculate perimeter triangle using the formula
        float a = float.Parse(inputField[0].text);
        float b = float.Parse(inputField[1].text);
        //calculate c from a & b
        float c = Mathf.Sqrt(Mathf.Pow(a, 2) + Mathf.Pow(b, 2));
        Debug.Log("c = " + c.ToString());
        keliling.text = "Kel    = " + (a + b + c).ToString();


    }
}
