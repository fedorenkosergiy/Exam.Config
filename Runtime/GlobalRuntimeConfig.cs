using UnityEngine;

namespace Exam.Config
{
	public interface GlobalRuntimeConfig
	{
		string AndroidTestDeviceConditionName { get; }

		string AndroidDevBannerAdsId { get; }

		string AndroidDevInterstitialAdsId { get; }

		string AndroidDevRewardAdsId { get; }

		string AndroidProdBannerIdInsteadOfQuestionImage { get; }

		string AndroidProdBannerIdOnHelpScreen { get; }

		string AndroidProdBannerIdOnTestsPanel { get; }

		string AndroidProdInterstitialIdAfterSponsoredTest { get; }

		string AndroidProdInterstitialIdBeforeSponsoredTest { get; }

		string AndroidProdRewardAdsIdContinueSprint { get; }

		string IosTestDeviceConditionName { get; }

		string IosDevBannerAdsId { get; }

		string IosDevInterstitialAdsId { get; }

		string IosDevRewardAdsId { get; }

		string IosProdBannerIdInsteadOfQuestionImage { get; }

		string IosProdBannerIdOnHelpScreen { get; }

		string IosProdBannerIdOnTestsPanel { get; }

		string IosProdInterstitialIdAfterSponsoredTest { get; }

		string IosProdInterstitialIdBeforeSponsoredTest { get; }

		string IosProdRewardAdsIdContinueSprint { get; }

		string EditorTestDeviceConditionName { get; }

		Vector2Int StandardBannerSize { get; }

		float StandardBannerThresholdScreenWidthInches { get; }

		float RewardedAdLoadingTimeout { get; }

		string SprintAdsRewardName { get; }

		int DaySwitchHoursOffset { get; }

		int QuestionsPerSprint { get; }

		long SprintTimePerQuestionTicks { get; }

		int SprintMistakesToFail { get; }

		int SprintTimeToViewCorrectAnswerMs { get; }

		int MaxQuestionsPerTest { get; }

		string FallbackLanguage { get; }

		int RecommendedQuestionsPerDay { get; }

		int MinHourForNotificationWeekDay { get; }

		int MaxHourForNotificationWeekDay { get; }

		int MinHourForNotificationWeekEnd { get; }

		int MaxHourForNotificationWeekEnd { get; }

		int DaySwitchHourOfD1Notifications { get; }

		string GeneralNotificationsChannelId { get; }

		int AndroidD1ReminderNotificationId { get; }

		int AndroidD5ReminderNotificationId { get; }

		string AndroidD1NotificationLargeIcon { get; }

		string AndroidD1NotificationSmallIcon { get; }

		string AndroidD5NotificationLargeIcon { get; }

		string AndroidD5NotificationSmallIcon { get; }

		string IosD1ReminderNotificationId { get; }

		string IosD5ReminderNotificationId { get; }

		string IosDailyRemindersCategoryId { get; }

		string DatabaseAddress { get; }

		string UiLearnedLabel { get; }

		string UiTrainedLabel { get; }

		string UiRegularRightLabel { get; }

		string UiRegularWrongLabel { get; }

		string DefaultPrivacyPolicyRichTextAddress { get; }
	}
}
