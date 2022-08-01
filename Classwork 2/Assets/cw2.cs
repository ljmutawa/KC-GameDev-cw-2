using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw2 : MonoBehaviour
{
    //hero details
    string heroName = "Sara";
    float heroHeight = 167.3f;
    int heroAge = 28;
    string heroSuperPower = "healing powers";

    //villain details
    string villainName = "Aria";
    float villainHeight = 159.8f;
    int villainAge = 32;
    string villainSuperPower = "shape-shifting powers";


    // Start is called before the first frame update
    void Start()
    {
        int ageDifference = villainAge - heroAge;

        print(heroName + " is " + heroHeight + "cm tall and " + heroAge + " years old, she was born with " + heroSuperPower + ".");
        print(villainName + " is " + villainHeight + "cm tall and " + villainAge + " years old, she was born with " + villainSuperPower + ".");
        print(heroName + " and " + villainName + " are " + ageDifference + " years apart.");

        //bonus
        heroHeight += 5;
        villainSuperPower = "no powers";

        print(heroName + " is " + heroHeight + "cm tall and " + heroAge + " years old, she was born with " + heroSuperPower + ".");
        print(villainName + " is " + villainHeight + "cm tall and " + villainAge + " years old, she was born with " + villainSuperPower + ".");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
