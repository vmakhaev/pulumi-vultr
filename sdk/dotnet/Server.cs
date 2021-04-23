// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Vultr
{
    /// <summary>
    /// Provides a Vultr server resource. This can be used to create, read, modify, and delete servers on your Vultr account.
    /// </summary>
    public partial class Server : Pulumi.CustomResource
    {
        /// <summary>
        /// The server's allowed bandwidth usage in GB.
        /// </summary>
        [Output("allowedBandwidth")]
        public Output<string> AllowedBandwidth { get; private set; } = null!;

        /// <summary>
        /// The ID of the Vultr application to be installed on the server.
        /// </summary>
        [Output("appId")]
        public Output<int> AppId { get; private set; } = null!;

        /// <summary>
        /// Whether automatic backups will be enabled for this server (these have an extra charge associated with them).
        /// </summary>
        [Output("autoBackup")]
        public Output<bool> AutoBackup { get; private set; } = null!;

        /// <summary>
        /// The server's cost per month in USD.
        /// </summary>
        [Output("costPerMonth")]
        public Output<string> CostPerMonth { get; private set; } = null!;

        /// <summary>
        /// The server's current bandwidth usage in GB.
        /// </summary>
        [Output("currentBandwidth")]
        public Output<double> CurrentBandwidth { get; private set; } = null!;

        /// <summary>
        /// The date the server was added to your Vultr account.
        /// </summary>
        [Output("dateCreated")]
        public Output<string> DateCreated { get; private set; } = null!;

        /// <summary>
        /// Whether DDOS protection will be enabled on the server (there is an additional charge for this).
        /// </summary>
        [Output("ddosProtection")]
        public Output<bool> DdosProtection { get; private set; } = null!;

        /// <summary>
        /// The server's default password.
        /// </summary>
        [Output("defaultPassword")]
        public Output<string> DefaultPassword { get; private set; } = null!;

        /// <summary>
        /// The description of the disk(s) on the server.
        /// </summary>
        [Output("disk")]
        public Output<string> Disk { get; private set; } = null!;

        /// <summary>
        /// Whether the server has IPv6 networking activated.
        /// </summary>
        [Output("enableIpv6")]
        public Output<bool> EnableIpv6 { get; private set; } = null!;

        /// <summary>
        /// Whether the server has private networking support enabled.
        /// </summary>
        [Output("enablePrivateNetwork")]
        public Output<bool> EnablePrivateNetwork { get; private set; } = null!;

        /// <summary>
        /// The ID of the firewall group to assign to the server.
        /// </summary>
        [Output("firewallGroupId")]
        public Output<string> FirewallGroupId { get; private set; } = null!;

        /// <summary>
        /// The server's IPv4 gateway.
        /// </summary>
        [Output("gatewayV4")]
        public Output<string> GatewayV4 { get; private set; } = null!;

        /// <summary>
        /// The hostname to assign to the server.
        /// </summary>
        [Output("hostname")]
        public Output<string> Hostname { get; private set; } = null!;

        /// <summary>
        /// The server's internal IP address.
        /// </summary>
        [Output("internalIp")]
        public Output<string> InternalIp { get; private set; } = null!;

        /// <summary>
        /// The ID of the ISO file to be installed on the server.
        /// </summary>
        [Output("isoId")]
        public Output<int> IsoId { get; private set; } = null!;

        /// <summary>
        /// The server's current KVM URL. This URL will change periodically. It is not advised to cache this value.
        /// </summary>
        [Output("kvmUrl")]
        public Output<string> KvmUrl { get; private set; } = null!;

        /// <summary>
        /// A label for the server.
        /// </summary>
        [Output("label")]
        public Output<string> Label { get; private set; } = null!;

        /// <summary>
        /// The physical location of the server.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The server's main IP address.
        /// </summary>
        [Output("mainIp")]
        public Output<string> MainIp { get; private set; } = null!;

        /// <summary>
        /// The server's IPv4 netmask.
        /// </summary>
        [Output("netmaskV4")]
        public Output<string> NetmaskV4 { get; private set; } = null!;

        /// <summary>
        /// A list of private network IDs to be attached to the server.
        /// </summary>
        [Output("networkIds")]
        public Output<ImmutableArray<string>> NetworkIds { get; private set; } = null!;

        [Output("networkIps")]
        public Output<ImmutableDictionary<string, string>> NetworkIps { get; private set; } = null!;

        [Output("networkMacs")]
        public Output<ImmutableDictionary<string, string>> NetworkMacs { get; private set; } = null!;

        /// <summary>
        /// Whether an activation email will be sent when the server is ready.
        /// </summary>
        [Output("notifyActivate")]
        public Output<bool> NotifyActivate { get; private set; } = null!;

        /// <summary>
        /// The string description of the operating system installed on the server.
        /// </summary>
        [Output("os")]
        public Output<string> Os { get; private set; } = null!;

        /// <summary>
        /// The ID of the operating system to be installed on the server.
        /// </summary>
        [Output("osId")]
        public Output<int> OsId { get; private set; } = null!;

        /// <summary>
        /// Charges pending for this server's subscription in USD.
        /// </summary>
        [Output("pendingCharges")]
        public Output<string> PendingCharges { get; private set; } = null!;

        /// <summary>
        /// The ID of the plan that you want the server to subscribe to.
        /// </summary>
        [Output("planId")]
        public Output<int> PlanId { get; private set; } = null!;

        /// <summary>
        /// Whether the server is powered on or not.
        /// </summary>
        [Output("powerStatus")]
        public Output<string> PowerStatus { get; private set; } = null!;

        /// <summary>
        /// The amount of memory available on the server in MB.
        /// </summary>
        [Output("ram")]
        public Output<string> Ram { get; private set; } = null!;

        /// <summary>
        /// The ID of the region that the server is to be created in.
        /// </summary>
        [Output("regionId")]
        public Output<int> RegionId { get; private set; } = null!;

        /// <summary>
        /// IP address of the floating IP to use as the main IP of this server.
        /// </summary>
        [Output("reservedIp")]
        public Output<string> ReservedIp { get; private set; } = null!;

        /// <summary>
        /// The ID of the startup script you want added to the server.
        /// </summary>
        [Output("scriptId")]
        public Output<string> ScriptId { get; private set; } = null!;

        /// <summary>
        /// A more detailed server status (none, locked, installingbooting, isomounting, ok).
        /// </summary>
        [Output("serverState")]
        public Output<string> ServerState { get; private set; } = null!;

        /// <summary>
        /// The ID of the Vultr snapshot that the server will restore for the initial installation. 
        /// </summary>
        [Output("snapshotId")]
        public Output<string> SnapshotId { get; private set; } = null!;

        /// <summary>
        /// A list of SSH key IDs to apply to the server on install (only valid for Linux/FreeBSD).
        /// </summary>
        [Output("sshKeyIds")]
        public Output<ImmutableArray<string>> SshKeyIds { get; private set; } = null!;

        /// <summary>
        /// The status of the server's subscription.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// The tag to assign to the server.
        /// </summary>
        [Output("tag")]
        public Output<string> Tag { get; private set; } = null!;

        /// <summary>
        /// Generic data store, which some provisioning tools and cloud operating systems use as a configuration file. It is generally consumed only once after an instance has been launched, but individual needs may vary.
        /// </summary>
        [Output("userData")]
        public Output<string> UserData { get; private set; } = null!;

        /// <summary>
        /// A list of the server's IPv6 networks.
        /// </summary>
        [Output("v6Networks")]
        public Output<ImmutableArray<ImmutableDictionary<string, object>>> V6Networks { get; private set; } = null!;

        /// <summary>
        /// The number of virtual CPUs available on the server.
        /// </summary>
        [Output("vpsCpuCount")]
        public Output<string> VpsCpuCount { get; private set; } = null!;


        /// <summary>
        /// Create a Server resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Server(string name, ServerArgs args, CustomResourceOptions? options = null)
            : base("vultr:index/server:Server", name, args ?? new ServerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Server(string name, Input<string> id, ServerState? state = null, CustomResourceOptions? options = null)
            : base("vultr:index/server:Server", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Server resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Server Get(string name, Input<string> id, ServerState? state = null, CustomResourceOptions? options = null)
        {
            return new Server(name, id, state, options);
        }
    }

    public sealed class ServerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the Vultr application to be installed on the server.
        /// </summary>
        [Input("appId")]
        public Input<int>? AppId { get; set; }

        /// <summary>
        /// Whether automatic backups will be enabled for this server (these have an extra charge associated with them).
        /// </summary>
        [Input("autoBackup")]
        public Input<bool>? AutoBackup { get; set; }

        /// <summary>
        /// Whether DDOS protection will be enabled on the server (there is an additional charge for this).
        /// </summary>
        [Input("ddosProtection")]
        public Input<bool>? DdosProtection { get; set; }

        /// <summary>
        /// Whether the server has IPv6 networking activated.
        /// </summary>
        [Input("enableIpv6")]
        public Input<bool>? EnableIpv6 { get; set; }

        /// <summary>
        /// Whether the server has private networking support enabled.
        /// </summary>
        [Input("enablePrivateNetwork")]
        public Input<bool>? EnablePrivateNetwork { get; set; }

        /// <summary>
        /// The ID of the firewall group to assign to the server.
        /// </summary>
        [Input("firewallGroupId")]
        public Input<string>? FirewallGroupId { get; set; }

        /// <summary>
        /// The hostname to assign to the server.
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        /// <summary>
        /// The ID of the ISO file to be installed on the server.
        /// </summary>
        [Input("isoId")]
        public Input<int>? IsoId { get; set; }

        /// <summary>
        /// A label for the server.
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        [Input("networkIds")]
        private InputList<string>? _networkIds;

        /// <summary>
        /// A list of private network IDs to be attached to the server.
        /// </summary>
        public InputList<string> NetworkIds
        {
            get => _networkIds ?? (_networkIds = new InputList<string>());
            set => _networkIds = value;
        }

        /// <summary>
        /// Whether an activation email will be sent when the server is ready.
        /// </summary>
        [Input("notifyActivate")]
        public Input<bool>? NotifyActivate { get; set; }

        /// <summary>
        /// The ID of the operating system to be installed on the server.
        /// </summary>
        [Input("osId")]
        public Input<int>? OsId { get; set; }

        /// <summary>
        /// The ID of the plan that you want the server to subscribe to.
        /// </summary>
        [Input("planId", required: true)]
        public Input<int> PlanId { get; set; } = null!;

        /// <summary>
        /// The ID of the region that the server is to be created in.
        /// </summary>
        [Input("regionId", required: true)]
        public Input<int> RegionId { get; set; } = null!;

        /// <summary>
        /// IP address of the floating IP to use as the main IP of this server.
        /// </summary>
        [Input("reservedIp")]
        public Input<string>? ReservedIp { get; set; }

        /// <summary>
        /// The ID of the startup script you want added to the server.
        /// </summary>
        [Input("scriptId")]
        public Input<string>? ScriptId { get; set; }

        /// <summary>
        /// The ID of the Vultr snapshot that the server will restore for the initial installation. 
        /// </summary>
        [Input("snapshotId")]
        public Input<string>? SnapshotId { get; set; }

        [Input("sshKeyIds")]
        private InputList<string>? _sshKeyIds;

        /// <summary>
        /// A list of SSH key IDs to apply to the server on install (only valid for Linux/FreeBSD).
        /// </summary>
        public InputList<string> SshKeyIds
        {
            get => _sshKeyIds ?? (_sshKeyIds = new InputList<string>());
            set => _sshKeyIds = value;
        }

        /// <summary>
        /// The tag to assign to the server.
        /// </summary>
        [Input("tag")]
        public Input<string>? Tag { get; set; }

        /// <summary>
        /// Generic data store, which some provisioning tools and cloud operating systems use as a configuration file. It is generally consumed only once after an instance has been launched, but individual needs may vary.
        /// </summary>
        [Input("userData")]
        public Input<string>? UserData { get; set; }

        public ServerArgs()
        {
        }
    }

    public sealed class ServerState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The server's allowed bandwidth usage in GB.
        /// </summary>
        [Input("allowedBandwidth")]
        public Input<string>? AllowedBandwidth { get; set; }

        /// <summary>
        /// The ID of the Vultr application to be installed on the server.
        /// </summary>
        [Input("appId")]
        public Input<int>? AppId { get; set; }

        /// <summary>
        /// Whether automatic backups will be enabled for this server (these have an extra charge associated with them).
        /// </summary>
        [Input("autoBackup")]
        public Input<bool>? AutoBackup { get; set; }

        /// <summary>
        /// The server's cost per month in USD.
        /// </summary>
        [Input("costPerMonth")]
        public Input<string>? CostPerMonth { get; set; }

        /// <summary>
        /// The server's current bandwidth usage in GB.
        /// </summary>
        [Input("currentBandwidth")]
        public Input<double>? CurrentBandwidth { get; set; }

        /// <summary>
        /// The date the server was added to your Vultr account.
        /// </summary>
        [Input("dateCreated")]
        public Input<string>? DateCreated { get; set; }

        /// <summary>
        /// Whether DDOS protection will be enabled on the server (there is an additional charge for this).
        /// </summary>
        [Input("ddosProtection")]
        public Input<bool>? DdosProtection { get; set; }

        /// <summary>
        /// The server's default password.
        /// </summary>
        [Input("defaultPassword")]
        public Input<string>? DefaultPassword { get; set; }

        /// <summary>
        /// The description of the disk(s) on the server.
        /// </summary>
        [Input("disk")]
        public Input<string>? Disk { get; set; }

        /// <summary>
        /// Whether the server has IPv6 networking activated.
        /// </summary>
        [Input("enableIpv6")]
        public Input<bool>? EnableIpv6 { get; set; }

        /// <summary>
        /// Whether the server has private networking support enabled.
        /// </summary>
        [Input("enablePrivateNetwork")]
        public Input<bool>? EnablePrivateNetwork { get; set; }

        /// <summary>
        /// The ID of the firewall group to assign to the server.
        /// </summary>
        [Input("firewallGroupId")]
        public Input<string>? FirewallGroupId { get; set; }

        /// <summary>
        /// The server's IPv4 gateway.
        /// </summary>
        [Input("gatewayV4")]
        public Input<string>? GatewayV4 { get; set; }

        /// <summary>
        /// The hostname to assign to the server.
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        /// <summary>
        /// The server's internal IP address.
        /// </summary>
        [Input("internalIp")]
        public Input<string>? InternalIp { get; set; }

        /// <summary>
        /// The ID of the ISO file to be installed on the server.
        /// </summary>
        [Input("isoId")]
        public Input<int>? IsoId { get; set; }

        /// <summary>
        /// The server's current KVM URL. This URL will change periodically. It is not advised to cache this value.
        /// </summary>
        [Input("kvmUrl")]
        public Input<string>? KvmUrl { get; set; }

        /// <summary>
        /// A label for the server.
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        /// <summary>
        /// The physical location of the server.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The server's main IP address.
        /// </summary>
        [Input("mainIp")]
        public Input<string>? MainIp { get; set; }

        /// <summary>
        /// The server's IPv4 netmask.
        /// </summary>
        [Input("netmaskV4")]
        public Input<string>? NetmaskV4 { get; set; }

        [Input("networkIds")]
        private InputList<string>? _networkIds;

        /// <summary>
        /// A list of private network IDs to be attached to the server.
        /// </summary>
        public InputList<string> NetworkIds
        {
            get => _networkIds ?? (_networkIds = new InputList<string>());
            set => _networkIds = value;
        }

        [Input("networkIps")]
        private InputMap<string>? _networkIps;
        public InputMap<string> NetworkIps
        {
            get => _networkIps ?? (_networkIps = new InputMap<string>());
            set => _networkIps = value;
        }

        [Input("networkMacs")]
        private InputMap<string>? _networkMacs;
        public InputMap<string> NetworkMacs
        {
            get => _networkMacs ?? (_networkMacs = new InputMap<string>());
            set => _networkMacs = value;
        }

        /// <summary>
        /// Whether an activation email will be sent when the server is ready.
        /// </summary>
        [Input("notifyActivate")]
        public Input<bool>? NotifyActivate { get; set; }

        /// <summary>
        /// The string description of the operating system installed on the server.
        /// </summary>
        [Input("os")]
        public Input<string>? Os { get; set; }

        /// <summary>
        /// The ID of the operating system to be installed on the server.
        /// </summary>
        [Input("osId")]
        public Input<int>? OsId { get; set; }

        /// <summary>
        /// Charges pending for this server's subscription in USD.
        /// </summary>
        [Input("pendingCharges")]
        public Input<string>? PendingCharges { get; set; }

        /// <summary>
        /// The ID of the plan that you want the server to subscribe to.
        /// </summary>
        [Input("planId")]
        public Input<int>? PlanId { get; set; }

        /// <summary>
        /// Whether the server is powered on or not.
        /// </summary>
        [Input("powerStatus")]
        public Input<string>? PowerStatus { get; set; }

        /// <summary>
        /// The amount of memory available on the server in MB.
        /// </summary>
        [Input("ram")]
        public Input<string>? Ram { get; set; }

        /// <summary>
        /// The ID of the region that the server is to be created in.
        /// </summary>
        [Input("regionId")]
        public Input<int>? RegionId { get; set; }

        /// <summary>
        /// IP address of the floating IP to use as the main IP of this server.
        /// </summary>
        [Input("reservedIp")]
        public Input<string>? ReservedIp { get; set; }

        /// <summary>
        /// The ID of the startup script you want added to the server.
        /// </summary>
        [Input("scriptId")]
        public Input<string>? ScriptId { get; set; }

        /// <summary>
        /// A more detailed server status (none, locked, installingbooting, isomounting, ok).
        /// </summary>
        [Input("serverState")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// The ID of the Vultr snapshot that the server will restore for the initial installation. 
        /// </summary>
        [Input("snapshotId")]
        public Input<string>? SnapshotId { get; set; }

        [Input("sshKeyIds")]
        private InputList<string>? _sshKeyIds;

        /// <summary>
        /// A list of SSH key IDs to apply to the server on install (only valid for Linux/FreeBSD).
        /// </summary>
        public InputList<string> SshKeyIds
        {
            get => _sshKeyIds ?? (_sshKeyIds = new InputList<string>());
            set => _sshKeyIds = value;
        }

        /// <summary>
        /// The status of the server's subscription.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// The tag to assign to the server.
        /// </summary>
        [Input("tag")]
        public Input<string>? Tag { get; set; }

        /// <summary>
        /// Generic data store, which some provisioning tools and cloud operating systems use as a configuration file. It is generally consumed only once after an instance has been launched, but individual needs may vary.
        /// </summary>
        [Input("userData")]
        public Input<string>? UserData { get; set; }

        [Input("v6Networks")]
        private InputList<ImmutableDictionary<string, object>>? _v6Networks;

        /// <summary>
        /// A list of the server's IPv6 networks.
        /// </summary>
        public InputList<ImmutableDictionary<string, object>> V6Networks
        {
            get => _v6Networks ?? (_v6Networks = new InputList<ImmutableDictionary<string, object>>());
            set => _v6Networks = value;
        }

        /// <summary>
        /// The number of virtual CPUs available on the server.
        /// </summary>
        [Input("vpsCpuCount")]
        public Input<string>? VpsCpuCount { get; set; }

        public ServerState()
        {
        }
    }
}
