using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public float health;

    public float bulletSpeed;

    bool dead = false;

    Transform  muzzle;

    public Transform floatingText;
    
    public Transform bullet;

    public Transform bloodParticle;

    public Slider slider;

    bool mouseIsNotOverUI;


    // Start is called before the first frame update
    void Start()
    {
        muzzle  = gameObject.transform.GetChild(1);
        slider.maxValue = health;
        slider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        mouseIsNotOverUI = EventSystem.current.currentSelectedGameObject == null;
        if (Input.GetMouseButtonDown(0) && mouseIsNotOverUI)
        {
            ShotBullet();
        }
    }
    public void GetDamage(float damage)
    {
        Instantiate(floatingText,transform.position,Quaternion.identity).GetComponent<TextMesh>().text=damage.ToString();
        if ((health - damage) >= 0)
        {
            health -= damage;
        }
        else if ((health - damage) < 0)
        {
            health = 0;
        }
        slider.value = health;
        AmIDead();
    }
    void AmIDead()
    {

        if (health <= 0)
        {
            Destroy(Instantiate(bloodParticle, transform.position,Quaternion.identity),3f);
            DataManager.Instance.LoseProcess();
            dead = true;
            Destroy(gameObject);
        }
    }
    void ShotBullet()
    {
        Transform tempBullet;
        tempBullet = Instantiate(bullet, muzzle.position, Quaternion.identity);
        tempBullet.GetComponent<Rigidbody2D>().AddForce(muzzle.forward * bulletSpeed);
        DataManager.Instance.ShotBullet++;
    }
}
