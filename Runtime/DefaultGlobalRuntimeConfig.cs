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
		private string androidTestDeviceConditionName = "IsAndroidTestDevice";
		[SerializeField] private string androidDevBannerAdsId;
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
		private string iosTestDeviceConditionName = "IsIosTestDevice";
		[SerializeField] private string iosDevBannerAdsId;
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

		[Header("Admob other")][SerializeField] private string editorTestDeviceConditionName = "IsEditorTestDevice";
		[SerializeField] private Vector2Int standardBannerSize = new Vector2Int(320, 50);
		[SerializeField] private float standardBannerThresholdScreenWidthInches = 2.05f;
		[SerializeField] private float rewardedAdLoadingTimeout = 3.0f;
		[SerializeField] private string sprintAdsRewardName;


		[Header("Sprint mode")][SerializeField] private int daySwitchHoursOffset = -3;
		[SerializeField] private int questionsPerSprint = 100;
		[SerializeField] private long sprintTimePerQuestionTicks = TimeSpan.TicksPerMinute;
		[SerializeField] private int sprintMistakesToFail = 3;
		[SerializeField] private int sprintTimeToViewCorrectAnswerMs = 500;

		[Header("Database")][SerializeField] private int maxQuestionsPerTest = 20;
		[SerializeField] private string fallbackLanguage = Constant.Ukrainian;

		[Header("Local notifications common")]
		[SerializeField]
		private int recommendedQuestionsPerDay = 60;
		[SerializeField] private int minHourForNotificationWeekDay = 9;
		[SerializeField] private int maxHourForNotificationWeekDay = 20;
		[SerializeField] private int minHourForNotificationWeekEnd = 11;
		[SerializeField] private int maxHourForNotificationWeekEnd = 21;
		[SerializeField] private int daySwitchHourOfD1Notifications = 3;

		[Header("Local notifications android")]
		[SerializeField]
		private string generalNotificationsChannelId = nameof(GeneralNotificationsChannelId);
		[SerializeField] private int androidD1ReminderNotificationId = 1;
		[SerializeField] private int androidD5ReminderNotificationId = 2;
		[SerializeField] private string androidD1NotificationLargeIcon = "app_icon";
		[SerializeField] private string androidAndroidD1NotificationSmallIcon = "app_icon";
		[SerializeField] private string androidAndroidD5NotificationLargeIcon = "app_icon";
		[SerializeField] private string androidAndroidD5NotificationSmallIcon = "app_icon";

		[Header("Local notifications iOS")]
		[SerializeField]
		private string iosD1ReminderNotificationId = "D1ReminderNotificationId";
		[SerializeField] private string iosD5ReminderNotificationId = "D5ReminderNotificationId";
		[SerializeField] private string iosDailyRemindersCategoryId = "DailyRemindersCategoryId";

		[Header("Database")][SerializeField] private string databaseAddress = "database";

		[Header("UI")][SerializeField] private string uiLearnedLabel = "ui/stat-learned";
		[SerializeField] private string uiTrainedLabel = "ui/stat-trained";
		[SerializeField] private string uiRegularRightLabel = "ui/stat-regular-right";
		[SerializeField] private string uiRegularWrongLabel = "ui/stat-regular-wrong";

		[Header("Misc")][SerializeField] private string defaultPrivacyPolicyRichTextAddress = "privacy_policy_uk.txt";


		public string AndroidTestDeviceConditionName => androidTestDeviceConditionName;

		public string AndroidDevBannerAdsId => androidDevBannerAdsId;

		public string AndroidDevInterstitialAdsId => androidDevInterstitialAdsId;

		public string AndroidDevRewardAdsId => androidDevRewardAdsId;

		public string AndroidProdBannerIdInsteadOfQuestionImage => androidProdBannerIdInsteadOfQuestionImage;

		public string AndroidProdBannerIdOnHelpScreen => androidProdBannerIdOnHelpScreen;

		public string AndroidProdBannerIdOnTestsPanel => androidProdBannerIdOnTestsPanel;

		public string AndroidProdInterstitialIdAfterSponsoredTest => androidProdInterstitialIdAfterSponsoredTest;

		public string AndroidProdInterstitialIdBeforeSponsoredTest => androidProdInterstitialIdBeforeSponsoredTest;

		public string AndroidProdRewardAdsIdContinueSprint => androidProdRewardAdsIdContinueSprint;

		public string IosTestDeviceConditionName => iosTestDeviceConditionName;

		public string IosDevBannerAdsId => iosDevBannerAdsId;

		public string IosDevInterstitialAdsId => iosDevInterstitialAdsId;

		public string IosDevRewardAdsId => iosDevRewardAdsId;

		public string IosProdBannerIdInsteadOfQuestionImage => iosProdBannerIdInsteadOfQuestionImage;

		public string IosProdBannerIdOnHelpScreen => iosProdBannerIdOnHelpScreen;

		public string IosProdBannerIdOnTestsPanel => iosProdBannerIdOnTestsPanel;

		public string IosProdInterstitialIdAfterSponsoredTest => iosProdInterstitialIdAfterSponsoredTest;

		public string IosProdInterstitialIdBeforeSponsoredTest => iosProdInterstitialIdBeforeSponsoredTest;

		public string IosProdRewardAdsIdContinueSprint => iosProdRewardAdsIdContinueSprint;

		public string EditorTestDeviceConditionName => editorTestDeviceConditionName;

		public Vector2Int StandardBannerSize => standardBannerSize;

		public float StandardBannerThresholdScreenWidthInches => standardBannerThresholdScreenWidthInches;

		public float RewardedAdLoadingTimeout => rewardedAdLoadingTimeout;

		public string SprintAdsRewardName => sprintAdsRewardName;

		public int DaySwitchHoursOffset => daySwitchHoursOffset;

		public int QuestionsPerSprint => questionsPerSprint;

		public long SprintTimePerQuestionTicks => sprintTimePerQuestionTicks;

		public int SprintMistakesToFail => sprintMistakesToFail;

		public int SprintTimeToViewCorrectAnswerMs => sprintTimeToViewCorrectAnswerMs;

		public int MaxQuestionsPerTest => maxQuestionsPerTest;

		public string FallbackLanguage => fallbackLanguage;

		public int RecommendedQuestionsPerDay => recommendedQuestionsPerDay;

		public int MinHourForNotificationWeekDay => minHourForNotificationWeekDay;

		public int MaxHourForNotificationWeekDay => maxHourForNotificationWeekDay;

		public int MinHourForNotificationWeekEnd => minHourForNotificationWeekEnd;

		public int MaxHourForNotificationWeekEnd => maxHourForNotificationWeekEnd;

		public int DaySwitchHourOfD1Notifications => daySwitchHourOfD1Notifications;

		public string GeneralNotificationsChannelId => generalNotificationsChannelId;

		public int AndroidD1ReminderNotificationId => androidD1ReminderNotificationId;

		public int AndroidD5ReminderNotificationId => androidD5ReminderNotificationId;

		public string AndroidD1NotificationLargeIcon => androidD1NotificationLargeIcon;

		public string AndroidD1NotificationSmallIcon => androidAndroidD1NotificationSmallIcon;

		public string AndroidD5NotificationLargeIcon => androidAndroidD5NotificationLargeIcon;

		public string AndroidD5NotificationSmallIcon => androidAndroidD5NotificationSmallIcon;

		public string IosD1ReminderNotificationId => iosD1ReminderNotificationId;

		public string IosD5ReminderNotificationId => iosD5ReminderNotificationId;

		public string IosDailyRemindersCategoryId => iosDailyRemindersCategoryId;

		public string DatabaseAddress => databaseAddress;

		public string UiLearnedLabel => uiLearnedLabel;

		public string UiTrainedLabel => uiTrainedLabel;

		public string UiRegularRightLabel => uiRegularRightLabel;

		public string UiRegularWrongLabel => uiRegularWrongLabel;

		public string DefaultPrivacyPolicyRichTextAddress => defaultPrivacyPolicyRichTextAddress;
	}
}
