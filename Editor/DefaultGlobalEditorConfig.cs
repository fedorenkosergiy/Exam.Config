using UnityEngine;
using static Grabli.Abstraction.Constant;

namespace Exam.Config.Editor
{
	[CreateAssetMenu(fileName = nameof(DefaultGlobalEditorConfig) + FileExtension.Asset,
		menuName = Constant.MenuPrefix + nameof(DefaultGlobalEditorConfig))]
	public class DefaultGlobalEditorConfig : ScriptableObject, GlobalEditorConfig
	{
		[SerializeField] private DefaultGlobalRuntimeConfig runtimeConfig;
		[SerializeField] private string databaseAssetGuid;
		[SerializeField] private string databaseDefaultAssetPath = "Assets/database" + FileExtension.Dot.Asset;
		[SerializeField] private string rawDatabaseAssetGuid;
		[SerializeField] private string rawDatabaseDefaultAssetPath = "Assets/database" + FileExtension.Dot.Db;

		public GlobalRuntimeConfig RuntimeConfig => runtimeConfig;

		public string DatabaseAssetGuid => databaseAssetGuid;

		public string DatabaseDefaultAssetPath => databaseDefaultAssetPath;
		
		public string RawDatabaseAssetGuid => rawDatabaseAssetGuid;

		public string RawDatabaseDefaultAssetPath => rawDatabaseDefaultAssetPath;
	}
}