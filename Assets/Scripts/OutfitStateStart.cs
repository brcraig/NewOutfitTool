/*
Full name: Samantha Mondragon, Briana Craig 
Student ID: 2406434,  2394738
Email: mondragonlanderos@chapman.edu, brcraig@chapman.edu
Course & Section: CPSC 245 - 01
Final Exam: Outfit Tool 
*/
/*
This source files contains the override methods for 
the start state, which is the initial panel where
the player can read the directions and enter the game. 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitStateStart : OutfitState
{
    public OutfitStateStart(OutfitManager manager) : base(manager){}

    /*
     override OnMyStateEntered 
     This method overrides the virtual OnMyStateEntered
     from the parent OutfitState class, it does not take in
     any parameters or return anything, it only shows
     the canvas that matches the one for this state and hides any
     canvases that could be active before entering this state
     */
    public override void OnMyStateEntered()
    {
        string stateEnteredMessage = "Entered Starting State";
        Debug.Log(stateEnteredMessage);
        outfitManager.HideCanvas("end"); 
        outfitManager.HideCanvas("select");
        outfitManager.ShowCanvas("start");
    }
}
