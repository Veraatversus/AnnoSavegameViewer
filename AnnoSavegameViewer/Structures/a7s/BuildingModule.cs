namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class BuildingModule {

		[BinaryContent(Name = "ParentFactoryID", NodeType = BinaryContentTypes.Attribute)]
		public Int64 ParentFactoryID { get; set; }

		[BinaryContent(Name = "CultureSlotIndex", NodeType = BinaryContentTypes.Attribute)]
		public Int32 CultureSlotIndex { get; set; }

	}
}
