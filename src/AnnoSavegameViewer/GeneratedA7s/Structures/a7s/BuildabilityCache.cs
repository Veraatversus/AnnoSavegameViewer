// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;

	public partial class BuildabilityCache {

		[BinaryContent(Name = "CachePerIsland", NodeType = BinaryContentTypes.Node)]
		public CachePerIsland CachePerIsland { get; set; }

		[BinaryContent(Name = "CachePerSession", NodeType = BinaryContentTypes.Node)]
		public CachePerSession CachePerSession { get; set; }

		[BinaryContent(Name = "RequestsWaitingForNewIsland", NodeType = BinaryContentTypes.Node)]
		public RequestsWaitingForNewIsland RequestsWaitingForNewIsland { get; set; }

		[BinaryContent(Name = "LastCacheClear", NodeType = BinaryContentTypes.Attribute)]
		public HexString LastCacheClear { get; set; }

	}
}
