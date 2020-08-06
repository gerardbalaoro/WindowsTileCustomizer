using System;
using System.IO;

namespace WindowsTileCustomizer.Utils
{
    class PathUtils
    {
        public static string ResolveRelative(string path, string parent)
        {
            if (Path.IsPathRooted(path)) return path;
            if (IsChildOf(Path.Combine(parent, path), parent)) {
                return Path.GetFullPath(Path.Combine(parent, path));
            }
            return Path.GetFullPath(path);
        }

        public static string GetRelativePath(string path, string parent)
        {
            path = Normalize(ResolveRelative(path, parent));
            string cwd = Environment.CurrentDirectory;
            Environment.CurrentDirectory = parent;
            string relative = path.Replace(Normalize(parent), "").TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
            Environment.CurrentDirectory = cwd;
            return relative;
        }

        public static string Normalize(string path)
        {
            return Path.GetFullPath(path).TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
        }

        public static bool IsChildOf(string path1, string path2)
        {
            path1 = Normalize(path1);
            path2 = Normalize(path2);
            return path1.StartsWith(path2);
        }
    }
}
