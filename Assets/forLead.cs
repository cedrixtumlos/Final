using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class forLead : MonoBehaviour {

	public Text Top1;
	public Text Top2;
	public Text Top3;
	public Text Top4;
	public Text Top5;
	public Text Top6;
	public Text Top7;
	public Text Top8;
	public Text Top9;
	public Text Top10;

	// Use this for initialization
	private int myscore;
	private int top1;
	private int top2;
	private int top3;
	private int top4;
	private int top5;
	private int top6;
	private int top7;
	private int top8;
	private int top9;
	private int top10;

	// Use this for initialization
	void Start () {

		top1 = PlayerPrefs.GetInt ("Top1",0);
		top2 = PlayerPrefs.GetInt ("Top2",0);
		top3 = PlayerPrefs.GetInt ("Top3",0);
		top4 = PlayerPrefs.GetInt ("Top4",0);
		top5 = PlayerPrefs.GetInt ("Top5",0);
		top6 = PlayerPrefs.GetInt ("Top6",0);
		top7 = PlayerPrefs.GetInt ("Top7",0);	
		top8 = PlayerPrefs.GetInt ("Top8",0);
		top9 = PlayerPrefs.GetInt ("Top9",0);
		top10 = PlayerPrefs.GetInt ("Top10",0);
		Top1.text = "Top 1: " + top1;
		Top2.text = "Top 2: " + top2;
		Top3.text = "Top 3: " + top3;
		Top4.text = "Top 4: " + top4;
		Top5.text = "Top 5: " + top5;
		Top6.text = "Top 6: " + top6;
		Top7.text = "Top 7: " + top7;
		Top8.text = "Top 8: " + top8;
		Top9.text = "Top 9: " + top9;
		Top10.text = "Top 10: " + top10;


	}
	
	// Update is called once per frame
	void Update () {


	}
}
