// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Commercetools.Outputs
{

    [OutputType]
    public sealed class ApiExtensionDestination
    {
        public readonly string? AccessKey;
        public readonly string? AccessSecret;
        public readonly string? Arn;
        public readonly string? AuthorizationHeader;
        public readonly string? AzureAuthentication;
        public readonly string Type;
        public readonly string? Url;

        [OutputConstructor]
        private ApiExtensionDestination(
            string? accessKey,

            string? accessSecret,

            string? arn,

            string? authorizationHeader,

            string? azureAuthentication,

            string type,

            string? url)
        {
            AccessKey = accessKey;
            AccessSecret = accessSecret;
            Arn = arn;
            AuthorizationHeader = authorizationHeader;
            AzureAuthentication = azureAuthentication;
            Type = type;
            Url = url;
        }
    }
}