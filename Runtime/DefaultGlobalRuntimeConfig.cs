using UnityEngine;
using System;

namespace Exam.Config
{
	[CreateAssetMenu(fileName = nameof(DefaultGlobalRuntimeConfig) + Grabli.Abstraction.Constant.FileExtension.Asset,
					 menuName = Constant.MenuPrefix + nameof(DefaultGlobalRuntimeConfig))]
	public class DefaultGlobalRuntimeConfig : ScriptableObject, GlobalRuntimeConfig
	{
		[Header("Google Play Market")]
		[SerializeField]
		private string applicationBundleIdForGooglePlayMarket;

		[Header("Apple App Store")]
		[SerializeField]
		private string applicationBundleIdForAppleAppStore;
		[SerializeField] private string appleItunesAppId;

		[Header("Admob android dev")]
		[SerializeField]
		private string androidDevBannerAdsId;
		[SerializeField] private string androidDevInterstitialAdsId;
		[SerializeField] private string androidDevRewardAdsId;

		[Header("Admob android prod")]
		[SerializeField]
		private string androidProdBannerIdInsteadOfQuestionImage;
		[SerializeField] private string androidProdBannerIdOnHelpScreen;
		[SerializeField] private string androidProdBannerIdOnTestsPanel;
		[SerializeField] private string androidProdInterstitialIdAfterSponsoredTest;
		[SerializeField] private string androidProdInterstitialIdBeforeSponsoredTest;
		[SerializeField] private string androidProdRewardAdsIdContinueSprint;

		[Header("Admob iOS dev")]
		[SerializeField]
		private string iosDevBannerAdsId;
		[SerializeField] private string iosDevInterstitialAdsId;
		[SerializeField] private string iosDevRewardAdsId;

		[Header("Admob iOS prod")]
		[SerializeField]
		private string iosProdBannerIdInsteadOfQuestionImage;
		[SerializeField] private string iosProdBannerIdOnHelpScreen;
		[SerializeField] private string iosProdBannerIdOnTestsPanel;
		[SerializeField] private string iosProdInterstitialIdAfterSponsoredTest;
		[SerializeField] private string iosProdInterstitialIdBeforeSponsoredTest;
		[SerializeField] private string iosProdRewardAdsIdContinueSprint;

		[Header("Admob other")][SerializeField] private string sprintAdsRewardName;

		[Header("Sprint mode")][SerializeField] private int daySwitchHoursOffset = -3;
		[SerializeField] private int questionsPerSprint = 100;
		[SerializeField] private long sprintTimePerQuestionTicks = TimeSpan.TicksPerMinute;
		[SerializeField] private int sprintMistakesToFail = 3;
		[SerializeField] private int sprintTimeToViewCorrectAnswerMs = 500;

		[Header("Database")][SerializeField] private int maxQuestionsPerTest = 20;
		[SerializeField] private string fallbackLanguage = Constant.Ukrainian;

		public string AndroidDevBannerAdsId => androidDevBannerAdsId;

		public string AndroidDevInterstitialAdsId => androidDevInterstitialAdsId;

		public string AndroidDevRewardAdsId => androidDevRewardAdsId;

		public string AndroidProdBannerIdInsteadOfQuestionImage => androidProdBannerIdInsteadOfQuestionImage;

		public string AndroidProdBannerIdOnHelpScreen => androidProdBannerIdOnHelpScreen;

		public string AndroidProdBannerIdOnTestsPanel => androidProdBannerIdOnTestsPanel;

		public string AndroidProdInterstitialIdAfterSponsoredTest => androidProdInterstitialIdAfterSponsoredTest;

		public string AndroidProdInterstitialIdBeforeSponsoredTest => androidProdInterstitialIdBeforeSponsoredTest;

		public string AndroidProdRewardAdsIdContinueSprint => androidProdRewardAdsIdContinueSprint;

		public string IosDevBannerAdsId => iosDevBannerAdsId;

		public string IosDevInterstitialAdsId => iosDevInterstitialAdsId;

		public string IosDevRewardAdsId => iosDevRewardAdsId;

		public string IosProdBannerIdInsteadOfQuestionImage => iosProdBannerIdInsteadOfQuestionImage;

		public string IosProdBannerIdOnHelpScreen => iosProdBannerIdOnHelpScreen;

		public string IosProdBannerIdOnTestsPanel => iosProdBannerIdOnTestsPanel;

		public string IosProdInterstitialIdAfterSponsoredTest => iosProdInterstitialIdAfterSponsoredTest;

		public string IosProdInterstitialIdBeforeSponsoredTest => iosProdInterstitialIdBeforeSponsoredTest;

		public string IosProdRewardAdsIdContinueSprint => iosProdRewardAdsIdContinueSprint;

		public string SprintAdsRewardName => sprintAdsRewardName;

		public int DaySwitchHoursOffset => daySwitchHoursOffset;

		public int QuestionsPerSprint => questionsPerSprint;

		public long SprintTimePerQuestionTicks => sprintTimePerQuestionTicks;

		public int SprintMistakesToFail => sprintMistakesToFail;

		public int SprintTimeToViewCorrectAnswerMs => sprintTimeToViewCorrectAnswerMs;

		public int MaxQuestionsPerTest => maxQuestionsPerTest;

		public string FallbackLanguage => fallbackLanguage;
	}
}
