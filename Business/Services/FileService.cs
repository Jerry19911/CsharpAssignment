﻿using System.IO;
using Business.Interfaces;

namespace Business.Services
{
    public class FileService : IFileService
    {
        private readonly string _directoryPath;
        private readonly string _filePath;

        public FileService(string directoryPath, string fileName)
        {
            _directoryPath = directoryPath;
            _filePath = Path.Combine(_directoryPath, fileName);
        }

        public bool SaveContentToFile(string content)
        {
            try
            {
                if (!Directory.Exists(_directoryPath))
                    Directory.CreateDirectory(_directoryPath);

                File.WriteAllText(_filePath, content);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string GetContentFromFile()
        {
            if (File.Exists(_filePath))
                return File.ReadAllText(_filePath);

            return null!;
        }
    }
}
