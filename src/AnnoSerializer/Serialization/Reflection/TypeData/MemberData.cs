// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Serialization.Reflection.TypeData {

  using System;
  using System.Diagnostics;
  using System.Reflection;
  using AnnoSerializer.Serialization.Core;

  /// <summary> Represents information on a member of a type cached as <see cref="TypeData"/>. </summary>
  [DebuggerDisplay(nameof(MemberData) + " " + nameof(MemberInfo) + "={" + nameof(MemberInfo) + "}")]
  public class MemberData {

    #region Public Properties

    /// <summary> Gets the <see cref="MemberInfo"/> represented. </summary>
    public MemberInfo MemberInfo { get; }

    /// <summary> Gets the <see cref="Type"/> of the value stored by the member. </summary>
    public Type Type { get; }

    /// <summary> Gets the <see cref="BinaryContentAttribute"/> configuration. </summary>
    public BinaryContentAttribute Attribute { get; }

    #endregion Public Properties

    #region Public Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="MemberData"/> class for the given <paramref
    /// name="memberInfo"/> with the specified <paramref name="attribute"/> configuration.
    /// </summary>
    /// <param name="memberInfo"> The <see cref="MemberData"/> to represent. </param>
    /// <param name="type"> The type of the value stored by the member. </param>
    /// <param name="attribute"> The <see cref="BinaryContentAttribute"/> configuration. </param>
    public MemberData(MemberInfo memberInfo, Type type, BinaryContentAttribute attribute) {
      MemberInfo = memberInfo;
      Type = type;
      Attribute = attribute;
    }

    #endregion Public Constructors
  }
}