namespace AnnoSerializer.Serialization {
  using AnnoSerializer.Serialization.Memory;
  using AnnoSerializer.Serialization.Reflection.TypeData;
  using AnnoSerializer.Structures.RDA;
  using System;
  using System.Linq;

  public static class RDASerializer {

		#region Public Methods

		public static T Convert<T>(this Rda rda) => (T)(Convert(rda, typeof(T), out var _));

		public static object Convert(Rda rda, Type outputType, out int usedBytes) {
			usedBytes = 0;
			var typeData = TypeData.GetTypeData(outputType);
			var instance = typeData.GetInstance();
			//Find matching member
			foreach (var member in typeData.UnorderedNodes.Where(att => att.Value.Attribute.RdaBlock is >= 0)) {
				if (rda.Blocks.Count > member.Value.Attribute.RdaBlock) {
					var block = rda.Blocks[member.Value.Attribute.RdaBlock];
					var blockTypeData = TypeData.GetTypeData(member.Value.Type);
					var blockInstance = blockTypeData.GetInstance();
					member.Value.MemberInfo.SetMemberValue(instance, blockInstance);

					foreach (var blockType in blockTypeData.UnorderedNodes.Where(att => !string.IsNullOrWhiteSpace(att.Value.Attribute.RdaFile))) {
						if (block.Files.Find(f => f.FileHeader.FilePath == blockType.Value.Attribute.RdaFile) is RdaFile file) {
							var value = file.FileData.ReadObject(out var usedB, blockType.Value.Type, blockType.Value.Attribute);
							usedBytes += usedB;

							// Set Value.
							blockType.Value.MemberInfo.SetMemberValue(blockInstance, value);
						}
					}
				}
			}
			return instance;
		}

		#endregion Public Methods
	}
}