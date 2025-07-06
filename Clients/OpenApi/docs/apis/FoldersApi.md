# Org.OpenAPITools.Api.FoldersApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateFolderApiV1FoldersPost**](FoldersApi.md#createfolderapiv1folderspost) | **POST** /api/v1/folders/ | Create Folder |
| [**DeleteFolderByIdApiV1FoldersIdDelete**](FoldersApi.md#deletefolderbyidapiv1foldersiddelete) | **DELETE** /api/v1/folders/{id} | Delete Folder By Id |
| [**GetFolderByIdApiV1FoldersIdGet**](FoldersApi.md#getfolderbyidapiv1foldersidget) | **GET** /api/v1/folders/{id} | Get Folder By Id |
| [**GetFoldersApiV1FoldersGet**](FoldersApi.md#getfoldersapiv1foldersget) | **GET** /api/v1/folders/ | Get Folders |
| [**UpdateFolderIsExpandedByIdApiV1FoldersIdUpdateExpandedPost**](FoldersApi.md#updatefolderisexpandedbyidapiv1foldersidupdateexpandedpost) | **POST** /api/v1/folders/{id}/update/expanded | Update Folder Is Expanded By Id |
| [**UpdateFolderNameByIdApiV1FoldersIdUpdatePost**](FoldersApi.md#updatefoldernamebyidapiv1foldersidupdatepost) | **POST** /api/v1/folders/{id}/update | Update Folder Name By Id |
| [**UpdateFolderParentIdByIdApiV1FoldersIdUpdateParentPost**](FoldersApi.md#updatefolderparentidbyidapiv1foldersidupdateparentpost) | **POST** /api/v1/folders/{id}/update/parent | Update Folder Parent Id By Id |

<a id="createfolderapiv1folderspost"></a>
# **CreateFolderApiV1FoldersPost**
> Object CreateFolderApiV1FoldersPost (FolderForm folderForm)

Create Folder


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderForm** | [**FolderForm**](FolderForm.md) |  |  |

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

<a id="deletefolderbyidapiv1foldersiddelete"></a>
# **DeleteFolderByIdApiV1FoldersIdDelete**
> Object DeleteFolderByIdApiV1FoldersIdDelete (string id)

Delete Folder By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

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

<a id="getfolderbyidapiv1foldersidget"></a>
# **GetFolderByIdApiV1FoldersIdGet**
> FolderModel GetFolderByIdApiV1FoldersIdGet (string id)

Get Folder By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**FolderModel**](FolderModel.md)

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

<a id="getfoldersapiv1foldersget"></a>
# **GetFoldersApiV1FoldersGet**
> List&lt;FolderModel&gt; GetFoldersApiV1FoldersGet ()

Get Folders


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;FolderModel&gt;**](FolderModel.md)

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

<a id="updatefolderisexpandedbyidapiv1foldersidupdateexpandedpost"></a>
# **UpdateFolderIsExpandedByIdApiV1FoldersIdUpdateExpandedPost**
> Object UpdateFolderIsExpandedByIdApiV1FoldersIdUpdateExpandedPost (string id, FolderIsExpandedForm folderIsExpandedForm)

Update Folder Is Expanded By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **folderIsExpandedForm** | [**FolderIsExpandedForm**](FolderIsExpandedForm.md) |  |  |

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

<a id="updatefoldernamebyidapiv1foldersidupdatepost"></a>
# **UpdateFolderNameByIdApiV1FoldersIdUpdatePost**
> Object UpdateFolderNameByIdApiV1FoldersIdUpdatePost (string id, FolderForm folderForm)

Update Folder Name By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **folderForm** | [**FolderForm**](FolderForm.md) |  |  |

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

<a id="updatefolderparentidbyidapiv1foldersidupdateparentpost"></a>
# **UpdateFolderParentIdByIdApiV1FoldersIdUpdateParentPost**
> Object UpdateFolderParentIdByIdApiV1FoldersIdUpdateParentPost (string id, FolderParentIdForm folderParentIdForm)

Update Folder Parent Id By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **folderParentIdForm** | [**FolderParentIdForm**](FolderParentIdForm.md) |  |  |

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

