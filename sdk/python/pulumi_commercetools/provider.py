# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['ProviderArgs', 'Provider']

@pulumi.input_type
class ProviderArgs:
    def __init__(__self__, *,
                 api_url: pulumi.Input[str],
                 client_id: pulumi.Input[str],
                 client_secret: pulumi.Input[str],
                 project_key: pulumi.Input[str],
                 scopes: pulumi.Input[str],
                 token_url: pulumi.Input[str]):
        """
        The set of arguments for constructing a Provider resource.
        :param pulumi.Input[str] api_url: The API URL of the commercetools platform. https://docs.commercetools.com/http-api
        :param pulumi.Input[str] client_id: The OAuth Client ID for a commercetools platform project. https://docs.commercetools.com/http-api-authorization
        :param pulumi.Input[str] client_secret: The OAuth Client Secret for a commercetools platform project. https://docs.commercetools.com/http-api-authorization
        :param pulumi.Input[str] project_key: The project key of commercetools platform project. https://docs.commercetools.com/getting-started
        :param pulumi.Input[str] scopes: A list as string of OAuth scopes assigned to a project key, to access resources in a commercetools platform project.
               https://docs.commercetools.com/http-api-authorization
        :param pulumi.Input[str] token_url: The authentication URL of the commercetools platform. https://docs.commercetools.com/http-api-authorization
        """
        pulumi.set(__self__, "api_url", api_url)
        pulumi.set(__self__, "client_id", client_id)
        pulumi.set(__self__, "client_secret", client_secret)
        pulumi.set(__self__, "project_key", project_key)
        pulumi.set(__self__, "scopes", scopes)
        pulumi.set(__self__, "token_url", token_url)

    @property
    @pulumi.getter(name="apiUrl")
    def api_url(self) -> pulumi.Input[str]:
        """
        The API URL of the commercetools platform. https://docs.commercetools.com/http-api
        """
        return pulumi.get(self, "api_url")

    @api_url.setter
    def api_url(self, value: pulumi.Input[str]):
        pulumi.set(self, "api_url", value)

    @property
    @pulumi.getter(name="clientId")
    def client_id(self) -> pulumi.Input[str]:
        """
        The OAuth Client ID for a commercetools platform project. https://docs.commercetools.com/http-api-authorization
        """
        return pulumi.get(self, "client_id")

    @client_id.setter
    def client_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "client_id", value)

    @property
    @pulumi.getter(name="clientSecret")
    def client_secret(self) -> pulumi.Input[str]:
        """
        The OAuth Client Secret for a commercetools platform project. https://docs.commercetools.com/http-api-authorization
        """
        return pulumi.get(self, "client_secret")

    @client_secret.setter
    def client_secret(self, value: pulumi.Input[str]):
        pulumi.set(self, "client_secret", value)

    @property
    @pulumi.getter(name="projectKey")
    def project_key(self) -> pulumi.Input[str]:
        """
        The project key of commercetools platform project. https://docs.commercetools.com/getting-started
        """
        return pulumi.get(self, "project_key")

    @project_key.setter
    def project_key(self, value: pulumi.Input[str]):
        pulumi.set(self, "project_key", value)

    @property
    @pulumi.getter
    def scopes(self) -> pulumi.Input[str]:
        """
        A list as string of OAuth scopes assigned to a project key, to access resources in a commercetools platform project.
        https://docs.commercetools.com/http-api-authorization
        """
        return pulumi.get(self, "scopes")

    @scopes.setter
    def scopes(self, value: pulumi.Input[str]):
        pulumi.set(self, "scopes", value)

    @property
    @pulumi.getter(name="tokenUrl")
    def token_url(self) -> pulumi.Input[str]:
        """
        The authentication URL of the commercetools platform. https://docs.commercetools.com/http-api-authorization
        """
        return pulumi.get(self, "token_url")

    @token_url.setter
    def token_url(self, value: pulumi.Input[str]):
        pulumi.set(self, "token_url", value)


