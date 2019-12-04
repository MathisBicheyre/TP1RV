using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class machineAEtatScript : MonoBehaviour
{
	public SelectionScript select;
	public NavigationScript navig;
	public MaterielScript mat;
	public SelectionnableDistScript selectdist;
	public PrendObjet prend;
	public gereCameras cams;
	public State state;
	public State prev_state;
	public CameraState camera_state;

	private float start = 0.0f;
	private float end = 0.0f;

	public enum State {
		NAVIGATION,
        SELECTION,
		MANIPULATION,
    }

	public enum CameraState
	{
		SIDE,
		ABOVE,
		BEHIND,
	}

    // Start is called before the first frame update
    void Start()
    {

	}

	// Update is called once per frame
	void Update()
	{
		
		switch (camera_state)
		{
			case CameraState.SIDE:
				if (mat.B2)
				{
					camera_state = CameraState.ABOVE;
					cams.Switch();
				}
				break;
			case CameraState.ABOVE:
				if (mat.B2)
				{
					camera_state = CameraState.BEHIND;
					cams.Switch();
				}
				break;
			case CameraState.BEHIND:
				if (mat.B2)
				{
					camera_state = CameraState.SIDE;
					cams.Switch();
				}
				break;
		}

		switch (state)
		{
			case State.NAVIGATION:
				if (mat.B1)
				{
					if (!prend.estPris)
					{
						state = State.SELECTION;
					}
					else if (!prend.estPris)
					{
						state = State.MANIPULATION;
					}
				}
				break;

			case State.SELECTION:
				if (mat.B1)
				{
					if (!selectdist.EstSelectionnable)
						state = State.NAVIGATION;
					else if (selectdist.EstSelectionnable)
					{
						prend.Prise();
						state = State.MANIPULATION;
					}
				}
				break;

			case State.MANIPULATION:
				if (mat.B1)
				{
					if (!prend.estLachable)
						state = State.NAVIGATION;
					else if (prend.estLachable)
					{
						state = State.NAVIGATION;
					}
				}
				break;
		}

		writeLog();
		prev_state = state;
	}

	void writeLog()
	{
		string path = "C:/git/TP1RV/TP1RV/Assets/robot mobile/log/log.txt";

		// Create a file to write to.
		using (StreamWriter sw = File.AppendText(path))
		{
			if (prev_state != state)
			{
				end = Time.time;
				float state_period = end - start;
				start = end;
				sw.WriteLine(prev_state + " lasted " + state_period);
			}
			sw.Close();
		}
		
	}

	void OnGUI()
	{
		GUI.Label(new Rect(10, 10, 500, 20), "In " + state + " from " + start + " to " + Time.time);
	}
}
