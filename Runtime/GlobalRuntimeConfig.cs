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
	}
}
