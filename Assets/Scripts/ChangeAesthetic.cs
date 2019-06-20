using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChangeAesthetic : MonoBehaviour
{
    //Helmet Variables
    #region Helmets
    [Header("Helmet")]
    public SpriteRenderer Helmet;
    public GameObject HelmPanel;
    public Image SquareHelmetDisplay;

    //helmetsArray
    public Sprite[] helmets;


    public void ChangeHelmMenuPanelState(bool state)
    {
        HelmPanel.SetActive(state);
    }

    #endregion
    //Arm Variables
    #region Arms
    [Header("LeftArm")]
    public SpriteRenderer LeftArm;
    public Sprite[] leftarms;
    public int L_index;
    [Header("RightArm")]
    public SpriteRenderer RightArm;
    public Sprite[] rightarms;
    public int R_index;
    //I did arms like this because I didn't have enough space to display them like the rest
    #endregion
    //Torso Variables
    #region Torso
    [Header("Torso")]
    public SpriteRenderer Torso;
    public GameObject TorsoPanel;
    public Image SquareTorsoDisplay;

    //torsosArray
    public Sprite[] torsos;

    
    public void ChangeTorsoMenuPanelState(bool state)
    {
        TorsoPanel.SetActive(state);
    }

    #endregion
    //Leg Variables
    #region Legs
    [Header("Legs")]
    public SpriteRenderer Leg;
    public GameObject LegPanel;
    public Image SquareLegDisplay;

    //torsosArray
    public Sprite[] legs;


    public void ChangeLegMenuPanelState(bool state)
    {
        LegPanel.SetActive(state);
    }
    #endregion
    //Display Variables
    #region Display Variables
    [Header("DisplayVariables")]
    //What Sprite is going to be rendered
    public int DisplayHelmet = 0;
    public int DisplayTorso = 0;
    public int DisplayLegs = 0;
    #endregion

    void Update()
    {
        #region UpdateSprites
        //Buttons Display what is currently selected
        SquareHelmetDisplay.sprite = Helmet.sprite;
        SquareTorsoDisplay.sprite = Torso.sprite;
        SquareLegDisplay.sprite = Leg.sprite;


        #region DisplaySprites
        // Setting the number for which helmet is diplayed
        for (int i = 0; i < helmets.Length; i++)
        {
            if (i == DisplayHelmet)
            {
                Helmet.sprite = helmets[i];
            }
        }

        for (int i = 0; i < torsos.Length; i++)
        {
            if (i == DisplayTorso)
            {
                Torso.sprite = torsos[i];
            }
        }

        for (int i = 0; i < legs.Length; i++)
        {
            if (i == DisplayLegs)
            {
                Leg.sprite = legs[i];
            }
        }

        for (int i = 0; i < leftarms.Length; i++)
        {
            if (i == L_index)
            {
                LeftArm.sprite = leftarms[i];
            }
        }

        for (int i = 0; i < rightarms.Length; i++)
        {
            if (i == R_index)
            {
                RightArm.sprite = rightarms[i];
            }
        }
        #endregion
        #endregion

    }
    #region Functions
    #region ChangeSpriteButton
    //Setting the sprite that is equal to the index as the sprite that is being shown
    public void ChangeHelmetSprite(int index)
    {
        DisplayHelmet = index;
    }
    public void ChangeTorsoSprite(int index)
    {
        DisplayTorso = index;
    }
    public void ChangeLegSprite(int index)
    {
        DisplayLegs = index;
    }
    public void Swap()
    {
        // if the index is less than arms than move to the next option, - 1 because arrays start at 0
        if (L_index < leftarms.Length - 1)
        {
            L_index++;
        }
        //if not reset index to 0
        else
        {
            L_index = 0;
        }
        if (R_index < rightarms.Length - 1)
        {
            R_index++;
        }
        else
        {
            R_index = 0;
        }
    }
    #endregion
    #endregion
}
