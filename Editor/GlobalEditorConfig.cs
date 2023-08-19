namespace Exam.Config.Editor
{
	public interface GlobalEditorConfig
	{
		GlobalRuntimeConfig RuntimeConfig { get; }

		string DatabaseAssetGuid { get; }

		string DatabaseDefaultAssetPath { get; }
		
		string RawDatabaseAssetGuid { get; }
		
		string RawDatabaseDefaultAssetPath { get; }
	}
}
