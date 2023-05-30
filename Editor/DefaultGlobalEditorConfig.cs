using UnityEngine;

namespace Exam.Config.Editor
{
	[CreateAssetMenu(fileName = nameof(DefaultGlobalEditorConfig) + Grabli.Abstraction.Constant.FileExtension.Asset,
					 menuName = Constant.MenuPrefix + nameof(DefaultGlobalEditorConfig))]
	public class DefaultGlobalEditorConfig : ScriptableObject, GlobalEditorConfig
	{
		[SerializeField] private DefaultGlobalRuntimeConfig runtimeConfig;

		public GlobalRuntimeConfig RuntimeConfig => runtimeConfig;
	}
}
