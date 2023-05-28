using System;

namespace Exam.Config
{
	public static class GlobalRuntimeConfigExtension
	{
		[JetBrains.Annotations.PureAttribute][System.Diagnostics.Contracts.PureAttribute]
		public static TimeSpan GetSprintTimePerQuestion(this GlobalRuntimeConfig config)
		{
			return TimeSpan.FromTicks(config.SprintTimePerQuestionTicks);
		}
	}
}
