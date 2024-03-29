// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Get information about a Vultr SSH key. This data source provides the name, public SSH key, and the creation date for your Vultr SSH key.
 * 
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-vultr/blob/master/website/docs/d/ssh_key.html.markdown.
 */
export function getSshKey(args?: GetSshKeyArgs, opts?: pulumi.InvokeOptions): Promise<GetSshKeyResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("vultr:index/getSshKey:getSshKey", {
        "filters": args.filters,
    }, opts);
}

/**
 * A collection of arguments for invoking getSshKey.
 */
export interface GetSshKeyArgs {
    /**
     * Query parameters for finding SSH keys.
     */
    readonly filters?: inputs.GetSshKeyFilter[];
}

/**
 * A collection of values returned by getSshKey.
 */
export interface GetSshKeyResult {
    /**
     * The date the SSH key was added to your Vultr account.
     */
    readonly dateCreated: string;
    readonly filters?: outputs.GetSshKeyFilter[];
    /**
     * The name of the SSH key.
     */
    readonly name: string;
    /**
     * The public SSH key.
     */
    readonly sshKey: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
