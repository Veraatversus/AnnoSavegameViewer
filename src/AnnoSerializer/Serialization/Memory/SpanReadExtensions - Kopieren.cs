using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.RDA;
using System;
using System.Buffers.Binary;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace AnnoSavegameViewer.Serialization.Memory {

  public static class SpanReadExtensions {

    #region Public Methods

    /// <summary>
    /// Reads a <see cref="Boolean"/> value from the given offset and by the given pattern.
    /// </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Boolean ReadBoolean(this in ReadOnlySpan<byte> span, int offset = 0, BoolPattern pattern = default) {
      span.ReadBoolean(out var result, out var _, offset, pattern);
      return result;
    }

    /// <summary>
    /// Reads a <see cref="Boolean"/> value from the given offset and by the given pattern.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadBoolean(this in ReadOnlySpan<byte> span, out bool result, out int usedBytes, int offset = 0, BoolPattern pattern = default) {
      (result, usedBytes) = pattern switch {
				BoolPattern.Byte => (span[offset] != 0, 1),
				BoolPattern.Word => (MemoryMarshal.Read<UInt16>(span[offset..]) != 0, 2),
				BoolPattern.Dword => (MemoryMarshal.Read<UInt32>(span[offset..]) != 0, 4),
				_ => throw new NotImplementedException()
			};
    }

    /// <summary> Reads the given number of <see cref="Byte"/> values from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Byte[] ReadBytes(this in ReadOnlySpan<byte> span, int count, int offset = 0, Endian endian = Endian.System) {
      if (!endian.IsSystem()) {
        return span.Slice(offset, count).ToArray().Reverse().ToArray();
      }
      else {
        return span.Slice(offset, count).ToArray();
      }
    }

    /// <summary> Reads a <see cref="Byte"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Byte ReadByte(this in ReadOnlySpan<byte> span, int offset = 0) {
      span.ReadByte(out var result, offset);
      return result;
    }

    /// <summary> Reads a <see cref="Byte"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    public static void ReadByte(this in ReadOnlySpan<byte> span, out Byte result, int offset = 0) => result = span[offset];

    /// <summary> Reads a <see cref="DateTime/> value from the given offset by the given pattern.
    /// </summary> <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DateTime ReadDateTime(this in ReadOnlySpan<byte> span, int offset = 0, DateTimePattern pattern = default, Endian endian = Endian.System) {
      span.ReadDateTime(out var result, offset, pattern, endian);
      return result;
    }

    /// <summary> Reads a <see cref="DateTime/> value from the given offset by the given pattern.
    /// </summary> <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadDateTime(this in ReadOnlySpan<byte> span, out DateTime result, int offset = 0, DateTimePattern pattern = default, Endian endian = Endian.System) {
      result = pattern switch {
				DateTimePattern.NetTicks => new DateTime(span.ReadInt64(offset, endian)),
				DateTimePattern.CTime => CTimeTools.GetDateTime(span.ReadUInt32(offset, endian)),
				DateTimePattern.CTime64 => CTimeTools.GetDateTime(span.ReadUInt64(offset, endian)),
				_ => throw new NotImplementedException()
			};
    }

    /// <summary> Reads a <see cref="TimeSpan/> value from the given offset by the given pattern.
    /// </summary> <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TimeSpan ReadTimeSpan(this in ReadOnlySpan<byte> span, int offset = 0, TimeSpanPattern pattern = default, Endian endian = Endian.System) {
      span.ReadTimeSpan(out var result, offset, pattern, endian);
      return result;
    }

    /// <summary> Reads a <see cref="TimeSpan/> value from the given offset by the given pattern.
    /// </summary> <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadTimeSpan(this in ReadOnlySpan<byte> span, out TimeSpan result, int offset = 0, TimeSpanPattern pattern = default, Endian endian = Endian.System) {
      result = pattern switch {
				TimeSpanPattern.MilliSeconds => TimeSpan.FromMilliseconds(span.ReadInt64(offset, endian)),
				TimeSpanPattern.Seconds => TimeSpan.FromSeconds(span.ReadInt64(offset, endian)),
				TimeSpanPattern.Minutes => TimeSpan.FromMinutes(span.ReadInt64(offset, endian)),
				TimeSpanPattern.Hours => TimeSpan.FromHours(span.ReadInt64(offset, endian)),
				TimeSpanPattern.Days => TimeSpan.FromDays(span.ReadInt64(offset, endian)),
				TimeSpanPattern.Ticks => TimeSpan.FromTicks(span.ReadInt64(offset, endian)),
				_ => throw new NotImplementedException(),
			};
    }

    /// <summary> Reads a <see cref="Decimal"/> value from the given offset. </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Decimal ReadDecimal(this in ReadOnlySpan<byte> span, int offset = 0) {
      span.ReadDecimal(out var result, offset);
      return result;
    }

    /// <summary> Reads a <see cref="Decimal"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadDecimal(this in ReadOnlySpan<byte> span, out Decimal result, int offset = 0) {
      result = MemoryMarshal.Read<Decimal>(span[offset..]);
    }

    /// <summary> Reads a <see cref="Double"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Double ReadDouble(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) {
      span.ReadDouble(out var result, offset, endian);
      return result;
    }

    /// <summary> Reads a <see cref="Double"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadDouble(this in ReadOnlySpan<byte> span, out Double result, int offset = 0, Endian endian = Endian.System) {
      span.ReadInt64(out var raw, offset, endian);
      result = BitConverter.Int64BitsToDouble(raw);
    }

    /// <summary>
    /// Reads an <see cref="Enum"/> value from the given offset, using the size of the underlying type.
    /// </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T ReadEnum<T>(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) where T : struct, Enum {
      span.ReadEnum(out T result, out var _, offset, endian);
      return result;
    }

    /// <summary>
    /// Reads an <see cref="Enum"/> value from the given offset, using the size of the underlying type.
    /// </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadEnum<T>(this in ReadOnlySpan<byte> span, out T result, out int usedBytes, int offset = 0, Endian endian = Endian.System) where T : struct, Enum {
      usedBytes = Unsafe.SizeOf<T>();
      Span<byte> raw = stackalloc byte[usedBytes];
      span.Slice(offset, usedBytes).CopyTo(raw);
      if (!endian.IsSystem())
        raw.Reverse();
      result = MemoryMarshal.Read<T>(raw);
    }

    public static object ReadEnum(this in ReadOnlySpan<byte> span, Type enumType, bool strict, int offset = 0, Endian endian = Endian.System) {
      var valueType = Enum.GetUnderlyingType(enumType);
      object value;

      if (valueType == typeof(Byte))
        value = span.ReadByte(offset);
      else if (valueType == typeof(SByte))
        value = span.ReadSByte(offset);
      else if (valueType == typeof(Int16))
        value = span.ReadInt16(offset, endian);
      else if (valueType == typeof(Int32))
        value = span.ReadInt32(offset, endian);
      else if (valueType == typeof(Int64))
        value = span.ReadInt64(offset, endian);
      else if (valueType == typeof(UInt16))
        value = span.ReadUInt16(offset, endian);
      else if (valueType == typeof(UInt32))
        value = span.ReadUInt32(offset, endian);
      else if (valueType == typeof(UInt64))
        value = span.ReadUInt64(offset, endian);
      else
        throw new NotImplementedException($"Unsupported enum type {valueType}.");

      // Check if the value is defined in the enumeration, if requested.
      if (strict)
        EnumTools.Validate(enumType, value);
      return value;
    }

    /// <summary>
    /// Reads an <see cref="Enum"/> value from the given offset, using the size of the underlying
    /// type. The value is validated, throwing an exception if it is not defined in the enum.
    /// </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentException"> The value is not defined in the enum. </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T ReadEnumSafe<T>(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) where T : struct, Enum {
      span.ReadEnumSafe(out T result, out var _, offset, endian);
      return result;
    }

    /// <summary>
    /// Reads an <see cref="Enum"/> value from the given offset, using the size of the underlying
    /// type. The value is validated, throwing an exception if it is not defined in the enum.
    /// </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentException"> The value is not defined in the enum. </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadEnumSafe<T>(this in ReadOnlySpan<byte> span, out T result, out int usedBytes, int offset = 0, Endian endian = Endian.System) where T : struct, Enum {
      usedBytes = Unsafe.SizeOf<T>();
      result = span.ReadEnum<T>(offset, endian);
      if (!EnumTools.Validate(typeof(T), result))
        throw new ArgumentException($"Value {result} is not valid for enum {typeof(T)}.");
    }

    /// <summary> Reads an <see cref="Int16"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Int16 ReadInt16(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) {
      span.ReadInt16(out var result, offset, endian);
      return result;
    }

    /// <summary> Reads an <see cref="Int16"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadInt16(this in ReadOnlySpan<byte> span, out Int16 result, int offset = 0, Endian endian = Endian.System) {
      result = !endian.IsSystem()
          ? BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<Int16>(span[offset..]))
          : MemoryMarshal.Read<Int16>(span[offset..]);
    }

    /// <summary> Reads an <see cref="Int32"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Int32 ReadInt32(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) {
      span.ReadInt32(out var result, offset, endian);
      return result;
    }

    /// <summary> Reads an <see cref="Int32"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadInt32(this in ReadOnlySpan<byte> span, out Int32 result, int offset = 0, Endian endian = Endian.System) {
      result = !endian.IsSystem()
          ? BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<Int32>(span[offset..]))
          : MemoryMarshal.Read<Int32>(span[offset..]);
    }

    /// <summary>
    /// Reads an <see cref="Int32"/> value from the given offset. The value is stored in 1 to 5
    /// bytes, only using another byte if it does not fit into 7 more bits of the current one.
    /// </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentException"> The data available is not a 7-bit encoded integer. </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Int32 ReadInt32Bit7(this in ReadOnlySpan<byte> span, int offset = 0) {
      span.ReadInt32Bit7(out var result, out var usedBytes, offset);
      return result;
    }

    /// <summary>
    /// Reads an <see cref="Int32"/> value from the given offset. The value is stored in 1 to 5
    /// bytes, only using another byte if it does not fit into 7 more bits of the current one.
    /// </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentException"> The data available is not a 7-bit encoded integer. </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadInt32Bit7(this in ReadOnlySpan<byte> span, out Int32 result, out int usedBytes, int offset = 0) {
      // Endianness does not matter, as this value is stored byte by byte. While the highest bit is
      // set, the integer requires another of a maximum of 5 bytes.
      result = 0;
      var tempOffset = offset;
      for (var i = 0; i < sizeof(Int32) + 1; i++) {
        var readByte = span[tempOffset++];
        result |= (readByte & 0b01111111) << (i * 7);
        if ((readByte & 0b10000000) == 0) {
          usedBytes = i + 1;
          return;
        }
      }
      throw new ArgumentException("Invalid 7-bit encoded Int32.");
    }

    /// <summary> Reads an <see cref="Int64"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Int64 ReadInt64(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) {
      span.ReadInt64(out var result, offset, endian);
      return result;
    }

    /// <summary> Reads an <see cref="Int64"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadInt64(this in ReadOnlySpan<byte> span, out Int64 result, int offset = 0, Endian endian = Endian.System) {
      try {
        result = !endian.IsSystem()
   ? BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<Int64>(span[offset..]))
   : MemoryMarshal.Read<Int64>(span[offset..]);
      }
      catch (Exception) {
        throw;
      }
    }

    /// <summary> Reads an <see cref="SByte"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static SByte ReadSByte(this in ReadOnlySpan<byte> span, int offset = 0) => (SByte)span[offset];

    /// <summary> Reads an <see cref="SByte"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadSByte(this in ReadOnlySpan<byte> span, out SByte result, int offset = 0) => result = (SByte)span[offset];

    /// <summary> Reads an <see cref="Single"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Single ReadSingle(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) {
      span.ReadSingle(out var result, offset, endian);
      return result;
    }

    /// <summary> Reads an <see cref="Single"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadSingle(this in ReadOnlySpan<byte> span, out Single result, int offset = 0, Endian endian = Endian.System) {
      span.ReadInt32(out var value, offset, endian);
      result = BitConverter.Int32BitsToSingle(value);
    }

    /// <summary>
    /// Reads a <see cref="String"/> value from the given offset and by the given pattern and the
    /// given length.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static String ReadString(this in ReadOnlySpan<byte> span, int offset = 0, int length = 0, Encoding encoding = null, StringPattern stringPattern = StringPattern.VariableByteCount) {
      span.ReadString(out var value, out var _, offset, length, encoding, stringPattern);
      return value;
    }

    /// <summary>
    /// Reads a <see cref="String"/> value from the given offset and by the given pattern and the
    /// given length.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadString(this in ReadOnlySpan<byte> span, out String result, out int usedBytes, int offset = 0, int length = 0, Encoding encoding = null, StringPattern stringPattern = StringPattern.VariableByteCount) {
      var _encoding = encoding ?? Encoding.UTF8;

      if (stringPattern == StringPattern.FixByteCount) {
        result = _encoding.GetString(span.Slice(offset, length));
        usedBytes = length;
        //result = result.TrimEnd('\0');
      }
      else if (stringPattern == StringPattern.ZeroTerminated) {
        var byteLength = 0;
        var terminatorSize = _encoding.GetByteCount("A");
        for (byte lastByte = 1; lastByte != 0; byteLength += terminatorSize) {
          for (var i = 0; i < terminatorSize; i++) {
            lastByte = span[offset + byteLength + i];
            if (lastByte != 0)
              break;
          }
        }
        result = _encoding.GetString(span.Slice(offset, byteLength - terminatorSize));
        usedBytes = byteLength;
      }
      else {
        (int charLenght, int lenghtIndikatorSize) stringData = (length, 0);

        switch (stringPattern) {
          case StringPattern.VariableByteCount:
            span.ReadInt32Bit7(out var charLenghtInt32Bit7, out var usedIndicatorBytes, offset);
            stringData = (charLenghtInt32Bit7, usedIndicatorBytes);
            break;

          case StringPattern.ByteCharCount:
            span.ReadByte(out var charLenghtByte, offset);
            stringData = (charLenghtByte, 1);
            break;

          case StringPattern.Int16CharCount:
            span.ReadInt16(out var charLenghtInt16, offset);
            stringData = (charLenghtInt16, 2);
            break;

          case StringPattern.Int32CharCount:
            span.ReadInt32(out var charLenghtInt32, offset);
            stringData = (charLenghtInt32, 4);
            break;
        }

        span.DecodeString(out var tempResult, out var usedStringBytes, stringData.charLenght, _encoding, offset + stringData.lenghtIndikatorSize);
        result = tempResult;
        usedBytes = usedStringBytes + stringData.lenghtIndikatorSize;
      }
    }

    /// <summary> Reads a <see cref="UInt16"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static UInt16 ReadUInt16(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) {
      span.ReadUInt16(out var result, offset, endian);
      return result;
    }

    /// <summary> Reads a <see cref="UInt16"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadUInt16(this in ReadOnlySpan<byte> span, out UInt16 result, int offset = 0, Endian endian = Endian.System) {
      result = !endian.IsSystem()
          ? BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<UInt16>(span[offset..]))
          : MemoryMarshal.Read<UInt16>(span[offset..]);
    }

    /// <summary> Reads a <see cref="UInt32"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static UInt32 ReadUInt32(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) {
      span.ReadUInt32(out var result, offset, endian);
      return result;
    }

    /// <summary> Reads a <see cref="UInt32"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadUInt32(this in ReadOnlySpan<byte> span, out UInt32 result, int offset = 0, Endian endian = Endian.System) {
      result = !endian.IsSystem()
          ? BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<UInt32>(span[offset..]))
          : MemoryMarshal.Read<UInt32>(span[offset..]);
    }

    /// <summary> Reads a <see cref="UInt64"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static UInt64 ReadUInt64(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) {
      span.ReadUInt64(out var result, offset, endian);
      return result;
    }

    /// <summary> Reads a <see cref="UInt64"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadUInt64(this in ReadOnlySpan<byte> span, out UInt64 result, int offset = 0, Endian endian = Endian.System) {
      result = !endian.IsSystem()
          ? BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<UInt64>(span[offset..]))
          : MemoryMarshal.Read<UInt64>(span[offset..]);
    }

    public static T ReadObject<T>(this ReadOnlyMemory<byte> memory, BinaryContentAttribute attribute = null) => (T)(ReadObject(memory, typeof(T), attribute));

    public static object ReadObject(this in ReadOnlyMemory<byte> memory, Type type, BinaryContentAttribute attribute = null) {
      var att = attribute ?? new BinaryContentAttribute();
      var encoding = String.IsNullOrEmpty(att.Encoding) ? null : Encoding.GetEncoding(att.Encoding);

      var mem = att.CompressionType switch
      {
        CompressionTypes.Zlib => memory.ZlibDecompress(),
        _ => memory
      };

      var lenght = att.Length != 0 ? att.Length : mem.Length - att.Offset;

      switch (att.ConversationType) {
        case ConversationTypes.RDA:
          var reader = mem.ToReader();
          var rda = new Rda(ref reader);
          return RDASerializer.Convert(rda, type);

        case ConversationTypes.FileDB:
          return FileDBSerializer.Convert(mem, type);

        default:
          break;
      }

      if (type == typeof(object)) {
        //#if DEBUG
        //        var lenght = att.Length != 0 ? att.Length : memory.Length - att.Offset;
        //        return memory.Span.ReadBytes(lenght, att.Offset, att.Endian);
        //#endif

        return null;
      }
      else if (type == typeof(string)) {
        return mem.Span.ReadString(att.Offset, lenght, encoding, att.StringPattern);
      }
      //else if (type.IsEnumerable())
      //  throw new InvalidOperationException("Multidimensional arrays cannot be read directly.");
      else if (type == typeof(bool))
        return mem.Span.ReadBoolean(att.Offset, att.BoolPattern);
      else if (type == typeof(byte))
        return mem.Span.ReadByte(att.Offset);
      else if (type == typeof(DateTime))
        return mem.Span.ReadDateTime(att.Offset, att.DateTimePattern, att.Endian);
      else if (type == typeof(TimeSpan))
        return mem.Span.ReadTimeSpan(att.Offset, att.TimeSpanPattern, att.Endian);
      else if (type == typeof(decimal))
        return mem.Span.ReadDecimal(att.Offset);
      else if (type == typeof(double))
        return mem.Span.ReadDouble(att.Offset, att.Endian);
      else if (type == typeof(short))
        return mem.Span.ReadInt16(att.Offset, att.Endian);
      else if (type == typeof(int))
        return mem.Span.ReadInt32(att.Offset, att.Endian);
      else if (type == typeof(long))
        return mem.Span.ReadInt64(att.Offset, att.Endian);
      else if (type == typeof(sbyte))
        return mem.Span.ReadSByte(att.Offset);
      else if (type == typeof(float))
        return mem.Span.ReadSingle(att.Offset, att.Endian);
      else if (type == typeof(ushort))
        return mem.Span.ReadUInt16(att.Offset, att.Endian);
      else if (type == typeof(uint))
        return mem.Span.ReadUInt32(att.Offset, att.Endian);
      else if (type == typeof(ulong))
        return mem.Span.ReadUInt64(att.Offset, att.Endian);
      else if (type.IsEnum)
        return mem.Span.ReadEnum(type, att.Strict, att.Offset, att.Endian);
      else if (type == typeof(ReadOnlyMemory<byte>))
        return mem.Slice(att.Offset, lenght);
      else
        return mem[att.Offset..].ToReader().ReadCustomObject(type);
    }

    #endregion Public Methods

    #region Private Methods

    private static void DecodeString(this in ReadOnlySpan<byte> span, out String result, out int usedBytes, int length, Encoding encoding, int offset = 0) {
      if (length == 0)
        result = String.Empty;
      var decoder = encoding.GetDecoder();
      Span<char> chars = stackalloc char[length];
      decoder.Convert(span[offset..], chars, true, out var bytesUsed, out var charsUsed, out var completed);
      usedBytes = bytesUsed;
      result = chars.ToString();
    }

    #endregion Private Methods
  }
}