// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class HarborsValue {

		[BinaryContent(Name = "OwnerID", NodeType = BinaryContentTypes.Node)]
		public NoneOwnerID OwnerID { get; set; }

		[BinaryContent(Name = "HaborID", NodeType = BinaryContentTypes.Attribute)]
		public Int64 HaborID { get; set; }

		[BinaryContent(Name = "HaborType", NodeType = BinaryContentTypes.Node)]
		public HaborType HaborType { get; set; }

		[BinaryContent(Name = "LoadingPierMidPoint", NodeType = BinaryContentTypes.Attribute)]
		public Point2D<Single> LoadingPierMidPoint { get; set; }

		[BinaryContent(Name = "AwayFromCoast", NodeType = BinaryContentTypes.Attribute)]
		public Point2D<Single> AwayFromCoast { get; set; }

		[BinaryContent(Name = "LoadingPiers", NodeType = BinaryContentTypes.Node)]
		public LoadingPiers LoadingPiers { get; set; }

		[BinaryContent(Name = "WaitingQueueMap", NodeType = BinaryContentTypes.Node)]
		public WaitingQueueMap WaitingQueueMap { get; set; }

	}
}
