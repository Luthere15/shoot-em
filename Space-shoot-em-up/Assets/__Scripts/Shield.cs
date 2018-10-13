using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [Header("Set in Inspector")]
    public float rotationPerSecond = 0.1f;

    [Header("set Dynamically")]
    public int levelShown = 0;

    Material mat;

    // Use this for initialization
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        int currLevel = Mathf.FloorToInt(Hero.S.shieldLevel);

        if (levelShown != currLevel)
        {
            levelShown = currLevel;

            mat.mainTextureOffset = new Vector2(0.2f * levelShown, 0);

        }

        float rZ = -(rotationPerSecond * Time.time * 360) % 360f;
        transform.rotation = Quaternion.Euler(0, 0, rZ);
    }
}
