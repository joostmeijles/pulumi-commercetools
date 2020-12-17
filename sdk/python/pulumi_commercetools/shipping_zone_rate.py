# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from . import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['ShippingZoneRate']


class ShippingZoneRate(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 free_above: Optional[pulumi.Input[pulumi.InputType['ShippingZoneRateFreeAboveArgs']]] = None,
                 price: Optional[pulumi.Input[pulumi.InputType['ShippingZoneRatePriceArgs']]] = None,
                 shipping_method_id: Optional[pulumi.Input[str]] = None,
                 shipping_zone_id: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Create a ShippingZoneRate resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['free_above'] = free_above
            if price is None:
                raise TypeError("Missing required property 'price'")
            __props__['price'] = price
            if shipping_method_id is None:
                raise TypeError("Missing required property 'shipping_method_id'")
            __props__['shipping_method_id'] = shipping_method_id
            if shipping_zone_id is None:
                raise TypeError("Missing required property 'shipping_zone_id'")
            __props__['shipping_zone_id'] = shipping_zone_id
        super(ShippingZoneRate, __self__).__init__(
            'commercetools:index/shippingZoneRate:ShippingZoneRate',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            free_above: Optional[pulumi.Input[pulumi.InputType['ShippingZoneRateFreeAboveArgs']]] = None,
            price: Optional[pulumi.Input[pulumi.InputType['ShippingZoneRatePriceArgs']]] = None,
            shipping_method_id: Optional[pulumi.Input[str]] = None,
            shipping_zone_id: Optional[pulumi.Input[str]] = None) -> 'ShippingZoneRate':
        """
        Get an existing ShippingZoneRate resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["free_above"] = free_above
        __props__["price"] = price
        __props__["shipping_method_id"] = shipping_method_id
        __props__["shipping_zone_id"] = shipping_zone_id
        return ShippingZoneRate(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="freeAbove")
    def free_above(self) -> pulumi.Output[Optional['outputs.ShippingZoneRateFreeAbove']]:
        return pulumi.get(self, "free_above")

    @property
    @pulumi.getter
    def price(self) -> pulumi.Output['outputs.ShippingZoneRatePrice']:
        return pulumi.get(self, "price")

    @property
    @pulumi.getter(name="shippingMethodId")
    def shipping_method_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "shipping_method_id")

    @property
    @pulumi.getter(name="shippingZoneId")
    def shipping_zone_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "shipping_zone_id")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

