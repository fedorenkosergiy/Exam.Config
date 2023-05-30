using UnityEditor;
using System;
using JetBrains.Annotations;

namespace Exam.Config.Editor
{
	[PublicAPI]
	public static class Api
	{
		private static GlobalEditorConfig instance;

		private static GlobalEditorConfig GetInstance()
		{
			if (instance != null) { return instance; }

			string[] guids = AssetDatabase.FindAssets("t:" + nameof(DefaultGlobalEditorConfig));

			if (guids.Length == 0) { return null; }

			if (guids.Length != 1)
			{
				throw new InvalidOperationException("Found more than one asset of type " +
													nameof(DefaultGlobalEditorConfig));
			}

			string path = AssetDatabase.GUIDToAssetPath(guids[0]);
			instance = AssetDatabase.LoadAssetAtPath<DefaultGlobalEditorConfig>(path);

			return instance;
		}

		public static GlobalEditorConfig EditorConfig => GetInstance();

		public static GlobalRuntimeConfig RuntimeConfig => EditorConfig.RuntimeConfig;
	}
}
