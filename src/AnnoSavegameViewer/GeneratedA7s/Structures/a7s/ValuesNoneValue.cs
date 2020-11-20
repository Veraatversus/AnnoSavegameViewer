// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class ValuesNoneValue {

		[BinaryContent(Name = "TextGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString TextGUID { get; set; }

		[BinaryContent(Name = "IconGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString IconGUID { get; set; }

		[BinaryContent(Name = "Infotip", NodeType = BinaryContentTypes.Attribute)]
		public HexString Infotip { get; set; }

		[BinaryContent(Name = "Category", NodeType = BinaryContentTypes.Node)]
		public NoneCategory Category { get; set; }

		[BinaryContent(Name = "hasInteraction", NodeType = BinaryContentTypes.Attribute)]
		public HexString HasInteraction { get; set; }

		[BinaryContent(Name = "Interaction", NodeType = BinaryContentTypes.Node)]
		public NoneInteraction Interaction { get; set; }

		[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ID { get; set; }

		[BinaryContent(Name = "StringReplacements", NodeType = BinaryContentTypes.Node)]
		public NoneStringReplacements StringReplacements { get; set; }

		[BinaryContent(Name = "SoundGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SoundGUID { get; set; }

		[BinaryContent(Name = "MinDisplayTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString MinDisplayTime { get; set; }

		[BinaryContent(Name = "DisplayTimeout", NodeType = BinaryContentTypes.Attribute)]
		public HexString DisplayTimeout { get; set; }

		[BinaryContent(Name = "TextInfo", NodeType = BinaryContentTypes.Node)]
		public NoneTextInfo TextInfo { get; set; }

		[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
		public HexString AreaID { get; set; }

		[BinaryContent(Name = "FilterType", NodeType = BinaryContentTypes.Node)]
		public NoneFilterType FilterType { get; set; }

		[BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Attribute)]
		public HexString Priority { get; set; }

		[BinaryContent(Name = "Group", NodeType = BinaryContentTypes.Node)]
		public NoneGroup Group { get; set; }

		[BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
		public ValuesNoneTargetPeer TargetPeer { get; set; }

		[BinaryContent(Name = "RestrictedToSessionOrRegions", NodeType = BinaryContentTypes.Attribute)]
		public HexString RestrictedToSessionOrRegions { get; set; }

		[BinaryContent(Name = "EnqueueTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString EnqueueTime { get; set; }

		[BinaryContent(Name = "StartTime", NodeType = BinaryContentTypes.Node)]
		public NoneStartTime StartTime { get; set; }

		[BinaryContent(Name = "EndTime", NodeType = BinaryContentTypes.Node)]
		public NoneEndTime EndTime { get; set; }

		[BinaryContent(Name = "TimeInPause", NodeType = BinaryContentTypes.Attribute)]
		public HexString TimeInPause { get; set; }

		[BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
		public HexString ObjectID { get; set; }

		[BinaryContent(Name = "JumpLocation", NodeType = BinaryContentTypes.Attribute)]
		public HexString JumpLocation { get; set; }

		[BinaryContent(Name = "TitleGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString TitleGUID { get; set; }

		[BinaryContent(Name = "SubtitleGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SubtitleGUID { get; set; }

		[BinaryContent(Name = "BlockingTime", NodeType = BinaryContentTypes.Attribute)]
		public HexString BlockingTime { get; set; }

		[BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString SessionGUID { get; set; }

		[BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
		public HexString Position { get; set; }

		[BinaryContent(Name = "PositionSessionGUID", NodeType = BinaryContentTypes.Attribute)]
		public HexString PositionSessionGUID { get; set; }

		[BinaryContent(Name = "IsWarning", NodeType = BinaryContentTypes.Attribute)]
		public HexString IsWarning { get; set; }

	}
}
