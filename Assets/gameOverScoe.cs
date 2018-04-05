using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class gameOverScoe : MonoBehaviour {

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

	Text ScoreHold;
	// Use this for initialization
	void Start () {
		ScoreHold = GetComponent<Text> ();
		myscore = PlayerPrefs.GetInt ("PlayerScore",0);
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

		if(myscore>top1){
			PlayerPrefs.SetInt ("Top1",myscore);
			PlayerPrefs.SetInt ("Top2",top1);
			PlayerPrefs.SetInt ("Top3",top2);
			PlayerPrefs.SetInt ("Top4",top3);
			PlayerPrefs.SetInt ("Top5",top4);
			PlayerPrefs.SetInt ("Top6",top5);
			PlayerPrefs.SetInt ("Top7",top6);
			PlayerPrefs.SetInt ("Top8",top7);
			PlayerPrefs.SetInt ("Top9",top8);
			PlayerPrefs.SetInt ("Top10",top9);
		}
		else if(myscore>top2){

			PlayerPrefs.SetInt ("Top2",myscore);
			PlayerPrefs.SetInt ("Top3",top2);
			PlayerPrefs.SetInt ("Top4",top3);
			PlayerPrefs.SetInt ("Top5",top4);
			PlayerPrefs.SetInt ("Top6",top5);
			PlayerPrefs.SetInt ("Top7",top6);
			PlayerPrefs.SetInt ("Top8",top7);
			PlayerPrefs.SetInt ("Top9",top8);
			PlayerPrefs.SetInt ("Top10",top9);
		}else if(myscore>top3){
			PlayerPrefs.SetInt ("Top3",myscore);
			PlayerPrefs.SetInt ("Top4",top3);
			PlayerPrefs.SetInt ("Top5",top4);
			PlayerPrefs.SetInt ("Top6",top5);
			PlayerPrefs.SetInt ("Top7",top6);
			PlayerPrefs.SetInt ("Top8",top7);
			PlayerPrefs.SetInt ("Top9",top8);
			PlayerPrefs.SetInt ("Top10",top9);
		}else if(myscore>top4){
			
			PlayerPrefs.SetInt ("Top4",myscore);
			PlayerPrefs.SetInt ("Top5",top4);
			PlayerPrefs.SetInt ("Top6",top5);
			PlayerPrefs.SetInt ("Top7",top6);
			PlayerPrefs.SetInt ("Top8",top7);
			PlayerPrefs.SetInt ("Top9",top8);
			PlayerPrefs.SetInt ("Top10",top9);
		}else if(myscore>top5){

			PlayerPrefs.SetInt ("Top5",myscore);
			PlayerPrefs.SetInt ("Top6",top5);
			PlayerPrefs.SetInt ("Top7",top6);
			PlayerPrefs.SetInt ("Top8",top7);
			PlayerPrefs.SetInt ("Top9",top8);
			PlayerPrefs.SetInt ("Top10",top9);
		}else if(myscore>top6){
			
			PlayerPrefs.SetInt ("Top6",myscore);
			PlayerPrefs.SetInt ("Top7",top6);
			PlayerPrefs.SetInt ("Top8",top7);
			PlayerPrefs.SetInt ("Top9",top8);
			PlayerPrefs.SetInt ("Top10",top9);
		}else if(myscore>top7){

			PlayerPrefs.SetInt ("Top7",myscore);
			PlayerPrefs.SetInt ("Top8",top7);
			PlayerPrefs.SetInt ("Top9",top8);
			PlayerPrefs.SetInt ("Top10",top9);
		}else if(myscore>top8){
			PlayerPrefs.SetInt ("Top8",myscore);
			PlayerPrefs.SetInt ("Top9",top8);
			PlayerPrefs.SetInt ("Top10",top9);
		}else if(myscore>top9){

			PlayerPrefs.SetInt ("Top9",myscore);
			PlayerPrefs.SetInt ("Top10",top9);
		}else if(myscore>top10){

			PlayerPrefs.SetInt ("Top10",myscore);
		}

		
	}
	
	// Update is called once per frame
	void Update () {
		ScoreHold.text = "YOUR SCORE IS: " + myscore;
	
		
	}
}
