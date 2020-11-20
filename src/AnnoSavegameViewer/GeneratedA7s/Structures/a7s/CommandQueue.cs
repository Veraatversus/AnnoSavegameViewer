// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class CommandQueue {

		[BinaryContent(Name = "ExecuteCurrentCommand", NodeType = BinaryContentTypes.Attribute)]
		public HexString ExecuteCurrentCommand { get; set; }

		[BinaryContent(Name = "Commands", NodeType = BinaryContentTypes.Node)]
		public Commands Commands { get; set; }

		[BinaryContent(Name = "BasePosition", NodeType = BinaryContentTypes.Attribute)]
		public HexString BasePosition { get; set; }

		[BinaryContent(Name = "BaseRotation", NodeType = BinaryContentTypes.Attribute)]
		public HexString BaseRotation { get; set; }

		[BinaryContent(Name = "SpecialAssignment", NodeType = BinaryContentTypes.Node)]
		public SpecialAssignment SpecialAssignment { get; set; }

		[BinaryContent(Name = "StateMain", NodeType = BinaryContentTypes.Attribute)]
		public HexString StateMain { get; set; }

		[BinaryContent(Name = "StateSub", NodeType = BinaryContentTypes.Attribute)]
		public HexString StateSub { get; set; }

		[BinaryContent(Name = "StateParams", NodeType = BinaryContentTypes.Node)]
		public StateParams StateParams { get; set; }

		[BinaryContent(Name = "Stance", NodeType = BinaryContentTypes.Attribute)]
		public HexString Stance { get; set; }

	}
}
