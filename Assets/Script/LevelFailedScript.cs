using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFailedScript : MonoBehaviour
{
    public GameObject levelCompletePanel;
    public GameObject levelFaiedPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0f && !levelFaiedPanel.activeSelf)
        {
            
                levelFaiedPanel.SetActive(true);
            
        }
    }
}
