// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoRdaExtractInsert {

  using System;
  using System.IO;
  using System.Windows;
  using ICSharpCode.SharpZipLib.Zip.Compression;
  using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
  using Ionic.Zlib;
  using Microsoft.Win32;

  /// <summary> Interaction logic for MainWindow.xaml </summary>
  public partial class MainWindow : Window {

    #region Public Constructors

    public MainWindow() {
      InitializeComponent();
      Loaded += MainWindow_Loaded;
    }

    #endregion Public Constructors

    #region Public Methods

    public static byte[] ZlibDecompress(ReadOnlyMemory<byte> bytesToDecompress) {
      using var inputStream = new MemoryStream();
      inputStream.Write(bytesToDecompress.Span);
      inputStream.Position = 0;
      using var decompressionStream = new InflaterInputStream(inputStream);
      using var outputStream = new MemoryStream();
      decompressionStream.CopyTo(outputStream);
      return outputStream.ToArray();
    }

    public static byte[] ZlibCompress2(ReadOnlyMemory<byte> bytesToCompress) {
      using var outputStream = new MemoryStream();
      using var outputStream2 = new MemoryStream();
      outputStream.Write(bytesToCompress.Span);
      outputStream.Position = 0;
      using var compressionStream = new ZlibStream(outputStream, Ionic.Zlib.CompressionMode.Compress, Ionic.Zlib.CompressionLevel.Level9);
      compressionStream.CopyTo(outputStream2);
      outputStream2.Position = 0;
      return outputStream2.ToArray();
    }

    public static byte[] ZlibCompress(ReadOnlyMemory<byte> bytesToCompress) {
      //Memory<byte> file = File.ReadAllBytes("bytes");
      using var inputStream = new MemoryStream();
      var mDeflater = new Deflater(Deflater.BEST_COMPRESSION);
      using var outputStream = new MemoryStream();
      using var compressionStream = new DeflaterOutputStream(outputStream, mDeflater);
      compressionStream.Write(bytesToCompress.Span);
      inputStream.Position = 0;
      compressionStream.Finish();
      //using var compressionStream = new ZlibStream(outputStream, Ionic.Zlib.CompressionMode.Compress, Ionic.Zlib.CompressionLevel.Level2);
      //outputStream.Position = 0;
      //compressionStream.CopyTo(outputStream);
      return outputStream.ToArray();

      //Memory<byte> k = System.IO.File.ReadAllBytes(path);
      //var slice = k.Slice(position, leangh);
      //data.CopyTo(slice);
      //File.WriteAllBytes($"{path}_edit", k.ToArray());
    }

    #endregion Public Methods

    #region Private Methods

    private void MainWindow_Loaded(object sender, RoutedEventArgs e) {
      //CompressionHelper.DecompressFromFile("moderate_atoll_ll_01.a7t", 792, 325162);
      //MessageBox.Show("Please edit the bytes file than press ok.");
      //CompressionHelper.InsertBlockCompressed("moderate_atoll_ll_01.a7t", 792, 325162);
      var dialog = new OpenFileDialog();
      if (dialog.ShowDialog() == true && File.Exists(dialog.FileName)) {
        //var file = File.ReadAllBytes(dialog.FileName);
        //var rda = new Rda(file);
        //var unCompressedFile = ZlibDecompress(rda.Blocks[3].Files[0].FileData);
        //var compressedFile = ZlibCompress(unCompressedFile);
      }
    }

    #endregion Private Methods
  }
}