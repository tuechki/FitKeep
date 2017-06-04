using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour
{

	public int coins;

	void Start() {

		coins = PlayerPrefs.GetInt ("coins", 0);
	}

	public void ShowRewardedAd()
	{
		if (Advertisement.IsReady("rewardedVideo"))
		{
			var options = new ShowOptions { resultCallback = HandleShowResult };
			Advertisement.Show("rewardedVideo", options);
		}
	}

	private void HandleShowResult(ShowResult result)
	{
		switch (result)
		{
		case ShowResult.Finished:
			Debug.Log ("The ad was successfully shown.");

			coins += 10;
			if (coins > 999)
				coins = 999;

			PlayerPrefs.SetInt ("coins", coins);
			PlayerPrefs.Save ();
			Application.LoadLevel (5);
			break;
		case ShowResult.Skipped:
			Debug.Log("The ad was skipped before reaching the end.");
			break;
		case ShowResult.Failed:
			Debug.LogError("The ad failed to be shown.");
			break;
		}
	}
}