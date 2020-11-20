// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class SignsAndFeedbackSettings {

		[BinaryContent(Name = "MinimapToken", NodeType = BinaryContentTypes.Attribute)]
		public HexString MinimapToken { get; set; }

		[BinaryContent(Name = "Infolayer", NodeType = BinaryContentTypes.Attribute)]
		public HexString Infolayer { get; set; }

		[BinaryContent(Name = "HideOnMinimap", NodeType = BinaryContentTypes.Attribute)]
		public HexString HideOnMinimap { get; set; }

		[BinaryContent(Name = "UseQuestOutlines", NodeType = BinaryContentTypes.Attribute)]
		public HexString UseQuestOutlines { get; set; }

	}
}
