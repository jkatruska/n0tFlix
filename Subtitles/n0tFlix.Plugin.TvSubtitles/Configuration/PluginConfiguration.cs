using MediaBrowser.Model.Plugins;

namespace n0tFlix.Plugin.TvSubtitles.Configuration
{
    /// <summary>
    /// The plugin configuration.
    /// </summary>
    public class PluginConfiguration : BasePluginConfiguration
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the custom API Key.
        /// </summary>
        public string CustomApiKey { get; set; } = string.Empty;
    }
}
