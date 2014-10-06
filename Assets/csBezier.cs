using UnityEngine;
using System.Collections;

public class csBezier : MonoBehaviour {

	LTBezierPath ltPath=new LTBezierPath(new Vector3[]{new Vector3(0f,0f,0f),new Vector3(3f,0f,0f),new Vector3(3f,0f,0f),new Vector3(3f,0f,3f)});

	// Use this for initialization
	void Start () {

		LeanTween.move(gameObject,ltPath.pts,4f).setOrientToPath(false).setDelay(1f).setEase(LeanTweenType.easeInOutQuad);
		//Vector3 pt = ltPath.point(0.6f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
