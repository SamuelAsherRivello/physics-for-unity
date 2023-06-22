using UnityEngine;
using UnityEngine.SceneManagement;

namespace RMC.UnityGamePhysics.Sections.Section05
{
	/// <summary>
	/// Typically we DO NOT manually call Physics.Simulate.
	/// This demos does manually call it to illustrate how it works.
	/// Depending on your game, you can add one of the 2 techniques shown
	/// for time dilation (slowing down time).
	/// </summary>
	public class PhysicsSimulate : MonoBehaviour
	{
		[Range(1, 120)]
		public int TargetFrameRate = 60;

		private float _timer;

		private float _physicsScale = 1;

		protected void Start()
		{
			// FrameRate		------------------------------------
			// Required to manually manipulate framerate
			QualitySettings.vSyncCount = 0;

			// Physics			------------------------------------
			// True is default. 
			// This simulationMode requires us to manually call Simulate below
			Physics.simulationMode = SimulationMode.Script;
		}

		protected void OnValidate()
		{
			// FrameRate		------------------------------------
			// Correct values to a good range of 1 to 120
			// Change the frameRate
			TargetFrameRate = Mathf.Clamp(TargetFrameRate, 1, 120);
			if (Application.targetFrameRate != TargetFrameRate)
			{
				Application.targetFrameRate = TargetFrameRate;
				Debug.Log(Application.targetFrameRate);
			}
		}

		protected void Update()
		{
			// Physics			------------------------------------
			if (Physics.simulationMode != SimulationMode.Script)
			{
				return; // Do nothing here if we are not in Script mode
			}

			// Time Dilation	------------------------------------
			if (Input.GetKey(KeyCode.LeftShift))
			{
				// Slow Speed
				Time.timeScale = 0.25f;
			}
			else
			{
				// Normal Speed
				Time.timeScale = 1;
			}

			// Physics Dilation	------------------------------------
			if (Input.GetKey(KeyCode.Space))
			{
				// Slow Speed
				_physicsScale = 0.25f;
			}
			else
			{
				// Normal Speed
				_physicsScale = 1;
			}

			_timer += Time.deltaTime;

			// Physics			------------------------------------
			// Wait enough "DeltaTime" before calling Simulate()
			// Catch up with the game time.
			// Advance the physics simulation in portions of Time.fixedDeltaTime

			// DEMO: Comment out the while to see the dilation NOT work
			while (_timer >= Time.fixedDeltaTime)
			{
				_timer -= Time.fixedDeltaTime / _physicsScale;

				// Note that generally, we don't want to pass variable delta to Simulate 
				// as that leads to unstable results.
				Physics.Simulate(Time.fixedDeltaTime);
			}

			// Here you can access the transforms state right after the simulation, if needed
		}
	}
}