﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class damagable : MonoBehaviour {

    public int currHealth = 100;
    private int maxHealth = 100;
    private int armor = 0;
    private static playerController pc;
    private static PlayerTextHandler pth;
    public RectTransform healthBar;

    private void Start()
    {
        pc = this.gameObject.GetComponent<playerController>();
        pth = this.gameObject.GetComponent<PlayerTextHandler>();
        armor = pth.getArmor();
        maxHealth = pth.getHealth();
        Debug.Log(maxHealth);
        currHealth = maxHealth;
    }

    void Update () {
        bool complete = false;
        if (currHealth <= 0)
        {
            if (complete == false)
            {
                gameObject.SetActive(false);
                Deathwrite();
                complete = true;
                SceneManager.LoadScene("HubWorld");
            }

            Debug.Log("Game Over");

        }
	}

    public void updateMaxHealth(int n)
    {
        maxHealth = maxHealth + n;
        currHealth = maxHealth;
    }

    public void updateArmor(int n)
    {
        if(armor <= 0)
        {
            armor = n;
        }
        else
        {
            armor += n;
        }
    }

    public void Deathwrite()
    {
        this.gameObject.GetComponent<PlayerTextHandler>().writePlayer(maxHealth, pc.getXP(), armor, "pistol", "pistol", "", "");
    }

    public void write()
    {
        this.gameObject.GetComponent<PlayerTextHandler>().writePlayer(maxHealth, pc.getXP(), armor, pc.currWep, pc.weapon1, pc.weapon2, pc.weapon3);
    }

    public void takeDamage(int damage)
    {
        if(armor > 0)
        {
            armor -= damage;
        }
        else
        {
            currHealth -= damage;
            healthBar.sizeDelta = new Vector2(currHealth, healthBar.sizeDelta.y);
        }
        
    }
}
