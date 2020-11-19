// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Structures.Generated.a7s {

	using AnnoSerializer.Serialization.Core;
	using AnnoSerializer.Structures.DataTypes;
	using System;

	public partial class FunFactSettings {

		[BinaryContent(Name = "PlayerCounter", NodeType = BinaryContentTypes.Node)]
		public PlayerCounter PlayerCounter { get; set; }

		[BinaryContent(Name = "ValueType", NodeType = BinaryContentTypes.Node)]
		public ValueType ValueType { get; set; }

		[BinaryContent(Name = "Scope", NodeType = BinaryContentTypes.Node)]
		public Scope Scope { get; set; }

		[BinaryContent(Name = "ScopeContext", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt ScopeContext { get; set; }

		[BinaryContent(Name = "Value", NodeType = BinaryContentTypes.Attribute)]
		public Int64 Value { get; set; }

		[BinaryContent(Name = "TextGUID", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt TextGUID { get; set; }

		[BinaryContent(Name = "CounterContext", NodeType = BinaryContentTypes.Attribute)]
		public DescriptionInt CounterContext { get; set; }

		[BinaryContent(Name = "FactNumber", NodeType = BinaryContentTypes.Attribute)]
		public Int32 FactNumber { get; set; }

	}
}
