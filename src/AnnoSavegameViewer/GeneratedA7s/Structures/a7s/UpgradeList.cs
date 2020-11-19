// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
  using System.Collections.Generic;

  public partial class UpgradeList {

		[BinaryContent(Name = "UpgradeGUIDs", NodeType = BinaryContentTypes.Attribute)]
		public List<DescriptionInt> UpgradeGUIDs { get; set; }

		[BinaryContent(Name = "UpgradeSets", NodeType = BinaryContentTypes.Node)]
		public UpgradeSets UpgradeSets { get; set; }

	}
}
