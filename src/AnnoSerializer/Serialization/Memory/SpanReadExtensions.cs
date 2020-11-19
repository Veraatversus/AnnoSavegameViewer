// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Serialization.Memory {

  using System;
  using System.Buffers.Binary;
  using System.Linq;
  using System.Runtime.CompilerServices;
  using System.Runtime.InteropServices;
  using System.Text;
  using AnnoSerializer.Serialization.Core;
  using AnnoSerializer.Structures.RDA;

  public static class SpanReadExtensions {

    #region Public Methods

    /// <summary> Reads a <see cref="bool"/> value from the given offset and by the given pattern. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool ReadBoolean(this in ReadOnlySpan<byte> span, int offset = 0, BoolPattern pattern = default) {
      span.ReadBoolean(out var result, out var _, offset, pattern);
      return result;
    }

    /// <summary> Reads a <see cref="bool"/> value from the given offset and by the given pattern. </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadBoolean(this in ReadOnlySpan<byte> span, out bool result, out int usedBytes, int offset = 0, BoolPattern pattern = default) {
      (result, usedBytes) = pattern switch {
        BoolPattern.Byte => (span[offset] != 0, 1),
        BoolPattern.Word => (MemoryMarshal.Read<ushort>(span[offset..]) != 0, 2),
        BoolPattern.Dword => (MemoryMarshal.Read<uint>(span[offset..]) != 0, 4),
        _ => throw new NotImplementedException()
      };
      usedBytes += offset;
    }

    /// <summary> Reads the given number of <see cref="byte"/> values from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] ReadBytes(this in ReadOnlySpan<byte> span, int count, int offset = 0, Endian endian = Endian.System) => !endian.IsSystem() ? span.Slice(offset, count).ToArray().Reverse().ToArray() : span.Slice(offset, count).ToArray();

    /// <summary> Reads a <see cref="byte"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte ReadByte(this in ReadOnlySpan<byte> span, int offset = 0) {
      span.ReadByte(out var result, offset);
      return result;
    }

    /// <summary> Reads a <see cref="byte"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    public static void ReadByte(this in ReadOnlySpan<byte> span, out byte result, int offset = 0) => result = span[offset];

    /// <summary> Reads a <see cref="DateTime/> value from the given offset by the given pattern.
    /// </summary> <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DateTime ReadDateTime(this in ReadOnlySpan<byte> span, int offset = 0, DateTimePattern pattern = default, Endian endian = Endian.System) {
      span.ReadDateTime(out var result, out var _, offset, pattern, endian);
      return result;
    }

    /// <summary> Reads a <see cref="DateTime/> value from the given offset by the given pattern.
    /// </summary> <exception cref="ArgumentOutOfRangeException">There are less bytes available than required.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadDateTime(this in ReadOnlySpan<byte> span, out DateTime result, out int usedBytes, int offset = 0, DateTimePattern pattern = default, Endian endian = Endian.System) {
      (result, usedBytes) = pattern switch {
        DateTimePattern.NetTicks => (new DateTime(span.ReadInt64(offset, endian)), 8),
        DateTimePattern.CTime => (CTimeTools.GetDateTime(span.ReadUInt32(offset, endian)), 4),
        DateTimePattern.CTime64 => (CTimeTools.GetDateTime(span.ReadUInt64(offset, endian)), 8),
        _ => throw new NotImplementedException()
      };
      usedBytes += offset;
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

    /// <summary> Reads a <see cref="decimal"/> value from the given offset. </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal ReadDecimal(this in ReadOnlySpan<byte> span, int offset = 0) {
      span.ReadDecimal(out var result, offset);
      return result;
    }

    /// <summary> Reads a <see cref="decimal"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadDecimal(this in ReadOnlySpan<byte> span, out decimal result, int offset = 0) => result = MemoryMarshal.Read<decimal>(span[offset..]);

    /// <summary> Reads a <see cref="double"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double ReadDouble(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) {
      span.ReadDouble(out var result, offset, endian);
      return result;
    }

    /// <summary> Reads a <see cref="double"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadDouble(this in ReadOnlySpan<byte> span, out double result, int offset = 0, Endian endian = Endian.System) {
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
      usedBytes += offset;
    }

    public static object ReadEnum(this in ReadOnlySpan<byte> span, Type enumType, bool strict, int offset = 0, Endian endian = Endian.System) {
      span.ReadEnum(out var result, out var _, enumType, strict, offset, endian);
      return result;
    }

    public static void ReadEnum(this in ReadOnlySpan<byte> span, out object result, out int usedBytes, Type enumType, bool strict, int offset = 0, Endian endian = Endian.System) {
      var valueType = Enum.GetUnderlyingType(enumType);

      if (valueType == typeof(byte)) {
        usedBytes = 1 + offset;
        result = span.ReadByte(offset);
      }
      else if (valueType == typeof(sbyte)) {
        usedBytes = 1 + offset;
        result = span.ReadSByte(offset);
      }
      else if (valueType == typeof(short)) {
        usedBytes = 2 + offset;
        result = span.ReadInt16(offset, endian);
      }
      else if (valueType == typeof(int)) {
        usedBytes = 4 + offset;
        result = span.ReadInt32(offset, endian);
      }
      else if (valueType == typeof(long)) {
        usedBytes = 8 + offset;
        result = span.ReadInt64(offset, endian);
      }
      else if (valueType == typeof(ushort)) {
        usedBytes = 2 + offset;
        result = span.ReadUInt16(offset, endian);
      }
      else if (valueType == typeof(uint)) {
        usedBytes = 4 + offset;
        result = span.ReadUInt32(offset, endian);
      }
      else if (valueType == typeof(ulong)) {
        usedBytes = 8 + offset;
        result = span.ReadUInt64(offset, endian);
      }
      else {
        throw new NotImplementedException($"Unsupported enum type {valueType}.");
      }

      // Check if the value is defined in the enumeration, if requested.
      if (strict)
        _ = EnumTools.Validate(enumType, result);
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

    /// <summary> Reads an <see cref="short"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short ReadInt16(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) {
      span.ReadInt16(out var result, offset, endian);
      return result;
    }

    /// <summary> Reads an <see cref="short"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadInt16(this in ReadOnlySpan<byte> span, out short result, int offset = 0, Endian endian = Endian.System) {
      result = !endian.IsSystem()
          ? BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<short>(span[offset..]))
          : MemoryMarshal.Read<short>(span[offset..]);
    }

    /// <summary> Reads an <see cref="int"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ReadInt32(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) {
      span.ReadInt32(out var result, offset, endian);
      return result;
    }

    /// <summary> Reads an <see cref="int"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadInt32(this in ReadOnlySpan<byte> span, out int result, int offset = 0, Endian endian = Endian.System) {
      result = !endian.IsSystem()
          ? BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<int>(span[offset..]))
          : MemoryMarshal.Read<int>(span[offset..]);
    }

    /// <summary>
    /// Reads an <see cref="int"/> value from the given offset. The value is stored in 1 to 5 bytes,
    /// only using another byte if it does not fit into 7 more bits of the current one.
    /// </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentException"> The data available is not a 7-bit encoded integer. </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ReadInt32Bit7(this in ReadOnlySpan<byte> span, int offset = 0) {
      span.ReadInt32Bit7(out var result, out var _, offset);
      return result;
    }

    /// <summary>
    /// Reads an <see cref="int"/> value from the given offset. The value is stored in 1 to 5 bytes,
    /// only using another byte if it does not fit into 7 more bits of the current one.
    /// </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentException"> The data available is not a 7-bit encoded integer. </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadInt32Bit7(this in ReadOnlySpan<byte> span, out int result, out int usedBytes, int offset = 0) {
      // Endianness does not matter, as this value is stored byte by byte. While the highest bit is
      // set, the integer requires another of a maximum of 5 bytes.
      result = 0;
      var tempOffset = offset;
      for (var i = 0; i < sizeof(int) + 1; i++) {
        var readByte = span[tempOffset++];
        result |= (readByte & 0b01111111) << (i * 7);
        if ((readByte & 0b10000000) == 0) {
          usedBytes = i + 1;
          usedBytes += offset;
          return;
        }
      }
      throw new ArgumentException("Invalid 7-bit encoded Int32.");
    }

    /// <summary> Reads an <see cref="long"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long ReadInt64(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) {
      span.ReadInt64(out var result, offset, endian);
      return result;
    }

    /// <summary> Reads an <see cref="long"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadInt64(this in ReadOnlySpan<byte> span, out long result, int offset = 0, Endian endian = Endian.System) {
        result = !endian.IsSystem()
          ? BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<long>(span[offset..]))
          : MemoryMarshal.Read<long>(span[offset..]);
    }

    /// <summary> Reads an <see cref="sbyte"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte ReadSByte(this in ReadOnlySpan<byte> span, int offset = 0) => (sbyte)span[offset];

    /// <summary> Reads an <see cref="sbyte"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadSByte(this in ReadOnlySpan<byte> span, out sbyte result, int offset = 0) => result = (sbyte)span[offset];

    /// <summary> Reads an <see cref="float"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float ReadSingle(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) {
      span.ReadSingle(out var result, offset, endian);
      return result;
    }

    /// <summary> Reads an <see cref="float"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadSingle(this in ReadOnlySpan<byte> span, out float result, int offset = 0, Endian endian = Endian.System) {
      span.ReadInt32(out var value, offset, endian);
      result = BitConverter.Int32BitsToSingle(value);
    }

    /// <summary>
    /// Reads a <see cref="string"/> value from the given offset and by the given pattern and the
    /// given length.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string ReadString(this in ReadOnlySpan<byte> span, int offset = 0, int length = 0, Encoding encoding = null, StringPattern stringPattern = StringPattern.VariableByteCount) {
      span.ReadString(out var value, out var _, offset, length, encoding, stringPattern);
      return value;
    }

    /// <summary>
    /// Reads a <see cref="string"/> value from the given offset and by the given pattern and the
    /// given length.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadString(this in ReadOnlySpan<byte> span, out string result, out int usedBytes, int offset = 0, int length = 0, Encoding encoding = null, StringPattern stringPattern = StringPattern.VariableByteCount) {
      var _encoding = encoding ?? Encoding.UTF8;

      if (stringPattern == StringPattern.FixByteCount) {
        result = _encoding.GetString(span.Slice(offset, length));
        usedBytes = length + offset;
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
        usedBytes = byteLength + offset;
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

    /// <summary> Reads a <see cref="ushort"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort ReadUInt16(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) {
      span.ReadUInt16(out var result, offset, endian);
      return result;
    }

    /// <summary> Reads a <see cref="ushort"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadUInt16(this in ReadOnlySpan<byte> span, out ushort result, int offset = 0, Endian endian = Endian.System) {
      result = !endian.IsSystem()
          ? BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<ushort>(span[offset..]))
          : MemoryMarshal.Read<ushort>(span[offset..]);
    }

    /// <summary> Reads a <see cref="uint"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint ReadUInt32(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) {
      span.ReadUInt32(out var result, offset, endian);
      return result;
    }

    /// <summary> Reads a <see cref="uint"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadUInt32(this in ReadOnlySpan<byte> span, out uint result, int offset = 0, Endian endian = Endian.System) {
      result = !endian.IsSystem()
          ? BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<uint>(span[offset..]))
          : MemoryMarshal.Read<uint>(span[offset..]);
    }

    /// <summary> Reads a <see cref="ulong"/> value from the given offset. </summary>
    /// <returns> The value retrieved from the given offset. </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong ReadUInt64(this in ReadOnlySpan<byte> span, int offset = 0, Endian endian = Endian.System) {
      span.ReadUInt64(out var result, offset, endian);
      return result;
    }

    /// <summary> Reads a <see cref="ulong"/> value from the given offset. </summary>
    /// <param name="result"> The value retrieved from the given offset. </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// There are less bytes available than required.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ReadUInt64(this in ReadOnlySpan<byte> span, out ulong result, int offset = 0, Endian endian = Endian.System) {
      result = !endian.IsSystem()
          ? BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<ulong>(span[offset..]))
          : MemoryMarshal.Read<ulong>(span[offset..]);
    }

    public static T ReadObject<T>(this ReadOnlyMemory<byte> memory, BinaryContentAttribute attribute = null) => (T)(ReadObject(memory, out var _, typeof(T), attribute));

    public static object ReadObject(this in ReadOnlyMemory<byte> memory, out int usedBytes, Type type, BinaryContentAttribute attribute = null) {
      object mainResult = null;
      usedBytes = 0;
      var att = attribute ?? new BinaryContentAttribute();
      var encoding = string.IsNullOrEmpty(att.Encoding) ? null : Encoding.GetEncoding(att.Encoding);
      var (mem, isCompressed) = att.CompressionType switch {
        CompressionTypes.Zlib => (memory.ZlibDecompress(), true),
        _ => (memory, false)
      };
      var lenght = att.Length != 0 ? att.Length : mem.Length - att.Offset;

      if (att.ConversationType != ConversationTypes.None) {
        switch (att.ConversationType) {
          case ConversationTypes.RDA:
            var rda = new Rda(mem);
            mainResult = RDASerializer.Convert(rda, type, out usedBytes);
            break;

          case ConversationTypes.FileDB:
            mainResult = FileDBSerializer.Convert(mem, type, out usedBytes);
            break;
        }
      }
      else if (type == typeof(object)) {
        //#if DEBUG
        //        var lenght = att.Length != 0 ? att.Length : memory.Length - att.Offset;
        //        return memory.Span.ReadBytes(lenght, att.Offset, att.Endian);
        //#endif

        mainResult = null;
      }
      else if (type == typeof(string)) {
        mem.Span.ReadString(out var result, out usedBytes, att.Offset, lenght, encoding, att.StringPattern);
        usedBytes += att.Offset;
        mainResult = result;
      }
      else if (type == typeof(bool)) {
        mem.Span.ReadBoolean(out var result, out usedBytes, att.Offset, att.BoolPattern);
        usedBytes += att.Offset;
        mainResult = result;
      }
      else if (type == typeof(byte)) {
        usedBytes = 1 + att.Offset;
        mainResult = mem.Span.ReadByte(att.Offset);
      }
      else if (type == typeof(DateTime)) {
        mem.Span.ReadDateTime(out var result, out usedBytes, att.Offset, att.DateTimePattern, att.Endian);
        usedBytes += att.Offset;
        mainResult = result;
      }
      else if (type == typeof(TimeSpan)) {
        usedBytes = 8 + att.Offset;
        mainResult = mem.Span.ReadTimeSpan(att.Offset, att.TimeSpanPattern, att.Endian);
      }
      else if (type == typeof(decimal)) {
        usedBytes = 16 + att.Offset;
        mainResult = mem.Span.ReadDecimal(att.Offset);
      }
      else if (type == typeof(double)) {
        usedBytes = 8 + att.Offset;
        mainResult = mem.Span.ReadDouble(att.Offset, att.Endian);
      }
      else if (type == typeof(short)) {
        usedBytes = 2 + att.Offset;
        mainResult = mem.Span.ReadInt16(att.Offset, att.Endian);
      }
      else if (type == typeof(int)) {
        usedBytes = 4 + att.Offset;
        mainResult = mem.Span.ReadInt32(att.Offset, att.Endian);
      }
      else if (type == typeof(long)) {
        usedBytes = 8 + att.Offset;
        mainResult = mem.Span.ReadInt64(att.Offset, att.Endian);
      }
      else if (type == typeof(sbyte)) {
        usedBytes = 1 + att.Offset;
        mainResult = mem.Span.ReadSByte(att.Offset);
      }
      else if (type == typeof(float)) {
        usedBytes = 4 + att.Offset;
        mainResult = mem.Span.ReadSingle(att.Offset, att.Endian);
      }
      else if (type == typeof(ushort)) {
        usedBytes = 2 + att.Offset;
        mainResult = mem.Span.ReadUInt16(att.Offset, att.Endian);
      }
      else if (type == typeof(uint)) {
        usedBytes = 4 + att.Offset;
        mainResult = mem.Span.ReadUInt32(att.Offset, att.Endian);
      }
      else if (type == typeof(ulong)) {
        usedBytes = 8 + att.Offset;
        mainResult = mem.Span.ReadUInt64(att.Offset, att.Endian);
      }
      else if (type.IsEnum) {
        mem.Span.ReadEnum(out var result, out usedBytes, type, att.Strict, att.Offset, att.Endian);
        usedBytes += att.Offset;
        mainResult = result;
      }
      else if (type == typeof(ReadOnlyMemory<byte>)) {
        usedBytes = lenght + att.Offset;
        mainResult = mem.Slice(att.Offset, lenght);
      }
      else {
        var result = mem[att.Offset..].ToReader().ReadCustomObject(out usedBytes, type);
        usedBytes += att.Offset;
        mainResult = result;
      }
      if (isCompressed) {
        usedBytes = memory.Length;
      }
      return mainResult;
    }

    #endregion Public Methods

    #region Private Methods

    private static void DecodeString(this in ReadOnlySpan<byte> span, out string result, out int usedBytes, int length, Encoding encoding, int offset = 0) {
      if (length == 0 || length > span.Length) {
        result = string.Empty;
        usedBytes = offset;
        return;
      }
      var decoder = encoding.GetDecoder();
      Span<char> chars = stackalloc char[length];
      decoder.Convert(span[offset..], chars, true, out var bytesUsed, out var charsUsed, out var completed);
      usedBytes = bytesUsed + offset;
      result = chars.ToString();
    }

    #endregion Private Methods
  }
}