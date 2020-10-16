using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{
    [SerializeField] Guns[] guns;
    [SerializeField] int startingIndex = 0;
    int selectIndex = 0;
    int currentIndex = -1;

    void Start()
    {
        ChangeGun(startingIndex);
    }

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            selectIndex++;
            if (selectIndex > guns.Length - 1)
                selectIndex = 0;
            ChangeGun(selectIndex);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            selectIndex--;
            if (selectIndex < 0)
                selectIndex = guns.Length - 1;
            ChangeGun(selectIndex);
        }
    }

    void ChangeGun(int index)
    {
        if (index == currentIndex)
            return;

        if (index < 0 || index > guns.Length - 1)
            return;

        selectIndex = currentIndex = index;
        for (int i = 0; i < guns.Length; i++)
            guns[i].gameObject.SetActive(false);

        guns[index].gameObject.SetActive(true);
    }
}
