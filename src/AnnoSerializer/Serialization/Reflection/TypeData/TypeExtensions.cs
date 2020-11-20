// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Serialization.Reflection.TypeData {

  using System;
  using System.Collections;
  using System.Collections.Generic;

  /// <summary> Represents a collection of extension methods for the <see cref="Type"/> class. </summary>
  public static class TypeExtensions {

    #region Public Methods

    /// <summary>
    /// Returns a value indicating whether the given <paramref name="type"/> is enumerable. Returns
    /// <see langword="false"/> for non-enumerable objects and strings.
    /// </summary>
    /// <param name="type"> The type which should be checked. </param>
    /// <returns>
    /// <see langword="true"/> if the type is enumerable and not a string; otherwise <see langword="false"/>.
    /// </returns>
    public static bool IsEnumerable(this Type type) => type != typeof(string) && (type.IsArray || typeof(IEnumerable).IsAssignableFrom(type));

    /// <summary>
    /// Gets the element type of <see cref="IEnumerable"/> instances. Returns <see langword="null"/>
    /// for non-enumerable objects and strings.
    /// </summary>
    /// <param name="type"> The type which element type should be returned. </param>
    /// <returns> The type of the elements, or <see langword="null"/>. </returns>
    public static Type GetEnumerableElementType(this Type type) {
      // Do not handle strings as enumerables, they are stored differently.
      if (type == typeof(string)) {
        return null;
      }

      // Check for array instances.
      if (type.IsArray) {
        var elementType = type.GetElementType();
        return type.GetArrayRank() > 1 || elementType.IsArray
          ? throw new NotImplementedException($"Type {type} is a multidimensional array and not supported at the moment.")
          : elementType;
      }

      // Check for IEnumerable instances. Only the first implementation of IEnumerable<> is returned.
      if (typeof(IEnumerable).IsAssignableFrom(type)) {
        foreach (var interfaceType in type.GetInterfaces()) {
          if (interfaceType.IsGenericType
              && interfaceType.GetGenericTypeDefinition() == typeof(IEnumerable<>)) {
            return interfaceType.GetGenericArguments()[0];
          }
        }
      }

      return null;
    }

    public static Type GetFirstUnderlayingType(this Type type) {
      if (type == typeof(string)) {
        return null;
      }

      // Check for array instances.
      if (type.IsArray) {
        var elementType = type.GetElementType();
        if (type.GetArrayRank() > 1 || elementType.IsArray) {
          throw new NotImplementedException(
              $"Type {type} is a multidimensional array and not supported at the moment.");
        }
        return elementType;
      }

      if (type.IsGenericType) {
        var arguments = type.GetGenericArguments();

        if (arguments.Length > 1) {
          throw new NotImplementedException(
              $"Type {type} is a multidimensional generic and not supported at the moment.");
        }
        else if (arguments.Length == 1) {
          return arguments[0];
        }
      }

      return null;
    }

    public static bool TryGetEnumerableElementType(this Type type, out Type elementType) {
      // Do not handle strings as enumerables, they are stored differently.
      if (type != typeof(string)) {
        // Check for array instances.
        if (type.IsArray) {
          var elemType = type.GetElementType();
          if (type.GetArrayRank() > 1 || elemType.IsArray) {
            throw new NotImplementedException(
                $"Type {type} is a multidimensional array and not supported at the moment.");
          }
          elementType = elemType;
          return true;
        }

        // Check for IEnumerable instances. Only the first implementation of IEnumerable<> is returned.
        if (typeof(IEnumerable).IsAssignableFrom(type)) {
          foreach (var interfaceType in type.GetInterfaces()) {
            if (interfaceType.IsGenericType
                && interfaceType.GetGenericTypeDefinition() == typeof(IEnumerable<>)) {
              elementType = interfaceType.GetGenericArguments()[0];
              return true;
            }
          }
        }
      }

      elementType = null;
      return false;
    }

    #endregion Public Methods
  }
}