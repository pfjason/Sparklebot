# Org.OpenAPITools.Api.UsersApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteUserByIdApiV1UsersUserIdDelete**](UsersApi.md#deleteuserbyidapiv1usersuseriddelete) | **DELETE** /api/v1/users/{user_id} | Delete User By Id |
| [**GetActiveUsersApiV1UsersActiveGet**](UsersApi.md#getactiveusersapiv1usersactiveget) | **GET** /api/v1/users/active | Get Active Users |
| [**GetAllUsersApiV1UsersAllGet**](UsersApi.md#getallusersapiv1usersallget) | **GET** /api/v1/users/all | Get All Users |
| [**GetDefaultUserPermissionsApiV1UsersDefaultPermissionsGet**](UsersApi.md#getdefaultuserpermissionsapiv1usersdefaultpermissionsget) | **GET** /api/v1/users/default/permissions | Get Default User Permissions |
| [**GetUserActiveStatusByIdApiV1UsersUserIdActiveGet**](UsersApi.md#getuseractivestatusbyidapiv1usersuseridactiveget) | **GET** /api/v1/users/{user_id}/active | Get User Active Status By Id |
| [**GetUserByIdApiV1UsersUserIdGet**](UsersApi.md#getuserbyidapiv1usersuseridget) | **GET** /api/v1/users/{user_id} | Get User By Id |
| [**GetUserGroupsApiV1UsersGroupsGet**](UsersApi.md#getusergroupsapiv1usersgroupsget) | **GET** /api/v1/users/groups | Get User Groups |
| [**GetUserInfoBySessionUserApiV1UsersUserInfoGet**](UsersApi.md#getuserinfobysessionuserapiv1usersuserinfoget) | **GET** /api/v1/users/user/info | Get User Info By Session User |
| [**GetUserPermissisionsApiV1UsersPermissionsGet**](UsersApi.md#getuserpermissisionsapiv1userspermissionsget) | **GET** /api/v1/users/permissions | Get User Permissisions |
| [**GetUserSettingsBySessionUserApiV1UsersUserSettingsGet**](UsersApi.md#getusersettingsbysessionuserapiv1usersusersettingsget) | **GET** /api/v1/users/user/settings | Get User Settings By Session User |
| [**GetUsersApiV1UsersGet**](UsersApi.md#getusersapiv1usersget) | **GET** /api/v1/users/ | Get Users |
| [**UpdateDefaultUserPermissionsApiV1UsersDefaultPermissionsPost**](UsersApi.md#updatedefaultuserpermissionsapiv1usersdefaultpermissionspost) | **POST** /api/v1/users/default/permissions | Update Default User Permissions |
| [**UpdateUserByIdApiV1UsersUserIdUpdatePost**](UsersApi.md#updateuserbyidapiv1usersuseridupdatepost) | **POST** /api/v1/users/{user_id}/update | Update User By Id |
| [**UpdateUserInfoBySessionUserApiV1UsersUserInfoUpdatePost**](UsersApi.md#updateuserinfobysessionuserapiv1usersuserinfoupdatepost) | **POST** /api/v1/users/user/info/update | Update User Info By Session User |
| [**UpdateUserSettingsBySessionUserApiV1UsersUserSettingsUpdatePost**](UsersApi.md#updateusersettingsbysessionuserapiv1usersusersettingsupdatepost) | **POST** /api/v1/users/user/settings/update | Update User Settings By Session User |

<a id="deleteuserbyidapiv1usersuseriddelete"></a>
# **DeleteUserByIdApiV1UsersUserIdDelete**
> bool DeleteUserByIdApiV1UsersUserIdDelete (string userId)

Delete User By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |

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
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getactiveusersapiv1usersactiveget"></a>
# **GetActiveUsersApiV1UsersActiveGet**
> Object GetActiveUsersApiV1UsersActiveGet ()

Get Active Users

Get a list of active users.


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

<a id="getallusersapiv1usersallget"></a>
# **GetAllUsersApiV1UsersAllGet**
> UserListResponse GetAllUsersApiV1UsersAllGet ()

Get All Users


### Parameters
This endpoint does not need any parameter.
### Return type

[**UserListResponse**](UserListResponse.md)

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

<a id="getdefaultuserpermissionsapiv1usersdefaultpermissionsget"></a>
# **GetDefaultUserPermissionsApiV1UsersDefaultPermissionsGet**
> UserPermissions GetDefaultUserPermissionsApiV1UsersDefaultPermissionsGet ()

Get Default User Permissions


### Parameters
This endpoint does not need any parameter.
### Return type

[**UserPermissions**](UserPermissions.md)

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

<a id="getuseractivestatusbyidapiv1usersuseridactiveget"></a>
# **GetUserActiveStatusByIdApiV1UsersUserIdActiveGet**
> Object GetUserActiveStatusByIdApiV1UsersUserIdActiveGet (string userId)

Get User Active Status By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |

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
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getuserbyidapiv1usersuseridget"></a>
# **GetUserByIdApiV1UsersUserIdGet**
> OpenWebuiRoutersUsersUserResponse GetUserByIdApiV1UsersUserIdGet (string userId)

Get User By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |

### Return type

[**OpenWebuiRoutersUsersUserResponse**](OpenWebuiRoutersUsersUserResponse.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getusergroupsapiv1usersgroupsget"></a>
# **GetUserGroupsApiV1UsersGroupsGet**
> Object GetUserGroupsApiV1UsersGroupsGet ()

Get User Groups


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

<a id="getuserinfobysessionuserapiv1usersuserinfoget"></a>
# **GetUserInfoBySessionUserApiV1UsersUserInfoGet**
> Object GetUserInfoBySessionUserApiV1UsersUserInfoGet ()

Get User Info By Session User


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

<a id="getuserpermissisionsapiv1userspermissionsget"></a>
# **GetUserPermissisionsApiV1UsersPermissionsGet**
> Object GetUserPermissisionsApiV1UsersPermissionsGet ()

Get User Permissisions


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

<a id="getusersettingsbysessionuserapiv1usersusersettingsget"></a>
# **GetUserSettingsBySessionUserApiV1UsersUserSettingsGet**
> UserSettings GetUserSettingsBySessionUserApiV1UsersUserSettingsGet ()

Get User Settings By Session User


### Parameters
This endpoint does not need any parameter.
### Return type

[**UserSettings**](UserSettings.md)

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

<a id="getusersapiv1usersget"></a>
# **GetUsersApiV1UsersGet**
> UserListResponse GetUsersApiV1UsersGet (string query = null, string orderBy = null, string direction = null, int page = null)

Get Users


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** |  | [optional]  |
| **orderBy** | **string** |  | [optional]  |
| **direction** | **string** |  | [optional]  |
| **page** | **int** |  | [optional]  |

### Return type

[**UserListResponse**](UserListResponse.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatedefaultuserpermissionsapiv1usersdefaultpermissionspost"></a>
# **UpdateDefaultUserPermissionsApiV1UsersDefaultPermissionsPost**
> Object UpdateDefaultUserPermissionsApiV1UsersDefaultPermissionsPost (UserPermissions userPermissions)

Update Default User Permissions


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userPermissions** | [**UserPermissions**](UserPermissions.md) |  |  |

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

<a id="updateuserbyidapiv1usersuseridupdatepost"></a>
# **UpdateUserByIdApiV1UsersUserIdUpdatePost**
> UserModel UpdateUserByIdApiV1UsersUserIdUpdatePost (string userId, UserUpdateForm userUpdateForm)

Update User By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **userUpdateForm** | [**UserUpdateForm**](UserUpdateForm.md) |  |  |

### Return type

[**UserModel**](UserModel.md)

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

<a id="updateuserinfobysessionuserapiv1usersuserinfoupdatepost"></a>
# **UpdateUserInfoBySessionUserApiV1UsersUserInfoUpdatePost**
> Object UpdateUserInfoBySessionUserApiV1UsersUserInfoUpdatePost (Object body)

Update User Info By Session User


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  |  |

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

<a id="updateusersettingsbysessionuserapiv1usersusersettingsupdatepost"></a>
# **UpdateUserSettingsBySessionUserApiV1UsersUserSettingsUpdatePost**
> UserSettings UpdateUserSettingsBySessionUserApiV1UsersUserSettingsUpdatePost (UserSettings userSettings)

Update User Settings By Session User


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userSettings** | [**UserSettings**](UserSettings.md) |  |  |

### Return type

[**UserSettings**](UserSettings.md)

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

