using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trade_system : MonoBehaviour
{

    private int money;
    // Start is called before the first frame update
    void Start()
    {
        money = 100000;
    }

    // Update is called once per frame
    void Update()
    {
        Buy();
    }

    private void Wallet()
    {
        
        Debug.Log(money);
    }
    private void Buy()
    {
        
        if(Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("상점");
            Debug.Log("1 : 라면");
            Debug.Log("2 : 과자");
            Debug.Log("3 : 음료");

        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log(money);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("라면");
            money -= 2000;
            
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("과자");
            money -= 1000;

        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("음료");
            money -= 1500;
        }
    }
}
