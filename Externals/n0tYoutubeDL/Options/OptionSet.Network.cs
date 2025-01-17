﻿// <auto-generated>
// This code was partially generated by a tool.
// </auto-generated>

namespace n0tYoutubeDL.Core.Options
{
    public partial class OptionSet
    {
        private Option<string> proxy = new Option<string>("--proxy");
        private Option<int?> socketTimeout = new Option<int?>("--socket-timeout");
        private Option<string> sourceAddress = new Option<string>("--source-address");
        private Option<bool> forceIpv4 = new Option<bool>("-4", "--force-ipv4");
        private Option<bool> forceIpv6 = new Option<bool>("-6", "--force-ipv6");

        /// <summary>
        /// Use the specified HTTP/HTTPS/SOCKS
        /// proxy. To enable SOCKS proxy, specify a
        /// proper scheme. For example
        /// socks5://127.0.0.1:1080/. Pass in an
        /// empty string (--proxy &quot;&quot;) for direct
        /// connection
        /// </summary>
        public string Proxy { get => proxy.Value; set => proxy.Value = value; }
        /// <summary>
        /// Time to wait before giving up, in
        /// seconds
        /// </summary>
        public int? SocketTimeout { get => socketTimeout.Value; set => socketTimeout.Value = value; }
        /// <summary>
        /// Client-side IP address to bind to
        /// </summary>
        public string SourceAddress { get => sourceAddress.Value; set => sourceAddress.Value = value; }
        /// <summary>
        /// Make all connections via IPv4
        /// </summary>
        public bool ForceIPv4 { get => forceIpv4.Value; set => forceIpv4.Value = value; }
        /// <summary>
        /// Make all connections via IPv6
        /// </summary>
        public bool ForceIPv6 { get => forceIpv6.Value; set => forceIpv6.Value = value; }
    }
}
