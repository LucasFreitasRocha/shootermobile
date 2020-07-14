using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : Health
{
    public Slider healthSlider;
    public Image damageImage;
    public Color damageColor;
    public float flashSpeed = 5;
    private bool damaged;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(damaged){
            damageImage.color =  damageColor;
        }else{
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }
    protected override void Spawn()
    {
        currentHealth = startingHealth;
    }
    protected override void Death()
    {
        isDead =  true;
    }
    public override void Takedamage(int damage, Vector3 hitPoint)
    {
        if(isDead){
            return;
        }
        damaged = true;
        currentHealth -= damage;
        healthSlider.value = currentHealth;
        if( currentHealth <= 0  ){
            Death();
        }

    }
}
