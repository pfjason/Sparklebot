# Org.OpenAPITools.Api.AuthsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddUserApiV1AuthsAddPost**](AuthsApi.md#adduserapiv1authsaddpost) | **POST** /api/v1/auths/add | Add User |
| [**DeleteApiKeyApiV1AuthsApiKeyDelete**](AuthsApi.md#deleteapikeyapiv1authsapikeydelete) | **DELETE** /api/v1/auths/api_key | Delete Api Key |
| [**GenerateApiKeyApiV1AuthsApiKeyPost**](AuthsApi.md#generateapikeyapiv1authsapikeypost) | **POST** /api/v1/auths/api_key | Generate Api Key |
| [**GetAdminConfigApiV1AuthsAdminConfigGet**](AuthsApi.md#getadminconfigapiv1authsadminconfigget) | **GET** /api/v1/auths/admin/config | Get Admin Config |
| [**GetAdminDetailsApiV1AuthsAdminDetailsGet**](AuthsApi.md#getadmindetailsapiv1authsadmindetailsget) | **GET** /api/v1/auths/admin/details | Get Admin Details |
| [**GetApiKeyApiV1AuthsApiKeyGet**](AuthsApi.md#getapikeyapiv1authsapikeyget) | **GET** /api/v1/auths/api_key | Get Api Key |
| [**GetLdapConfigApiV1AuthsAdminConfigLdapGet**](AuthsApi.md#getldapconfigapiv1authsadminconfigldapget) | **GET** /api/v1/auths/admin/config/ldap | Get Ldap Config |
| [**GetLdapServerApiV1AuthsAdminConfigLdapServerGet**](AuthsApi.md#getldapserverapiv1authsadminconfigldapserverget) | **GET** /api/v1/auths/admin/config/ldap/server | Get Ldap Server |
| [**GetSessionUserApiV1AuthsGet**](AuthsApi.md#getsessionuserapiv1authsget) | **GET** /api/v1/auths/ | Get Session User |
| [**LdapAuthApiV1AuthsLdapPost**](AuthsApi.md#ldapauthapiv1authsldappost) | **POST** /api/v1/auths/ldap | Ldap Auth |
| [**SigninApiV1AuthsSigninPost**](AuthsApi.md#signinapiv1authssigninpost) | **POST** /api/v1/auths/signin | Signin |
| [**SignoutApiV1AuthsSignoutGet**](AuthsApi.md#signoutapiv1authssignoutget) | **GET** /api/v1/auths/signout | Signout |
| [**SignupApiV1AuthsSignupPost**](AuthsApi.md#signupapiv1authssignuppost) | **POST** /api/v1/auths/signup | Signup |
| [**UpdateAdminConfigApiV1AuthsAdminConfigPost**](AuthsApi.md#updateadminconfigapiv1authsadminconfigpost) | **POST** /api/v1/auths/admin/config | Update Admin Config |
| [**UpdateLdapConfigApiV1AuthsAdminConfigLdapPost**](AuthsApi.md#updateldapconfigapiv1authsadminconfigldappost) | **POST** /api/v1/auths/admin/config/ldap | Update Ldap Config |
| [**UpdateLdapServerApiV1AuthsAdminConfigLdapServerPost**](AuthsApi.md#updateldapserverapiv1authsadminconfigldapserverpost) | **POST** /api/v1/auths/admin/config/ldap/server | Update Ldap Server |
| [**UpdatePasswordApiV1AuthsUpdatePasswordPost**](AuthsApi.md#updatepasswordapiv1authsupdatepasswordpost) | **POST** /api/v1/auths/update/password | Update Password |
| [**UpdateProfileApiV1AuthsUpdateProfilePost**](AuthsApi.md#updateprofileapiv1authsupdateprofilepost) | **POST** /api/v1/auths/update/profile | Update Profile |

<a id="adduserapiv1authsaddpost"></a>
# **AddUserApiV1AuthsAddPost**
> SigninResponse AddUserApiV1AuthsAddPost (AddUserForm addUserForm)

Add User


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addUserForm** | [**AddUserForm**](AddUserForm.md) |  |  |

### Return type

[**SigninResponse**](SigninResponse.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteapikeyapiv1authsapikeydelete"></a>
# **DeleteApiKeyApiV1AuthsApiKeyDelete**
> bool DeleteApiKeyApiV1AuthsApiKeyDelete ()

Delete Api Key


### Parameters
This endpoint does not need any parameter.
### Return type

**bool**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="generateapikeyapiv1authsapikeypost"></a>
# **GenerateApiKeyApiV1AuthsApiKeyPost**
> ApiKey GenerateApiKeyApiV1AuthsApiKeyPost ()

Generate Api Key


### Parameters
This endpoint does not need any parameter.
### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getadminconfigapiv1authsadminconfigget"></a>
# **GetAdminConfigApiV1AuthsAdminConfigGet**
> Object GetAdminConfigApiV1AuthsAdminConfigGet ()

Get Admin Config


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getadmindetailsapiv1authsadmindetailsget"></a>
# **GetAdminDetailsApiV1AuthsAdminDetailsGet**
> Object GetAdminDetailsApiV1AuthsAdminDetailsGet ()

Get Admin Details


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getapikeyapiv1authsapikeyget"></a>
# **GetApiKeyApiV1AuthsApiKeyGet**
> ApiKey GetApiKeyApiV1AuthsApiKeyGet ()

Get Api Key


### Parameters
This endpoint does not need any parameter.
### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getldapconfigapiv1authsadminconfigldapget"></a>
# **GetLdapConfigApiV1AuthsAdminConfigLdapGet**
> Object GetLdapConfigApiV1AuthsAdminConfigLdapGet ()

Get Ldap Config


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getldapserverapiv1authsadminconfigldapserverget"></a>
# **GetLdapServerApiV1AuthsAdminConfigLdapServerGet**
> LdapServerConfig GetLdapServerApiV1AuthsAdminConfigLdapServerGet ()

Get Ldap Server


### Parameters
This endpoint does not need any parameter.
### Return type

[**LdapServerConfig**](LdapServerConfig.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsessionuserapiv1authsget"></a>
# **GetSessionUserApiV1AuthsGet**
> SessionUserResponse GetSessionUserApiV1AuthsGet ()

Get Session User


### Parameters
This endpoint does not need any parameter.
### Return type

[**SessionUserResponse**](SessionUserResponse.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="ldapauthapiv1authsldappost"></a>
# **LdapAuthApiV1AuthsLdapPost**
> SessionUserResponse LdapAuthApiV1AuthsLdapPost (LdapForm ldapForm)

Ldap Auth


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ldapForm** | [**LdapForm**](LdapForm.md) |  |  |

### Return type

[**SessionUserResponse**](SessionUserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="signinapiv1authssigninpost"></a>
# **SigninApiV1AuthsSigninPost**
> SessionUserResponse SigninApiV1AuthsSigninPost (SigninForm signinForm)

Signin


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signinForm** | [**SigninForm**](SigninForm.md) |  |  |

### Return type

[**SessionUserResponse**](SessionUserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="signoutapiv1authssignoutget"></a>
# **SignoutApiV1AuthsSignoutGet**
> Object SignoutApiV1AuthsSignoutGet ()

Signout


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="signupapiv1authssignuppost"></a>
# **SignupApiV1AuthsSignupPost**
> SessionUserResponse SignupApiV1AuthsSignupPost (SignupForm signupForm)

Signup


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signupForm** | [**SignupForm**](SignupForm.md) |  |  |

### Return type

[**SessionUserResponse**](SessionUserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateadminconfigapiv1authsadminconfigpost"></a>
# **UpdateAdminConfigApiV1AuthsAdminConfigPost**
> Object UpdateAdminConfigApiV1AuthsAdminConfigPost (AdminConfig adminConfig)

Update Admin Config


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **adminConfig** | [**AdminConfig**](AdminConfig.md) |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateldapconfigapiv1authsadminconfigldappost"></a>
# **UpdateLdapConfigApiV1AuthsAdminConfigLdapPost**
> Object UpdateLdapConfigApiV1AuthsAdminConfigLdapPost (LdapConfigForm ldapConfigForm)

Update Ldap Config


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ldapConfigForm** | [**LdapConfigForm**](LdapConfigForm.md) |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateldapserverapiv1authsadminconfigldapserverpost"></a>
# **UpdateLdapServerApiV1AuthsAdminConfigLdapServerPost**
> Object UpdateLdapServerApiV1AuthsAdminConfigLdapServerPost (LdapServerConfig ldapServerConfig)

Update Ldap Server


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ldapServerConfig** | [**LdapServerConfig**](LdapServerConfig.md) |  |  |

### Return type

**Object**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatepasswordapiv1authsupdatepasswordpost"></a>
# **UpdatePasswordApiV1AuthsUpdatePasswordPost**
> bool UpdatePasswordApiV1AuthsUpdatePasswordPost (UpdatePasswordForm updatePasswordForm)

Update Password


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updatePasswordForm** | [**UpdatePasswordForm**](UpdatePasswordForm.md) |  |  |

### Return type

**bool**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateprofileapiv1authsupdateprofilepost"></a>
# **UpdateProfileApiV1AuthsUpdateProfilePost**
> OpenWebuiModelsAuthsUserResponse UpdateProfileApiV1AuthsUpdateProfilePost (UpdateProfileForm updateProfileForm)

Update Profile


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateProfileForm** | [**UpdateProfileForm**](UpdateProfileForm.md) |  |  |

### Return type

[**OpenWebuiModelsAuthsUserResponse**](OpenWebuiModelsAuthsUserResponse.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

