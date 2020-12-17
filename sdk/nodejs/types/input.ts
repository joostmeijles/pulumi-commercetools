// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

export interface ApiExtensionDestination {
    accessKey?: pulumi.Input<string>;
    accessSecret?: pulumi.Input<string>;
    arn?: pulumi.Input<string>;
    authorizationHeader?: pulumi.Input<string>;
    azureAuthentication?: pulumi.Input<string>;
    type: pulumi.Input<string>;
    url?: pulumi.Input<string>;
}

export interface ApiExtensionTrigger {
    actions: pulumi.Input<pulumi.Input<string>[]>;
    resourceTypeId: pulumi.Input<string>;
}

export interface CartDiscountTarget {
    predicate?: pulumi.Input<string>;
    type: pulumi.Input<string>;
}

export interface CartDiscountValue {
    distributionChannelId?: pulumi.Input<string>;
    monies?: pulumi.Input<pulumi.Input<inputs.CartDiscountValueMoney>[]>;
    permyriad?: pulumi.Input<number>;
    productId?: pulumi.Input<string>;
    supplyChannelId?: pulumi.Input<string>;
    type: pulumi.Input<string>;
    variant?: pulumi.Input<number>;
}

export interface CartDiscountValueMoney {
    centAmount: pulumi.Input<number>;
    currencyCode: pulumi.Input<string>;
}

export interface ProductTypeAttribute {
    constraint?: pulumi.Input<string>;
    inputHint?: pulumi.Input<string>;
    inputTip?: pulumi.Input<{[key: string]: any}>;
    label: pulumi.Input<{[key: string]: any}>;
    name: pulumi.Input<string>;
    required?: pulumi.Input<boolean>;
    searchable?: pulumi.Input<boolean>;
    type: pulumi.Input<inputs.ProductTypeAttributeType>;
}

export interface ProductTypeAttributeType {
    ElementType2?: pulumi.Input<inputs.ProductTypeAttributeTypeElementType2>;
    localizedValues?: pulumi.Input<pulumi.Input<inputs.ProductTypeAttributeTypeLocalizedValue>[]>;
    name: pulumi.Input<string>;
    referenceTypeId?: pulumi.Input<string>;
    typeReference?: pulumi.Input<string>;
    values?: pulumi.Input<{[key: string]: any}>;
}

export interface ProductTypeAttributeTypeElementType2 {
    localizedValues?: pulumi.Input<pulumi.Input<inputs.ProductTypeAttributeTypeElementType2LocalizedValue>[]>;
    name: pulumi.Input<string>;
    referenceTypeId?: pulumi.Input<string>;
    typeReference?: pulumi.Input<string>;
    values?: pulumi.Input<{[key: string]: any}>;
}

export interface ProductTypeAttributeTypeElementType2LocalizedValue {
    key: pulumi.Input<string>;
    label: pulumi.Input<{[key: string]: any}>;
}

export interface ProductTypeAttributeTypeLocalizedValue {
    key: pulumi.Input<string>;
    label: pulumi.Input<{[key: string]: any}>;
}

export interface ProjectSettingsExternalOauth {
    authorizationHeader: pulumi.Input<string>;
    url: pulumi.Input<string>;
}

export interface ProjectSettingsMessages {
    enabled: pulumi.Input<boolean>;
}

export interface ShippingZoneLocation {
    country: pulumi.Input<string>;
    state?: pulumi.Input<string>;
}

export interface ShippingZoneRateFreeAbove {
    centAmount: pulumi.Input<number>;
    currencyCode: pulumi.Input<string>;
}

export interface ShippingZoneRatePrice {
    centAmount: pulumi.Input<number>;
    currencyCode: pulumi.Input<string>;
}

export interface SubscriptionChange {
    resourceTypeIds?: pulumi.Input<pulumi.Input<string>[]>;
}

export interface SubscriptionDestination {
    accessKey?: pulumi.Input<string>;
    accessSecret?: pulumi.Input<string>;
    connectionString?: pulumi.Input<string>;
    projectId?: pulumi.Input<string>;
    queueUrl?: pulumi.Input<string>;
    region: pulumi.Input<string>;
    topic?: pulumi.Input<string>;
    topicArn?: pulumi.Input<string>;
    type: pulumi.Input<string>;
    uri: pulumi.Input<string>;
}

export interface SubscriptionFormat {
    cloudEventsVersion?: pulumi.Input<string>;
    type: pulumi.Input<string>;
}

export interface SubscriptionMessage {
    resourceTypeId?: pulumi.Input<string>;
    types?: pulumi.Input<pulumi.Input<string>[]>;
}

export interface TaxCategoryRateSubRate {
    amount: pulumi.Input<number>;
    name: pulumi.Input<string>;
}

export interface TypeField {
    inputHint?: pulumi.Input<string>;
    label: pulumi.Input<{[key: string]: any}>;
    name: pulumi.Input<string>;
    required?: pulumi.Input<boolean>;
    type: pulumi.Input<inputs.TypeFieldType>;
}

export interface TypeFieldType {
    ElementType2?: pulumi.Input<inputs.TypeFieldTypeElementType2>;
    localizedValues?: pulumi.Input<pulumi.Input<inputs.TypeFieldTypeLocalizedValue>[]>;
    name: pulumi.Input<string>;
    referenceTypeId?: pulumi.Input<string>;
    values?: pulumi.Input<{[key: string]: any}>;
}

export interface TypeFieldTypeElementType2 {
    localizedValues?: pulumi.Input<pulumi.Input<inputs.TypeFieldTypeElementType2LocalizedValue>[]>;
    name: pulumi.Input<string>;
    referenceTypeId?: pulumi.Input<string>;
    values?: pulumi.Input<{[key: string]: any}>;
}

export interface TypeFieldTypeElementType2LocalizedValue {
    key: pulumi.Input<string>;
    label: pulumi.Input<{[key: string]: any}>;
}

export interface TypeFieldTypeLocalizedValue {
    key: pulumi.Input<string>;
    label: pulumi.Input<{[key: string]: any}>;
}