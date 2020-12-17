# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from .. import _utilities, _tables

__all__ = [
    'api_url',
    'client_id',
    'client_secret',
    'project_key',
    'scopes',
    'token_url',
]

__config__ = pulumi.Config('commercetools')

api_url = __config__.get('apiUrl')
"""
The API URL of the commercetools platform. https://docs.commercetools.com/http-api
"""

client_id = __config__.get('clientId')
"""
The OAuth Client ID for a commercetools platform project. https://docs.commercetools.com/http-api-authorization
"""

client_secret = __config__.get('clientSecret')
"""
The OAuth Client Secret for a commercetools platform project. https://docs.commercetools.com/http-api-authorization
"""

project_key = __config__.get('projectKey')
"""
The project key of commercetools platform project. https://docs.commercetools.com/getting-started
"""

scopes = __config__.get('scopes')
"""
A list as string of OAuth scopes assigned to a project key, to access resources in a commercetools platform project.
https://docs.commercetools.com/http-api-authorization
"""

token_url = __config__.get('tokenUrl')
"""
The authentication URL of the commercetools platform. https://docs.commercetools.com/http-api-authorization
"""

