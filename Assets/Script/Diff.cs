using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diff : MonoBehaviour
{

    public enum Difficulty { Easy, Normal, Hard }
    public Difficulty select = Difficulty.Easy;

    public Gyroscope player;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = FindObjectOfType<Gyroscope>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float multiplier = 1f;

        if (select == Difficulty.Normal)
            multiplier = 2f;
        else if (select == Difficulty.Hard)
            multiplier = 4f;

        player.sp = player.speed * multiplier;
    }
}

