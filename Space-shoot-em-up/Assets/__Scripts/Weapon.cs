using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    none,
    blaster,
    spread,
    phaser,
    missile,
    laser,
    sheild,

}

[System.Serializable]
public class WeaponDefinition
{
    public WeaponType type = WeaponType.none;
    public string    letter;
    public Color     color = Color.white;
    public GameObject projectilePrefab;
    public Color       projectileColor = Color.white;
    public float damageOnHit = 0;
    public float continuousDamage = 0;
    public float delayBetweenShots;
    public float velocity = 20;
}

public class Weapon : MonoBehaviour
{
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
