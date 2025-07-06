# Org.OpenAPITools.Api.FilesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteAllFilesApiV1FilesAllDelete**](FilesApi.md#deleteallfilesapiv1filesalldelete) | **DELETE** /api/v1/files/all | Delete All Files |
| [**DeleteFileByIdApiV1FilesIdDelete**](FilesApi.md#deletefilebyidapiv1filesiddelete) | **DELETE** /api/v1/files/{id} | Delete File By Id |
| [**GetFileByIdApiV1FilesIdGet**](FilesApi.md#getfilebyidapiv1filesidget) | **GET** /api/v1/files/{id} | Get File By Id |
| [**GetFileContentByIdApiV1FilesIdContentFileNameGet**](FilesApi.md#getfilecontentbyidapiv1filesidcontentfilenameget) | **GET** /api/v1/files/{id}/content/{file_name} | Get File Content By Id |
| [**GetFileContentByIdApiV1FilesIdContentGet**](FilesApi.md#getfilecontentbyidapiv1filesidcontentget) | **GET** /api/v1/files/{id}/content | Get File Content By Id |
| [**GetFileDataContentByIdApiV1FilesIdDataContentGet**](FilesApi.md#getfiledatacontentbyidapiv1filesiddatacontentget) | **GET** /api/v1/files/{id}/data/content | Get File Data Content By Id |
| [**GetHtmlFileContentByIdApiV1FilesIdContentHtmlGet**](FilesApi.md#gethtmlfilecontentbyidapiv1filesidcontenthtmlget) | **GET** /api/v1/files/{id}/content/html | Get Html File Content By Id |
| [**ListFilesApiV1FilesGet**](FilesApi.md#listfilesapiv1filesget) | **GET** /api/v1/files/ | List Files |
| [**SearchFilesApiV1FilesSearchGet**](FilesApi.md#searchfilesapiv1filessearchget) | **GET** /api/v1/files/search | Search Files |
| [**UpdateFileDataContentByIdApiV1FilesIdDataContentUpdatePost**](FilesApi.md#updatefiledatacontentbyidapiv1filesiddatacontentupdatepost) | **POST** /api/v1/files/{id}/data/content/update | Update File Data Content By Id |
| [**UploadFileApiV1FilesPost**](FilesApi.md#uploadfileapiv1filespost) | **POST** /api/v1/files/ | Upload File |

<a id="deleteallfilesapiv1filesalldelete"></a>
# **DeleteAllFilesApiV1FilesAllDelete**
> Object DeleteAllFilesApiV1FilesAllDelete ()

Delete All Files


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

<a id="deletefilebyidapiv1filesiddelete"></a>
# **DeleteFileByIdApiV1FilesIdDelete**
> Object DeleteFileByIdApiV1FilesIdDelete (string id)

Delete File By Id


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

<a id="getfilebyidapiv1filesidget"></a>
# **GetFileByIdApiV1FilesIdGet**
> FileModel GetFileByIdApiV1FilesIdGet (string id)

Get File By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**FileModel**](FileModel.md)

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

<a id="getfilecontentbyidapiv1filesidcontentfilenameget"></a>
# **GetFileContentByIdApiV1FilesIdContentFileNameGet**
> Object GetFileContentByIdApiV1FilesIdContentFileNameGet (string id)

Get File Content By Id


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

<a id="getfilecontentbyidapiv1filesidcontentget"></a>
# **GetFileContentByIdApiV1FilesIdContentGet**
> Object GetFileContentByIdApiV1FilesIdContentGet (string id, bool attachment = null)

Get File Content By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **attachment** | **bool** |  | [optional] [default to false] |

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

<a id="getfiledatacontentbyidapiv1filesiddatacontentget"></a>
# **GetFileDataContentByIdApiV1FilesIdDataContentGet**
> Object GetFileDataContentByIdApiV1FilesIdDataContentGet (string id)

Get File Data Content By Id


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

<a id="gethtmlfilecontentbyidapiv1filesidcontenthtmlget"></a>
# **GetHtmlFileContentByIdApiV1FilesIdContentHtmlGet**
> Object GetHtmlFileContentByIdApiV1FilesIdContentHtmlGet (string id)

Get Html File Content By Id


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

<a id="listfilesapiv1filesget"></a>
# **ListFilesApiV1FilesGet**
> List&lt;FileModelResponse&gt; ListFilesApiV1FilesGet (bool content = null)

List Files


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **content** | **bool** |  | [optional] [default to true] |

### Return type

[**List&lt;FileModelResponse&gt;**](FileModelResponse.md)

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

<a id="searchfilesapiv1filessearchget"></a>
# **SearchFilesApiV1FilesSearchGet**
> List&lt;FileModelResponse&gt; SearchFilesApiV1FilesSearchGet (string filename, bool content = null)

Search Files

Search for files by filename with support for wildcard patterns.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filename** | **string** | Filename pattern to search for. Supports wildcards such as &#39;*.txt&#39; |  |
| **content** | **bool** |  | [optional] [default to true] |

### Return type

[**List&lt;FileModelResponse&gt;**](FileModelResponse.md)

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

<a id="updatefiledatacontentbyidapiv1filesiddatacontentupdatepost"></a>
# **UpdateFileDataContentByIdApiV1FilesIdDataContentUpdatePost**
> Object UpdateFileDataContentByIdApiV1FilesIdDataContentUpdatePost (string id, ContentForm contentForm)

Update File Data Content By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **contentForm** | [**ContentForm**](ContentForm.md) |  |  |

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

<a id="uploadfileapiv1filespost"></a>
# **UploadFileApiV1FilesPost**
> FileModelResponse UploadFileApiV1FilesPost (System.IO.Stream file, bool process = null, bool varInternal = null, Metadata metadata = null)

Upload File


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** |  |  |
| **process** | **bool** |  | [optional] [default to true] |
| **varInternal** | **bool** |  | [optional] [default to false] |
| **metadata** | [**Metadata**](Metadata.md) |  | [optional]  |

### Return type

[**FileModelResponse**](FileModelResponse.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

