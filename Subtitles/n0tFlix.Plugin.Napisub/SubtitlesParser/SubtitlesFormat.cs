﻿using System.Collections.Generic;

namespace n0tFlix.Plugin.NapiSub.SubtitlesParser
{
    public class SubtitlesFormat
    {
        // Properties -----------------------------------------

        public string Name { get; set; }
        public string Extension { get; set; }


        // Private constructor to avoid duplicates ------------

        private SubtitlesFormat() { }


        // Predefined instances -------------------------------

        public static SubtitlesFormat SubRipFormat = new SubtitlesFormat()
        {
            Name = "SubRip",
            Extension = @"\.srt"
        };

        public static SubtitlesFormat MicroDvdFormat = new SubtitlesFormat()
        {
            Name = "MicroDvd",
            Extension = @"\.sub"
        };

        public static SubtitlesFormat SubViewerFormat = new SubtitlesFormat()
        {
            Name = "SubViewer",
            Extension = @"\.sub"
        };

        public static SubtitlesFormat SubStationAlphaFormat = new SubtitlesFormat()
        {
            Name = "SubStationAlpha",
            Extension = @"\.ssa"
        };

        public static SubtitlesFormat TtmlFormat = new SubtitlesFormat()
        {
            Name = "TTML",
            Extension = @"\.ttml"
        };

        public static SubtitlesFormat WebVttFormat = new SubtitlesFormat()
        {
            Name = "WebVTT",
            Extension = @"\.vtt"
        };

        public static List<SubtitlesFormat> SupportedSubtitlesFormats = new List<SubtitlesFormat>
        {
            SubRipFormat,
            MicroDvdFormat,
            SubViewerFormat,
            SubStationAlphaFormat,
            TtmlFormat,
            WebVttFormat
        };
    }
}
