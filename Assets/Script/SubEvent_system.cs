using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubEvent_system : MonoBehaviour
{
    int max_value = 1000;
    int min_value = 0;
    float fire_probability;
    float probability;
    
    // Start is called before the first frame update
    void Start()
    {
        fire_probability = 0;
        probability = 990;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(Rand());
            Debug.Log("R");
        }

        if(fire_probability > probability)
        {
            Debug.Log("화재발생");
        }
    }


    private IEnumerator Rand()
    {
        yield return new WaitForSeconds(1);
        fire_probability = Random.Range(min_value, max_value + 1);
        Debug.Log(fire_probability);

    }
}
