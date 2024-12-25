using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarController : MonoBehaviour
{
    public Image bar;
    float amount;
    float maxAmount = 100;
    float lerpSpeed;

    // Start is called before the first frame update
    void Start()
    {
        amount = maxAmount;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AmountBarFiller()
    {
        if (amount > maxAmount) amount = maxAmount;
        if (amount < 0) amount = 0;

        bar.fillAmount = amount / maxAmount;
    }

    public void ChangeAmount(float amount)
    {
        this.amount += amount;
    }

    public void ColorChanger()
    {
        Color amountColor = Color.Lerp(Color.red, Color.green, amount / maxAmount);
        bar.color = amountColor;    
    }
}
