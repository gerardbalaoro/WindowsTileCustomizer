using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Shell32;
using System.Drawing;

namespace WindowsTileCustomizer.Core
{
    public class StartMenu
    {
        private string _Path;

        public StartMenu(string Path)
        {
            this._Path = Path;
        }

        public string Path {
            get { return this._Path; }
        }

        public string Name {
            get {
                return System.IO.Path.GetFileNameWithoutExtension(Path);
            }
        }

        public string Target {
            get {
                Shell WShell = new Shell();
                Folder ShortcutFolder = WShell.NameSpace(System.IO.Path.GetDirectoryName(Path));
                FolderItem Shortcut = ShortcutFolder.ParseName(System.IO.Path.GetFileName(Path));
                try {
                    if (Shortcut != null && Shortcut.IsLink) {
                        ShellLinkObject ShortcutLink = (ShellLinkObject)Shortcut.GetLink;
                        string ShortcutLinkPath = ShortcutLink.Path;
                        if (string.IsNullOrEmpty(ShortcutLinkPath)) return null;
                        if (!File.Exists(ShortcutLinkPath)) return ShortcutLinkPath.Replace("\\Program Files (x86)\\", "\\Program Files\\");
                        return File.Exists(ShortcutLinkPath) ? ShortcutLinkPath : null;
                    }
                } catch (UnauthorizedAccessException e) {
                    System.Diagnostics.Debug.WriteLine($"{e.Message}: {Name}");
                }

                return null;
            }
        }

        public string TargetDirectory {
            get {
                return Target != null ? System.IO.Path.GetDirectoryName(Target) : null;
            }
        }

        public Bitmap Icon {
            get {
                try {
                    return Target != null ? System.Drawing.Icon.ExtractAssociatedIcon(Target).ToBitmap() : null;
                } catch (Exception) {
                    return null;
                }
            }
        }

        public string ManifestPath {
            get {
                if (string.IsNullOrEmpty(Target)) return null;
                return System.IO.Path.Combine(
                    System.IO.Path.GetDirectoryName(Target),
                    System.IO.Path.GetFileNameWithoutExtension(Target) + ".VisualElementsManifest.xml"
                );
            }
        }

        public void Refresh()
        {
            File.SetLastWriteTime(Path, DateTime.Now);
        }

        private static string[] Paths =
        {
            Environment.GetFolderPath(Environment.SpecialFolder.StartMenu),
            Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu)
        };

        public static IEnumerable<StartMenu> GetAllItems()
        {
            foreach (var path in Paths) {
                foreach (var shortcut in Directory.GetFiles(path, "*.lnk", SearchOption.AllDirectories)) {
                    StartMenu menuItem = new StartMenu(shortcut);
                    if (!string.IsNullOrEmpty(menuItem.Target)) {
                        yield return menuItem;
                    }
                }
            }
        }
    }
}
