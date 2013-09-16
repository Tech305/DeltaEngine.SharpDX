﻿using System;
using System.Collections.Generic;
using DeltaEngine.Extensions;

namespace DeltaEngine.Content
{
	/// <summary>
	/// Content files get this meta data enties generated by the ContentService or DiskContentLoader.
	/// </summary>
	public sealed class ContentMetaData
	{
		public string Name { get; internal set; }
		public ContentType Type { get; internal set; }
		public DateTime LastTimeUpdated { get; internal set; }
		public string Language { get; internal set; }
		public string LocalFilePath { get; internal set; }
		public int PlatformFileId { get; internal set; }
		public int FileSize { get; internal set; }

		public T Get<T>(string attributeName, T defaultValue)
		{
			return Values.ContainsKey(attributeName) ? Values[attributeName].Convert<T>() : defaultValue;
		}

		public readonly Dictionary<string, string> Values = new Dictionary<string, string>();
	}
}