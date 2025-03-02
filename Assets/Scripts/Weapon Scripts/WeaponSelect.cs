﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSelect : MonoBehaviour
{
    public int selectedWeapon = 0;
    
        public Text equipedweaponOne;
        public Text equipedweaponTwo;
        

    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();


    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedWeapon = selectedWeapon;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (selectedWeapon >= transform.childCount - 1)
                selectedWeapon = 0;
            else
                selectedWeapon++;
        }
        if(Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectedWeapon <= 0)
                selectedWeapon = transform.childCount - 1;
            else
                selectedWeapon--;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedWeapon = 0;
            

        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            selectedWeapon = 1;
           
}
       if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3)
        {
            selectedWeapon = 2;
        } 


        if (previousSelectedWeapon != selectedWeapon)
        {
            SelectWeapon();
        }

        if (selectedWeapon == 0)
        {
            equipedweaponOne.gameObject.SetActive(true);
            equipedweaponTwo.gameObject.SetActive(false);
        }
        if (selectedWeapon == 1)
        {
            equipedweaponOne.gameObject.SetActive(false);
            equipedweaponTwo.gameObject.SetActive(true);
        }

    }

    public void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
                i++;
        }
    } 

    /*
    weapononeTrue.gameObject.SetActive(true);
            weapontwoFalse.gameObject.SetActive(true);

        weapononeFalse.gameObject.SetActive(true);
            weapontwoTrue.gameObject.SetActive(true);
            */
}
