using UnityEngine;

namespace Exam.Config
{
	[CreateAssetMenu(fileName = nameof(GlobalRuntimeConfig) + Grabli.Abstraction.Constant.FileExtension.Asset,
					 menuName = Constant.MenuPrefix + nameof(GlobalRuntimeConfig))]
	public class GlobalRuntimeConfig : ScriptableObject
	{
		[Header("Google Play Market")]
		[SerializeField]
		private string applicationBundleIdForGooglePlayMarket;

		[Header("Apple App Store")]
		[SerializeField]
		private string applicationBundleIdForAppleAppStore;
		[SerializeField] private string appleItunesAppId;

		[Header("Admob")][SerializeField] private string androidDevBannerAdsId;
		[SerializeField] private string androidDevInterstitialAdsId;
		[SerializeField] private string androidDevRewardAdsId;

		[SerializeField] private string androidProdBannerIdInsteadOfQuestionImage;
		[SerializeField] private string androidProdBannerIdOnHelpScreen;
		[SerializeField] private string androidProdBannerIdOnTestsPanel;
		[SerializeField] private string androidProdInterstitialIdAfterSponsoredTest;
		[SerializeField] private string androidProdInterstitialIdBeforeSponsoredTest;
		[SerializeField] private string androidProdRewardAdsIdContinueSprint;

		[SerializeField] private string iosDevBannerAdsId;

		[SerializeField] private string sprintAdsRewardName;
	}
}
