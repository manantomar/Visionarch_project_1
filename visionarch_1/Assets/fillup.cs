using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fillup : MonoBehaviour {

	// Use this for initialization
	public Material[] mat;
	public GameObject[] im_ar;
	public Image timer;
	float time = 5.0f;
	public bool flag = false;
	public bool chip = false;
	public GameObject floor;

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

			im_ar [0].GetComponent<Renderer> ().enabled = true;
			im_ar [1].GetComponent<Renderer> ().enabled = true;
			im_ar [2].GetComponent<Renderer> ().enabled = true;
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

				if (im_ar [i].isStatic == true) {
					floor.GetComponent<Renderer> ().material = mat [i];



					tmp_mat = mat [i];
					mat [i] = mat [3];
					mat [3] = tmp_mat;

					//tmp_obj = im_ar [i];
					//im_ar [i] = im_ar [3];
					//im_ar[3] = tmp_obj;

					im_ar [0].GetComponent<Renderer> ().enabled = false;
					im_ar [1].GetComponent<Renderer> ().enabled = false;
					im_ar [2].GetComponent<Renderer> ().enabled = false;

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
