using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class calculatorScript : MonoBehaviour
{
    public Toggle USDToggle;
    public Toggle JPYToggle;
    public Toggle MalaysiansNo1;
    public Toggle Tea;
    public Toggle KimJongUn;
    public Toggle TaiwanIsACountry;

    public InputField AmountTxt;
    public InputField ValueTxt;

    private float USD_Rate = 0.74f;
    private float JPY_Rate = 82.78f;
    private float RM_Rate = 3.08f;
    private float EUR_Rate = 0.63f;
    private float KRW_Rate = 881.54f;
    private float TWD_Rate = 20.73f;
    // Start is called before the first frame update
    void Start()
    {
        USDToggle.isOn = false;
        JPYToggle.isOn = false;
        MalaysiansNo1.isOn = false;
        Tea.isOn = false;
        KimJongUn.isOn = false;
        TaiwanIsACountry.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void conversion()
    {
        float SGDAmount = float.Parse(AmountTxt.text);

        if (USDToggle.isOn == true)
        {
            ValueTxt.text = "$" + (SGDAmount * USD_Rate);
        }

        if (JPYToggle.isOn == true)
        {
            ValueTxt.text = "$" + (SGDAmount * JPY_Rate);
        }

        if (MalaysiansNo1.isOn == true)
        {
            ValueTxt.text = "$" + (SGDAmount * RM_Rate);
        }

        if (Tea.isOn == true)
        {
            ValueTxt.text = "$" + (SGDAmount * EUR_Rate);
        }

        if (KimJongUn.isOn == true)
        {
            ValueTxt.text = "$" + (SGDAmount * KRW_Rate);
        }

        if (TaiwanIsACountry.isOn == true)
        {
            ValueTxt.text = "$" + (SGDAmount * TWD_Rate);
        }

        if (USDToggle.isOn == true && JPYToggle.isOn == true)
        {
            ValueTxt.text = "Select only one currency";
        }

    }

    public void Clear()
    {
        AmountTxt.text = "";
        ValueTxt.text = "";
        USDToggle.isOn = false;
        JPYToggle.isOn = false;
    }
}
