// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Templates {
  using AnnoSerializer.Converter;
  using System.ComponentModel;

  [TypeConverter(typeof(EnumDescriptionTypeConverter))]
  public enum Languages {

    [Description("English")]
    english,

    [Description("Deutsch")]
    german,

    [Description("Brazilian")]
    brazilian,

    [Description("简体中文")]
    chinese,

    [Description("Français")]
    french,

    [Description("Italiano")]
    italian,

    [Description("日本の")]
    japanese,

    [Description("한국의")]
    korean,

    [Description("Polski")]
    polish,

    [Description("Português")]
    portuguese,

    [Description("Pусский")]
    russian,

    [Description("Español")]
    spanish,

    [Description("ไทย")]
    taiwanese
  }
}