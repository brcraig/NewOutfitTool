/*
Full name: Samantha Mondragon, Briana Craig 
Student ID: 2406434,  2394738
Email: mondragonlanderos@chapman.edu, brcraig@chapman.edu
Course & Section: CPSC 245 - 01
Final Exam: Outfit Tool 
*/
/*
This source file serves at the parent for all of our different outfit states,
it has the event types used for our on click event system along with methods
to be overriden by individual states
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitState : MonoBehaviour
{
    
    public enum EventType
    {
        OutfitStart,
        OutfitSelect,
        OutfitHat,
        OutfitShirt,
        OutfitPants,
        OutfitShoes,
        OutfitEnd
    }

    protected OutfitManager outfitManager;
    public OutfitState(OutfitManager manager)
    {
        outfitManager = manager;
    }
    public virtual void OnMyStateEntered(){}
    public virtual void OnMyStateExit(){}
    public virtual void StateUpdate(){}

    //this method is not virtual because all states need a way to move to a new state
    //and would all have the same code
    /*
    OnEventReceived
    It has no return type because it is a function used for switching between
    states, taking in the parameter of eventType in order to trigger an event
    that will change to a new state of that eventType. It goes in the parent class
    and not the individual state classes because all states need a way to switch states
    and the code would be copied exactly
    */
    public void OnEventRecieved(EventType eventType)
    {
        switch (eventType)
        {
            case (EventType.OutfitStart):
                outfitManager.NewOutfitState(outfitManager.outfitStateStart);
                break;
            case (EventType.OutfitSelect):
                outfitManager.NewOutfitState(outfitManager.outfitStateSelect);
                break;
            case (EventType.OutfitHat):
                outfitManager.NewOutfitState(outfitManager.outfitStateHat);
                break;
            case (EventType.OutfitShirt):
                outfitManager.NewOutfitState(outfitManager.outfitStateShirt);
                break;
            case (EventType.OutfitPants):
                outfitManager.NewOutfitState(outfitManager.outfitStatePants);
                break;
            case (EventType.OutfitShoes):
                outfitManager.NewOutfitState(outfitManager.outfitStateShoes);
                break;
            case (EventType.OutfitEnd):
                outfitManager.NewOutfitState(outfitManager.outfitStateEnd);
                break;
        }
    }
}
