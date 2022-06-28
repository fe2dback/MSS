using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stock_system : MonoBehaviour
{
    private long GsRetail;
    private long GsRetail_result;
    private float changetime;
    private int change;
    private long price;
    private float resulttime;
    void Start()
    {
        GsRetail = Mathf.Abs(Random.Range(10, 999999999)*1000000); //999,999,999,000,000
        
        Debug.Log("시작금액" + GsRetail);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        ChangePrice();
    }

    private void ChangePrice()
    {
        GsRetail_result = GsRetail;
        resulttime += Time.deltaTime;
        changetime += Time.deltaTime;
        if(changetime > 1)
        {
            change = Random.Range(0, 3);
            Debug.Log("===========================");

            if (change == 0)
            {
                price = Random.Range(10000, 1000000);
                GsRetail_result -= price;
                Debug.Log("Minus" + price);
            }
            else if(change == 1)
            {
                price = Random.Range(10000, 1000000);
                GsRetail_result += price;
                Debug.Log("Plus" + price);
                
            }
            else if (change == 2)
            {
                
                Debug.Log(GsRetail_result);

            }

            Debug.Log(GsRetail_result);
            Debug.Log("===========================");
            changetime = 0;
            if(GsRetail_result < 0 )
            {
                Debug.Log("폐지");
                Debug.Log(resulttime);
            }
        }
    }
    
    



}
