using System;
using System.Text;
using System.Xml;
using System.Drawing;
using WindowsTileCustomizer.Utils;
using System.IO;

namespace WindowsTileCustomizer.Core
{
    public sealed class StringWriter : System.IO.StringWriter
    {
        private readonly Encoding encoding;

        public StringWriter() { }

        public StringWriter(Encoding encoding)
        {
            this.encoding = encoding;
        }

        public override Encoding Encoding {
            get { return encoding; }
        }
    }

    public class VisualElements
    {
        public enum ForegroundTextStyle
        {
            Light = 1,
            Dark = 2
        }

        private string _Path;

        public VisualElements(string path)
        {
            _Path = path;
            Load();
        }

        public string Path 
        {
            get { return _Path; } 
        }

        public string Directory {
            get { return System.IO.Path.GetDirectoryName(Path); }
        }

        public bool HasBackup {
            get { return File.Exists(BackupPath); }
        }

        public string BackupPath {
            get { return Path + ".bak"; }
        }

        public bool UserGenerated = false;

        public ForegroundTextStyle ForegroundText = ForegroundTextStyle.Light;
        public Color BackgroundColor = Color.Empty;
        public bool ShowNameOnMediumLogo = true;
        public string MediumLogo;
        public string SmallLogo;

        public string GetLogoImagePath(string path, Nullable<int> size = null, string contast = "standard")
        {
            path = PathUtils.ResolveRelative(path, Directory);
            if (File.Exists(path)) return path;
            if (size != null) {
                string dirname = System.IO.Path.GetDirectoryName(path);
                string filename = System.IO.Path.GetFileNameWithoutExtension(path);
                string extname = System.IO.Path.GetExtension(path);

                string[] alternateNames = {
                    $"{filename}.scale-{size}{extname}",
                    $"{filename}.contrast-{contast}{extname}",
                    $"{filename}.contrast-{contast}_scale-{size}{extname}"
                };

                foreach (var altName in alternateNames) {
                    string fullpath = PathUtils.ResolveRelative($"{dirname}/{altName}", Directory);
                    if (File.Exists(fullpath)) return fullpath;
                }
            }
            return null;
        }

        public Image GetLogoImage(string path, Nullable<int> size = null)
        {
            path = GetLogoImagePath(path, size);
            if (path == null) return null;
            return Image.FromFile(path);
        }

        public void Load()
        {
            if (File.Exists(Path))
            {
                using (XmlReader reader = XmlReader.Create(Path))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            if (reader.Name == "VisualElements")
                            {
                                var backgroundColor = reader.GetAttribute("BackgroundColor");
                                var foregroundText = reader.GetAttribute("ForegroundText");
                                var showNameOnMediumLogo = reader.GetAttribute("ShowNameOnSquare150x150Logo");
                                MediumLogo = reader.GetAttribute("Square150x150Logo");
                                SmallLogo = reader.GetAttribute("Square70x70Logo");
                                UserGenerated = reader.GetAttribute("UserGenerated") != null ? true : false;
                                BackgroundColor = backgroundColor != null ? ColorTranslator.FromHtml(backgroundColor) : Color.Empty;
                                ForegroundText = foregroundText == "dark" ? ForegroundTextStyle.Dark : ForegroundTextStyle.Light;
                                ShowNameOnMediumLogo = showNameOnMediumLogo == "off" ? false : true;
                            }
                        }
                    }
                }
            }
        }

        public void Save()
        {
            Backup();
            File.WriteAllText(Path, ToString(), Encoding.UTF8);
        }

        public void Backup()
        {
            if (File.Exists(Path) && !UserGenerated && !HasBackup) {
                File.Move(Path, BackupPath);
            }
        }

        public void Restore()
        {
            if (File.Exists(Path) && UserGenerated) File.Delete(Path);
            if (!File.Exists(Path) && HasBackup) File.Move(BackupPath, Path);
            Load();
        }

        public override string ToString()
        {
            StringWriter stringWriter = new StringWriter(Encoding.UTF8);
            XmlWriterSettings writerSettings = new XmlWriterSettings() { 
                Indent = true, NewLineOnAttributes = true, Encoding = Encoding.UTF8
            };
            using (XmlWriter writer = XmlWriter.Create(stringWriter, writerSettings)) {
                writer.WriteStartDocument();
                writer.WriteStartElement("Application");
                writer.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
                writer.WriteStartElement("VisualElements");
                if (BackgroundColor != Color.Empty) writer.WriteAttributeString("BackgroundColor", ColorTranslator.ToHtml(BackgroundColor));
                writer.WriteAttributeString("ShowNameOnSquare150x150Logo", ShowNameOnMediumLogo ? "on" : "off");
                if (!string.IsNullOrEmpty(MediumLogo)) writer.WriteAttributeString("Square150x150Logo", PathUtils.GetRelativePath(MediumLogo, Directory));
                if (!string.IsNullOrEmpty(SmallLogo)) writer.WriteAttributeString("Square70x70Logo", PathUtils.GetRelativePath(SmallLogo, Directory));
                writer.WriteAttributeString("ForegroundText", ForegroundText == ForegroundTextStyle.Dark ? "dark" : "light");
                writer.WriteAttributeString("UserGenerated", "true");
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            return stringWriter.ToString();
        }


    }
}
