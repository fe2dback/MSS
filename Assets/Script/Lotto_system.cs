using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lotto_system : MonoBehaviour
{
    // Start is called before the first frame update
    private int k;
    private ulong j = 0;
    private int cout = 0;
    private bool cc;
    private int[] result_i;
    private int matchvalue = 6;
    private int maxvalue = 10;
    private int minvalue = 1;

    void Start()
    {
        result_i = new int[matchvalue];

        for (int i = 0; i < matchvalue; i++)
        {
            result_i[i] = Random.Range(minvalue, maxvalue+1);
        }
        
        

        
    }

    // Update is called once per frame
    void Update()
    {
        if(cc == false)
        {
            StartCoroutine(roulette());

        }


        if (cc == true)
        {
            StopCoroutine(roulette());
        }

    }

    private IEnumerator roulette()
    {
        
        

            int[] result_j = new int[matchvalue];
        
            for (int j = 0; j < matchvalue; j++)
            {
                
                result_j[j] = Random.Range(minvalue, maxvalue+1);
                Debug.Log(result_i[j]+" "+result_j[j]);
                if (result_i[j] == result_j[j])
                {
                    k++;  
                }
               
            
                

            }
        if(k > cout)
        {
            cout = k;
        }
        Debug.Log("correct : "+k+" max : "+cout);
        if (k == matchvalue)
        {
            Debug.Log("Correct");
            Debug.Log("count : " + j);
            cc = true;

        }
        //Debug.Log("~~~~~~~~~~");
        k = 0;
        j++;
        yield return new WaitForFixedUpdate();
        
        
    }

      
}
