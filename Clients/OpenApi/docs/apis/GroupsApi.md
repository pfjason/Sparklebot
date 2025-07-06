# Org.OpenAPITools.Api.GroupsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewGroupApiV1GroupsCreatePost**](GroupsApi.md#createnewgroupapiv1groupscreatepost) | **POST** /api/v1/groups/create | Create New Group |
| [**DeleteGroupByIdApiV1GroupsIdIdDeleteDelete**](GroupsApi.md#deletegroupbyidapiv1groupsididdeletedelete) | **DELETE** /api/v1/groups/id/{id}/delete | Delete Group By Id |
| [**GetGroupByIdApiV1GroupsIdIdGet**](GroupsApi.md#getgroupbyidapiv1groupsididget) | **GET** /api/v1/groups/id/{id} | Get Group By Id |
| [**GetGroupsApiV1GroupsGet**](GroupsApi.md#getgroupsapiv1groupsget) | **GET** /api/v1/groups/ | Get Groups |
| [**UpdateGroupByIdApiV1GroupsIdIdUpdatePost**](GroupsApi.md#updategroupbyidapiv1groupsididupdatepost) | **POST** /api/v1/groups/id/{id}/update | Update Group By Id |

<a id="createnewgroupapiv1groupscreatepost"></a>
# **CreateNewGroupApiV1GroupsCreatePost**
> GroupResponse CreateNewGroupApiV1GroupsCreatePost (GroupForm groupForm)

Create New Group


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupForm** | [**GroupForm**](GroupForm.md) |  |  |

### Return type

[**GroupResponse**](GroupResponse.md)

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

<a id="deletegroupbyidapiv1groupsididdeletedelete"></a>
# **DeleteGroupByIdApiV1GroupsIdIdDeleteDelete**
> bool DeleteGroupByIdApiV1GroupsIdIdDeleteDelete (string id)

Delete Group By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

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

<a id="getgroupbyidapiv1groupsididget"></a>
# **GetGroupByIdApiV1GroupsIdIdGet**
> GroupResponse GetGroupByIdApiV1GroupsIdIdGet (string id)

Get Group By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**GroupResponse**](GroupResponse.md)

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

<a id="getgroupsapiv1groupsget"></a>
# **GetGroupsApiV1GroupsGet**
> List&lt;GroupResponse&gt; GetGroupsApiV1GroupsGet ()

Get Groups


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;GroupResponse&gt;**](GroupResponse.md)

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

<a id="updategroupbyidapiv1groupsididupdatepost"></a>
# **UpdateGroupByIdApiV1GroupsIdIdUpdatePost**
> GroupResponse UpdateGroupByIdApiV1GroupsIdIdUpdatePost (string id, GroupUpdateForm groupUpdateForm)

Update Group By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **groupUpdateForm** | [**GroupUpdateForm**](GroupUpdateForm.md) |  |  |

### Return type

[**GroupResponse**](GroupResponse.md)

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

