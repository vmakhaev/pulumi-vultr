// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Get information about a Vultr server.
 * 
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-vultr/blob/master/website/docs/d/server.html.markdown.
 */
export function getServer(args?: GetServerArgs, opts?: pulumi.InvokeOptions): Promise<GetServerResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("vultr:index/getServer:getServer", {
        "filters": args.filters,
    }, opts);
}

/**
 * A collection of arguments for invoking getServer.
 */
export interface GetServerArgs {
    /**
     * Query parameters for finding servers.
     */
    readonly filters?: inputs.GetServerFilter[];
}

/**
 * A collection of values returned by getServer.
 */
export interface GetServerResult {
    /**
     * The server's allowed bandwidth usage in GB.
     */
    readonly allowedBandwidth: string;
    /**
     * The server's application ID.
     */
    readonly appId: string;
    /**
     * Whether auto backups are enabled on this server.
     */
    readonly autoBackups: string;
    /**
     * The server's cost per month in USD.
     */
    readonly costPerMonth: string;
    /**
     * The server's current bandwidth usage in GB.
     */
    readonly currentBandwidth: number;
    /**
     * The date the server was added to your Vultr account.
     */
    readonly dateCreated: string;
    /**
     * The server's default password.
     */
    readonly defaultPassword: string;
    /**
     * The description of the disk(s) on the server.
     */
    readonly disk: string;
    readonly filters?: outputs.GetServerFilter[];
    /**
     * The ID of the firewall group applied to this server.
     */
    readonly firewallGroupId: string;
    /**
     * The server's IPv4 gateway.
     */
    readonly gatewayV4: string;
    /**
     * The server's internal IP address.
     */
    readonly internalIp: string;
    /**
     * The server's current KVM URL. This URL will change periodically. It is not advised to cache this value.
     */
    readonly kvmUrl: string;
    /**
     * The server's label.
     */
    readonly label: string;
    /**
     * The physical location of the server.
     */
    readonly location: string;
    /**
     * The server's main IP address.
     */
    readonly mainIp: string;
    /**
     * The server's IPv4 netmask.
     */
    readonly netmaskV4: string;
    /**
     * The operating system of the server.
     */
    readonly os: string;
    /**
     * The server's operating system ID.
     */
    readonly osId: string;
    /**
     * Charges pending for this server's subscription in USD.
     */
    readonly pendingCharges: string;
    /**
     * The server's plan ID.
     */
    readonly planId: string;
    /**
     * Whether the server is powered on or not.
     */
    readonly powerStatus: string;
    /**
     * The amount of memory available on the server in MB.
     */
    readonly ram: string;
    /**
     * The region ID (`DCID` in the Vultr API) of the server.
     */
    readonly regionId: string;
    /**
     * A more detailed server status (none, locked, installingbooting, isomounting, ok).
     */
    readonly serverState: string;
    /**
     * The status of the server's subscription.
     */
    readonly status: string;
    /**
     * The server's tag.
     */
    readonly tag: string;
    /**
     * A list of the server's IPv6 networks.
     */
    readonly v6Networks: {[key: string]: any}[];
    /**
     * The number of virtual CPUs available on the server.
     */
    readonly vpsCpuCount: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
