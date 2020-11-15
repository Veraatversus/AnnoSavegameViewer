namespace AnnoSerializer.Serialization {
  using AnnoSerializer.Serialization;
  using AnnoSerializer.Serialization.Memory;
  using AnnoSerializer.Structures.A7S;
  using System;
  using System.Threading.Tasks;

  public static class AnnoFileSerializer {

		#region Public Methods
		public static T Convert<T>(this ReadOnlyMemory<byte> source) => (T)(Convert(source, typeof(T)));

    public static object Convert(this ReadOnlyMemory<byte> source, System.Type outputType) => source.ReadObject(out var _, outputType);

    public static Task<T> ReadFileAsync<T>(string path) {
			return Task.Run<T>(async () => {
				if (System.IO.File.Exists(path)) {
					var bytes = await System.IO.File.ReadAllBytesAsync(path);
					return (T)((ReadOnlyMemory<byte>)bytes).Convert(typeof(T));
				}
				return default;
			});
		}
	}

	#endregion Public Methods
}