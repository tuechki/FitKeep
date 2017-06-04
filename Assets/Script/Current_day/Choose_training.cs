using UnityEngine;
using System.Collections;

public class Choose_training : MonoBehaviour {
	
	public GameObject workout_1, new_workout;
	static public int workout_count;
	int type;

	public int biceps, triceps, shoulder, forearm, biceps_o, triceps_o, shoulder_o, forearm_o;
	public int abs, chest, back, abs_o, chest_o, back_o;
	public int calf, thigh, buttocks, calf_o, thigh_o, buttocks_o;


	// Use this for initialization
	void Start () {
	
		workout_count = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Workout_1 () {

		Make_workout();
		type = 1;
	}

	public void Workout_2 () {

		Make_workout();
		type = 2;
	}

	public void Workout_3 () {

		Make_workout();
		type = 3;
	}

	public void Workout_4 () {

		Make_workout();
		type = 4;
	}

	public void Workout_5 () {

		Make_workout();
		type = 5;
	}

	public void Save() {

		if (workout_count == 1) {

			workout_count = 0;
			Destroy (new_workout);
		}

		if (type == 1) {

			biceps = (int)(1.5 * New_workout.reps);
			triceps = (int)(1.3 * New_workout.reps);
			forearm = (int)(1.1 * New_workout.reps);
		}

		if (type == 2) {
			
			chest = (int)(1.5 * New_workout.reps);
			triceps = (int)(1.4 * New_workout.reps);
			shoulder = (int)(1.1 * New_workout.reps);
		}

		if (type == 3) {
			
			biceps = (int)(1.3 * New_workout.reps);
			triceps = (int)(1.1 * New_workout.reps);
			shoulder = (int)(1.5 * New_workout.reps);
		}

		New_workout.reps = 0;
	}

	public void Finish() {

		Get_overalls ();
		Check ();
		Save_overalls ();
		Clear ();
	}

	public void Delete() {
		
		Destroy(new_workout);
		workout_count = 0;
		New_workout.reps = 0;
	}

	void Make_workout() {

		if (workout_count < 1) {

			new_workout = (GameObject)Instantiate (workout_1, gameObject.transform.position, Quaternion.identity);
			new_workout.transform.parent = gameObject.transform;
			workout_count = 1;
		}
	}

	void Get_overalls() {

		biceps_o = PlayerPrefs.GetInt ("biceps", 0);
		triceps_o = PlayerPrefs.GetInt ("triceps", 0);
		forearm_o = PlayerPrefs.GetInt ("forearm", 0);
		shoulder_o = PlayerPrefs.GetInt ("shoulder", 0);
		chest_o = PlayerPrefs.GetInt ("abs", 0);
		abs_o = PlayerPrefs.GetInt ("chest", 0);
		back_o = PlayerPrefs.GetInt ("back", 0);
		calf_o = PlayerPrefs.GetInt ("calf", 0);
		thigh_o = PlayerPrefs.GetInt ("thigh", 0);
		buttocks_o = PlayerPrefs.GetInt ("buttocks", 0);
	}

	void Check() {

		if (biceps != 0 && (biceps - biceps_o) <= 10) {

			if (biceps_o == 0)
				biceps_o = biceps;
			else
				biceps_o = (int)((biceps + biceps_o) / 2);
		}

		if (triceps != 0 && (triceps - triceps_o) <= 10) {
			
			if (triceps_o == 0)
				triceps_o = triceps;
			else
				triceps_o = (int)((triceps + triceps_o) / 2);
		}

		if (forearm != 0 && (forearm - forearm_o) <= 10) {

			if (forearm_o == 0)
				forearm_o = forearm;
			else
				forearm_o = (int)((forearm + forearm_o) / 2);
		}

		if (shoulder != 0 && (shoulder - shoulder_o) <= 10) {

			if (shoulder_o == 0)
				shoulder_o = shoulder;
			else
				shoulder_o = (int)((shoulder + shoulder_o) / 2);
		}

		if (abs != 0 && (abs - abs_o) <= 10) {

			if (abs_o == 0)
				abs_o = abs;
			else
				abs_o = (int)((abs + abs_o) / 2);
		}

		if (chest != 0 && (chest - chest_o) <= 10) {

			if (chest_o == 0)
				chest_o = chest;
			else
				chest_o = (int)((chest + chest_o) / 2);
		}

		if (back != 0 && (back - back_o) <= 10) {

			if (back_o == 0)
				back_o = back;
			else
				back_o = (int)((back + back_o) / 2);
		}

		if (calf != 0 && (calf - calf_o) <= 10) {

			if (calf_o == 0)
				calf_o = calf;
			else
				calf_o = (int)((calf + calf_o) / 2);
		}

		if (thigh != 0 && (thigh - thigh_o) <= 10) {

			if (thigh_o == 0)
				thigh_o = thigh;
			else
				thigh_o = (int)((thigh + thigh_o) / 2);
		}

		if (buttocks != 0 && (buttocks - buttocks_o) <= 10) {

			if (buttocks_o == 0)
				buttocks_o = buttocks;
			else
				buttocks_o = (int)((buttocks + buttocks_o) / 2);
		}
	}

	void Save_overalls() {

		PlayerPrefs.SetInt ("biceps", biceps_o);
		PlayerPrefs.SetInt ("triceps", triceps_o);
		PlayerPrefs.SetInt ("forearm", forearm_o);
		PlayerPrefs.SetInt ("shoulder", shoulder_o);
		PlayerPrefs.SetInt ("abs", abs_o);
		PlayerPrefs.SetInt ("chest", chest_o);
		PlayerPrefs.SetInt ("back", back_o);
		PlayerPrefs.SetInt ("calf", calf_o);
		PlayerPrefs.SetInt ("thigh", thigh_o);
		PlayerPrefs.SetInt ("buttocks", buttocks_o);
		PlayerPrefs.Save ();
	}

	void Clear() {

		biceps = 0;
		triceps= 0;
		forearm = 0;
		shoulder = 0;
		chest = 0;
		abs = 0;
		back = 0;
		calf = 0;
		thigh = 0;
		buttocks = 0;
	}
}