class Provider(pulumi.ProviderResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 api_url: Optional[pulumi.Input[str]] = None,
                 client_id: Optional[pulumi.Input[str]] = None,
                 client_secret: Optional[pulumi.Input[str]] = None,
                 project_key: Optional[pulumi.Input[str]] = None,
                 scopes: Optional[pulumi.Input[str]] = None,
                 token_url: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        The provider type for the commercetools package. By default, resources use package-wide configuration
        settings, however an explicit `Provider` instance may be created and passed during resource
        construction to achieve fine-grained programmatic control over provider settings. See the
        [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] api_url: The API URL of the commercetools platform. https://docs.commercetools.com/http-api
        :param pulumi.Input[str] client_id: The OAuth Client ID for a commercetools platform project. https://docs.commercetools.com/http-api-authorization
        :param pulumi.Input[str] client_secret: The OAuth Client Secret for a commercetools platform project. https://docs.commercetools.com/http-api-authorization
        :param pulumi.Input[str] project_key: The project key of commercetools platform project. https://docs.commercetools.com/getting-started
        :param pulumi.Input[str] scopes: A list as string of OAuth scopes assigned to a project key, to access resources in a commercetools platform project.
               https://docs.commercetools.com/http-api-authorization
        :param pulumi.Input[str] token_url: The authentication URL of the commercetools platform. https://docs.commercetools.com/http-api-authorization
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ProviderArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        The provider type for the commercetools package. By default, resources use package-wide configuration
        settings, however an explicit `Provider` instance may be created and passed during resource
        construction to achieve fine-grained programmatic control over provider settings. See the
        [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.

        :param str resource_name: The name of the resource.
        :param ProviderArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ProviderArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 api_url: Optional[pulumi.Input[str]] = None,
                 client_id: Optional[pulumi.Input[str]] = None,
                 client_secret: Optional[pulumi.Input[str]] = None,
                 project_key: Optional[pulumi.Input[str]] = None,
                 scopes: Optional[pulumi.Input[str]] = None,
                 token_url: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ProviderArgs.__new__(ProviderArgs)

            if api_url is None and not opts.urn:
                raise TypeError("Missing required property 'api_url'")
            __props__.__dict__["api_url"] = api_url
            if client_id is None and not opts.urn:
                raise TypeError("Missing required property 'client_id'")
            __props__.__dict__["client_id"] = client_id
            if client_secret is None and not opts.urn:
                raise TypeError("Missing required property 'client_secret'")
            __props__.__dict__["client_secret"] = client_secret
            if project_key is None and not opts.urn:
                raise TypeError("Missing required property 'project_key'")
            __props__.__dict__["project_key"] = project_key
            if scopes is None and not opts.urn:
                raise TypeError("Missing required property 'scopes'")
            __props__.__dict__["scopes"] = scopes
            if token_url is None and not opts.urn:
                raise TypeError("Missing required property 'token_url'")
            __props__.__dict__["token_url"] = token_url
        super(Provider, __self__).__init__(
            'commercetools',
            resource_name,
            __props__,
            opts)

    @property
    @pulumi.getter(name="apiUrl")
    def api_url(self) -> pulumi.Output[str]:
        """
        The API URL of the commercetools platform. https://docs.commercetools.com/http-api
        """
        return pulumi.get(self, "api_url")

    @property
    @pulumi.getter(name="clientId")
    def client_id(self) -> pulumi.Output[str]:
        """
        The OAuth Client ID for a commercetools platform project. https://docs.commercetools.com/http-api-authorization
        """
        return pulumi.get(self, "client_id")

    @property
    @pulumi.getter(name="clientSecret")
    def client_secret(self) -> pulumi.Output[str]:
        """
        The OAuth Client Secret for a commercetools platform project. https://docs.commercetools.com/http-api-authorization
        """
        return pulumi.get(self, "client_secret")

    @property
    @pulumi.getter(name="projectKey")
    def project_key(self) -> pulumi.Output[str]:
        """
        The project key of commercetools platform project. https://docs.commercetools.com/getting-started
        """
        return pulumi.get(self, "project_key")

    @property
    @pulumi.getter
    def scopes(self) -> pulumi.Output[str]:
        """
        A list as string of OAuth scopes assigned to a project key, to access resources in a commercetools platform project.
        https://docs.commercetools.com/http-api-authorization
        """
        return pulumi.get(self, "scopes")

    @property
    @pulumi.getter(name="tokenUrl")
    def token_url(self) -> pulumi.Output[str]:
        """
        The authentication URL of the commercetools platform. https://docs.commercetools.com/http-api-authorization
        """
        return pulumi.get(self, "token_url")

