// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer {

  using System;
  using System.Collections.Generic;
  using System.Globalization;
  using System.IO;
  using System.Linq;
  using System.Reflection;
  using System.Web;
  using System.Xml.Linq;
  using AnnoSerializer.Templates;

  public static class LanguageService {

    #region Public Properties

    public static Languages Language {
      get => language;
      set {
        if (PossibleLanguages.Contains(value)) {
          language = value;
          LoadLanguageFile();
          OnLanguageChanged?.Invoke();
        }
      }
    }

    public static List<Languages> PossibleLanguages { get; } = new List<Languages>();

    public static Dictionary<int, string> Templates { get; } = new Dictionary<int, string>();

    public static Dictionary<int, string> Texts { get; } = new Dictionary<int, string>();

    #endregion Public Properties

    #region Public Events

    public static event Action OnLanguageChanged;

    #endregion Public Events

    #region Public Constructors

    static LanguageService() {
      //Set possible languages
      foreach (var lang in Enum.GetValues(typeof(Languages)).Cast<Languages>()) {
        var resource = $"AnnoSerializer.Resources.Languages.texts_{lang:G}.xml";
        if (Assembly.GetExecutingAssembly().GetManifestResourceNames().Contains(resource)) {
          PossibleLanguages.Add(lang);
        }
      }

      SetSystemLanguage();

      //Load Guid to template dictionary
      //using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("AnnoSerializer.Resources.Assets.Assets.xml");
      //using var reader = new StreamReader(stream);
      //var document = XElement.Parse(reader.ReadToEnd());
      //foreach (var item in document.Elements()) {
      //  Templates.Add(Convert.ToInt32(item.Attribute("GUID").Value), item.Attribute("Template").Value);
      //}
    }

    #endregion Public Constructors

    #region Private Methods

    private static void SetSystemLanguage() {
      Language = CultureInfo.CurrentCulture.TwoLetterISOLanguageName switch {
        "pt" => Languages.brazilian,
        "zh" => Languages.chinese,
        "en" => Languages.english,
        "fr" => Languages.french,
        "de" => Languages.german,
        "it" => Languages.italian,
        "ja" => Languages.japanese,
        "ko" => Languages.korean,
        "pl" => Languages.polish,
        "ru" => Languages.russian,
        "es" => Languages.spanish,
        //case "pt": Language = Library.Languages.Portuguese; break;
        //case "zh	": Language = Library.Languages.Taiwanese; break;
        _ => Languages.english,
      };
    }

    private static void LoadLanguageFile() {
      Texts.Clear();
      var resource = $"AnnoSerializer.Resources.Languages.texts_{Language:G}.xml";

      var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource);
      using var reader = new StreamReader(stream);
      var document = XDocument.Parse(reader.ReadToEnd()).Root.Element("Texts");
      foreach (var item in document.Elements()) {
        Texts.Add(Convert.ToInt32(item.Element("GUID").Value), HttpUtility.HtmlDecode(item.Element("Text").Value));
      }

      resource = $"AnnoSerializer.Resources.Languages.Custom.{Language:G}.xml";
      if (!Assembly.GetExecutingAssembly().GetManifestResourceNames().Contains(resource)) {
        resource = $"AnnoSerializer.Resources.Languages.Custom.{Languages.english:G}.xml";
      }

      var stream2 = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource);
      using var reader2 = new StreamReader(stream2);
      var document2 = XDocument.Parse(reader2.ReadToEnd()).Root.Element("Texts");
      foreach (var item in document2.Elements()) {
        Texts.Add(Convert.ToInt32(item.Element("GUID").Value), HttpUtility.HtmlDecode(item.Element("Text").Value ?? ""));
      }
    }

    #endregion Private Methods

    #region Private Fields

    private static Languages language = Languages.english;

    #endregion Private Fields
  }
}