﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace n0tYoutubeDL.Core.Helpers
{
    /// <summary>
    /// Process extensions for killing full process tree.
    /// From https://github.com/dotnet/cli/blob/master/test/Microsoft.DotNet.Tools.Tests.Utilities/Extensions/ProcessExtensions.cs.
    /// </summary>
    internal static class ProcessExtensions
    {
#if NET45
        private static readonly bool _isWindows = true;
#else
        private static readonly bool _isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
#endif
        private static readonly TimeSpan _defaultTimeout = TimeSpan.FromSeconds(30);

        public static void KillTree(this Process process)
        {
            process.KillTree(_defaultTimeout);
        }

        public static void KillTree(this Process process, TimeSpan timeout)
        {
            string stdout;
            if (_isWindows)
            {
                RunProcessAndWaitForExit(
                    "taskkill",
                    $"/T /F /PID {process.Id}",
                    timeout,
                    out stdout);
            }
            else
            {
                var children = new HashSet<int>();
                GetAllChildIdsUnix(process.Id, children, timeout);
                foreach (var childId in children)
                {
                    KillProcessUnix(childId, timeout);
                }
                KillProcessUnix(process.Id, timeout);
            }
        }

        private static void GetAllChildIdsUnix(int parentId, ISet<int> children, TimeSpan timeout)
        {
            string stdout;
            var exitCode = RunProcessAndWaitForExit(
                "pgrep",
                $"-P {parentId}",
                timeout,
                out stdout);

            if (exitCode == 0 && !string.IsNullOrEmpty(stdout))
            {
                using (var reader = new StringReader(stdout))
                {
                    while (true)
                    {
                        var text = reader.ReadLine();
                        if (text == null)
                        {
                            return;
                        }

                        int id;
                        if (int.TryParse(text, out id))
                        {
                            children.Add(id);
                            GetAllChildIdsUnix(id, children, timeout);
                        }
                    }
                }
            }
        }

        private static void KillProcessUnix(int processId, TimeSpan timeout)
        {
            string stdout;
            RunProcessAndWaitForExit(
                "kill",
                $"-TERM {processId}",
                timeout,
                out stdout);
        }

        private static int RunProcessAndWaitForExit(string fileName, string arguments, TimeSpan timeout, out string stdout)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = fileName,
                Arguments = arguments,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var process = Process.Start(startInfo);

            stdout = null;
            if (process.WaitForExit((int)timeout.TotalMilliseconds))
            {
                stdout = process.StandardOutput.ReadToEnd();
            }
            else
            {
                process.Kill();
            }

            return process.ExitCode;
        }
    }
}
