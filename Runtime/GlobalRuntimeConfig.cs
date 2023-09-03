namespace Exam.Config
{
	public interface GlobalRuntimeConfig
	{
		string AndroidDevBannerAdsId { get; }

		string AndroidDevInterstitialAdsId { get; }

		string AndroidDevRewardAdsId { get; }

		string AndroidProdBannerIdInsteadOfQuestionImage { get; }

		string AndroidProdBannerIdOnHelpScreen { get; }

		string AndroidProdBannerIdOnTestsPanel { get; }

		string AndroidProdInterstitialIdAfterSponsoredTest { get; }

		string AndroidProdInterstitialIdBeforeSponsoredTest { get; }

		string AndroidProdRewardAdsIdContinueSprint { get; }

		string IosDevBannerAdsId { get; }

		string IosDevInterstitialAdsId { get; }

		string IosDevRewardAdsId { get; }

		string IosProdBannerIdInsteadOfQuestionImage { get; }

		string IosProdBannerIdOnHelpScreen { get; }

		string IosProdBannerIdOnTestsPanel { get; }

		string IosProdInterstitialIdAfterSponsoredTest { get; }

		string IosProdInterstitialIdBeforeSponsoredTest { get; }

		string IosProdRewardAdsIdContinueSprint { get; }

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

		int D1ReminderNotificationId { get; }

		int D5ReminderNotificationId { get; }

		string D1NotificationLargeIcon { get; }

		string D1NotificationSmallIcon { get; }

		string D5NotificationLargeIcon { get; }

		string D5NotificationSmallIcon { get; }

		string DatabaseAddress { get; }

		string UiLearnedLabel { get; }

		string UiTrainedLabel { get; }

		string UiRegularRightLabel { get; }

		string UiRegularWrongLabel { get; }

		string DefaultPrivacyPolicyRichTextAddress { get; }
	}
}
