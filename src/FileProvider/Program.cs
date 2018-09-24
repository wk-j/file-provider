using System;
using Microsoft.Extensions.FileProviders;

namespace FileProvider {
    class Program {
        static void Main(string[] args) {
            var provider = new PhysicalFileProvider(".");
            var contents = provider.GetDirectoryContents(string.Empty);
        }
    }
}