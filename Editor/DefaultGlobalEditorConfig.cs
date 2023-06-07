using UnityEngine;
using static Grabli.Abstraction.Constant;

namespace Exam.Config.Editor
{
	[CreateAssetMenu(fileName = nameof(DefaultGlobalEditorConfig) + FileExtension.Dot.Asset,
					 menuName = Constant.MenuPrefix + nameof(DefaultGlobalEditorConfig))]
	public class DefaultGlobalEditorConfig : ScriptableObject, GlobalEditorConfig
	{
		[SerializeField] private DefaultGlobalRuntimeConfig runtimeConfig;
		[SerializeField] private string databaseAssetGuid;
		[SerializeField] private string databaseDefaultAssetPath = "Assets/database" + FileExtension.Dot.Asset;

		public GlobalRuntimeConfig RuntimeConfig => runtimeConfig;

		public string DatabaseAssetGuid => databaseAssetGuid;

		public string DatabaseDefaultAssetPath => databaseDefaultAssetPath;
	}
}
