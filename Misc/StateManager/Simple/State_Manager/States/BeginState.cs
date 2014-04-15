using UnityEngine;
using Assets.Scripts.State_Manager.Interfaces;

namespace Assets.Scripts.State_Manager.States
{
	public class BeginState : IStateBase
	{
		private StateManager manager;

		//We initialize a constructor
		//Special method that does not have return type
		//Serves same purpose as Start()/Update(): to initialize member variables
		public BeginState (StateManager managerRef) //inputs variable managerRef of type StateManager into the constructor
		{
			//Testing if the right state is being called by StateManager
			Debug.Log ("Constructing BeginState");

			manager = managerRef;
			Time.timeScale = 0;

		}
		
		public void StateUpdate()
		{
			//If Key pressed, change state
			//Remember the new State needs its construct initiated
			//We are also passing to the new State who's the StateManager
			if(Input.GetKeyUp (KeyCode.Space))
				manager.SwitchState(new PlayState(manager));


		}

		public void ShowIt()
		{
			if (GUI.Button(new Rect(10,10,150,100), "Press to Play!"))
			{
				//this pauses the game whilst in this screen
				Time.timeScale = 1;
				manager.SwitchState (new PlayState(manager));
			}
		}

		public void StateFixedUpdate()
		{

		}
			
	}
}

