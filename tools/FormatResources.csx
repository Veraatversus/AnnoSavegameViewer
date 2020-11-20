#r "System.Xml.XDocument"
using System;
using System.Xml.Linq;
using System.IO;

foreach (var file in new DirectoryInfo("..\\res\\AnnoFiles").GetFiles()) {
  try {
    Console.Write($"Format file: {file.Name} ... ");
    var ele = XElement.Load(file.FullName);
    ele.Save(file.FullName, SaveOptions.DisableFormatting);
    Console.WriteLine("Done.");
  }
  catch (Exception) {

  }
}