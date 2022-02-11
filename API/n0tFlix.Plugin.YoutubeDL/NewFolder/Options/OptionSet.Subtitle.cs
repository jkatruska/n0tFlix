﻿// <auto-generated>
// This code was partially generated by a tool.
// </auto-generated>

namespace n0tYoutubeDL.Core.Options
{
    public partial class OptionSet
    {
        private Option<bool> writeSub = new Option<bool>("--write-sub");
        private Option<bool> writeAutoSub = new Option<bool>("--write-auto-sub");
        private Option<bool> allSubs = new Option<bool>("--all-subs");
        private Option<bool> listSubs = new Option<bool>("--list-subs");
        private Option<string> subFormat = new Option<string>("--sub-format");
        private Option<string> subLang = new Option<string>("--sub-lang");

        /// <summary>
        /// Write subtitle file
        /// </summary>
        public bool WriteSub { get => writeSub.Value; set => writeSub.Value = value; }
        /// <summary>
        /// Write automatically generated subtitle
        /// file (YouTube only)
        /// </summary>
        public bool WriteAutoSub { get => writeAutoSub.Value; set => writeAutoSub.Value = value; }
        /// <summary>
        /// Download all the available subtitles of
        /// the video
        /// </summary>
        public bool AllSubs { get => allSubs.Value; set => allSubs.Value = value; }
        /// <summary>
        /// List all available subtitles for the
        /// video
        /// </summary>
        public bool ListSubs { get => listSubs.Value; set => listSubs.Value = value; }
        /// <summary>
        /// Subtitle format, accepts formats
        /// preference, for example: &quot;srt&quot; or
        /// &quot;ass/srt/best&quot;
        /// </summary>
        public string SubFormat { get => subFormat.Value; set => subFormat.Value = value; }
        /// <summary>
        /// Languages of the subtitles to download
        /// (optional) separated by commas, use
        /// --list-subs for available language tags
        /// </summary>
        public string SubLang { get => subLang.Value; set => subLang.Value = value; }
    }
}
