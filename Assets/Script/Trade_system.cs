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
            Debug.Log("����");
            Debug.Log("1 : ���");
            Debug.Log("2 : ����");
            Debug.Log("3 : ����");

        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log(money);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("���");
            money -= 2000;
            
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("����");
            money -= 1000;

        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("����");
            money -= 1500;
        }
    }
}
