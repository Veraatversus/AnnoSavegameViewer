namespace AnnoSerializer.Serialization.Core {
  using System;
  using System.Collections.Concurrent;
  using System.Linq;

  /// <summary> Represents utilities for working with <see cref="Enum"/> instances. </summary>
  public static class EnumTools {

    #region Public Methods

    /// <summary>
    /// Validates the given <paramref name="value"/> to be defined in the enum of the given type,
    /// allowing combined flags for enums decorated with the <see cref="FlagsAttribute"/>.
    /// </summary>
    /// <param name="enumType"> The type of the <see cref="Enum"/> to validate against. </param>
    /// <param name="value"> The value to validate. </param>
    /// <returns> <see langword="true"/> when the value is defined; otherwise, <see langword="false"/>. </returns>
    public static bool Validate(Type enumType, object value) {
      // Check if a simple value is defined in the enum.
      var valid = Enum.IsDefined(enumType, value);
      if (!valid) {
        // For enums decorated with the FlagsAttribute, allow sets of flags.
        if (!_flagEnums.TryGetValue(enumType, out var isFlag)) {
          isFlag = enumType.GetCustomAttributes(typeof(FlagsAttribute), false)?.Any() == true;
          _ = _flagEnums.TryAdd(enumType, isFlag);
        }
        if (isFlag) {
          long mask = 0;
          foreach (var definedValue in Enum.GetValues(enumType))
            mask |= Convert.ToInt64(definedValue);
          var longValue = Convert.ToInt64(value);
          valid = (mask & longValue) == longValue;
        }
      }
      return valid;
    }

    #endregion Public Methods

    #region Private Fields

    private static readonly ConcurrentDictionary<Type, bool> _flagEnums = new ConcurrentDictionary<Type, bool>();

    #endregion Private Fields
  }
}