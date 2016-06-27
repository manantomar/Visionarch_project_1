using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fillup_2 : MonoBehaviour {

	// Use this for initialization
	public Material[] mat_wl;
	public GameObject[] wl_ar;
	public Image timer;
	float time = 5.0f;
	public bool flag = false;
	public bool chip = false;
	public GameObject wall;

	public GameObject tmp_obj;
	public Material tmp_mat;

	void Start () {


	}

	// Update is called once per frame
	void Update () {

		if (flag == true)
			timer.fillAmount += Time.deltaTime / time;
		if (flag == false)
			timer.fillAmount = 0;
	}


	public void select_mat(){

		flag = true;

		if (timer.fillAmount == 1) {

			wl_ar [0].GetComponent<Renderer> ().enabled = true;
			wl_ar [1].GetComponent<Renderer> ().enabled = true;
			wl_ar [2].GetComponent<Renderer> ().enabled = true;
			flag = false;
		}
	}

	public void deselect_mat(){

		if(timer.fillAmount != 1)
			flag = false;
	}

	public void pointer_enter(){

		flag = true;

		if (timer.fillAmount == 1) {

			chip = true;
			for (int i = 0; i < 3; i++) {

				if (wl_ar [i].isStatic == true) {
					wall.GetComponent<Renderer> ().material = mat_wl [i];



					tmp_mat = mat_wl [i];
					mat_wl [i] = mat_wl [3];
					mat_wl [3] = tmp_mat;

					//tmp_obj = im_ar [i];
					//im_ar [i] = im_ar [3];
					//im_ar[3] = tmp_obj;

					wl_ar [0].GetComponent<Renderer> ().enabled = false;
					wl_ar [1].GetComponent<Renderer> ().enabled = false;
					wl_ar [2].GetComponent<Renderer> ().enabled = false;

					flag = false;
				}
			}
		}
	}

	public void pointer_exit(){

		if(timer.fillAmount != 1)
			flag = false;
	}


}
