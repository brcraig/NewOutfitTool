/*
Full name: Samantha Mondragon, Briana Craig 
Student ID: 2406434,  2394738
Email: mondragonlanderos@chapman.edu, brcraig@chapman.edu
Course & Section: CPSC 245 - 01
Final Exam: Outfit Tool 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitManager : MonoBehaviour
{
    [HideInInspector]public OutfitStateStart outfitStateStart;
    [HideInInspector]public OutfitStateSelect outfitStateSelect;
    [HideInInspector]public OutfitStateHat outfitStateHat;
    [HideInInspector]public OutfitStateShirt outfitStateShirt;
    [HideInInspector]public OutfitStatePants outfitStatePants;
    [HideInInspector] public OutfitStateShoes outfitStateShoes;
    [HideInInspector] public OutfitStateEnd outfitStateEnd;
    [HideInInspector] OutfitState currState;
    
    public GameObject canvasStart;
    public GameObject canvasSelect;
    public GameObject canvasHat;
    public GameObject canvasShirt;
    public GameObject canvasPants;
    public GameObject canvasShoes;
    public GameObject canvasEnd;
    private void Awake()
    {
        outfitStateStart = new OutfitStateStart(this);
        outfitStateSelect = new OutfitStateSelect(this);
        outfitStateHat = new OutfitStateHat(this);
        outfitStateShirt = new OutfitStateShirt(this);
        outfitStatePants = new OutfitStatePants(this);
        outfitStateShoes = new OutfitStateShoes(this);
        outfitStateEnd = new OutfitStateEnd(this);

    }
    private void Start()
    {
        NewOutfitState(outfitStateStart);
    }

    public void Update()
    {
        if (currState != null)
        {
            currState.StateUpdate();
        }
    }
  
    /*
     NewOutfitState
     This method has no return type and takes in a type OutfitState parameter
     and it exits the previous state and enters the new state
     */
    public void NewOutfitState(OutfitState newState)
    {
        if (currState != null)
        {
            currState.OnMyStateExit();
        }
        currState = newState;
        currState.OnMyStateEntered();
    }
    public OutfitState GetCurrState()
    {
        return currState;
    }
    /*
     PublishEventToCurrentState
     This method has no return type and takes in a parameter of type OutfitType.EventType
     which it uses to update the current state to match the new state from the event
     that was just triggered
     */
    public void PublishEventToCurrentState(OutfitState.EventType eventType)
    {
        currState.OnEventRecieved(eventType);
    }
    
    /*
     ShowCanvas
     This method has no return type and takes in a string parameter
     and it shows which ever canvas matches that string name to make
     sure each state shows its matching canvas when entered
     */
    public void ShowCanvas(string canvasName)
    {
        switch (canvasName)
        {
            case ("start"):
                canvasStart.SetActive(true);
                break;
            case ("select"):
                canvasSelect.SetActive(true);
                break;
            case("hat"):
                canvasHat.SetActive(true);
                break;
            case ("shirt"):
                canvasShirt.SetActive(true);
                break;
            case("pants"):
                canvasPants.SetActive(true);
                break;
            case("shoes"):
                canvasShoes.SetActive(true);
                break;
            case("end"):
                canvasEnd.SetActive(true);
                break;
        }
    }
    
    /*
     HideCanvas
     This method has no return type and takes in a string parameter
     and it hides the canvas with the string name for any state that does 
     not match our current state
     */
    public void HideCanvas(string canvasName)
    {
        switch (canvasName)
        {
            case ("start"):
                canvasStart.SetActive(false);
                break;
            case ("select"):
                canvasSelect.SetActive(false);
                break;
            case("hat"):
                canvasHat.SetActive(false);
                break;
            case ("shirt"):
                canvasShirt.SetActive(false);
                break;
            case("pants"):
                canvasPants.SetActive(false);
                break;
            case("shoes"):
                canvasShoes.SetActive(false);
                break;
            case("end"):
                canvasEnd.SetActive(false);
                break;
        }
    }
}
