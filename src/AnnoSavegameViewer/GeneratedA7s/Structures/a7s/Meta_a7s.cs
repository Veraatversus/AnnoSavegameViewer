// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using System;

	public partial class Meta_a7s {

		[BinaryContent(Name = "CorporationFileVersion", NodeType = BinaryContentTypes.Attribute)]
		public Int32 CorporationFileVersion { get; set; }

		[BinaryContent(Name = "CorporationVersionName", NodeType = BinaryContentTypes.Attribute, Encoding = "utf-16")]
		public String CorporationVersionName { get; set; }

		[BinaryContent(Name = "LastModTime", NodeType = BinaryContentTypes.Attribute)]
		public DateTime LastModTime { get; set; }

		[BinaryContent(Name = "CorporationSaveGameName", NodeType = BinaryContentTypes.Attribute, Encoding = "utf-16")]
		public String CorporationSaveGameName { get; set; }

	}
}
