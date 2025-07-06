# Org.OpenAPITools.Api.KnowledgeApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddFileToKnowledgeByIdApiV1KnowledgeIdFileAddPost**](KnowledgeApi.md#addfiletoknowledgebyidapiv1knowledgeidfileaddpost) | **POST** /api/v1/knowledge/{id}/file/add | Add File To Knowledge By Id |
| [**AddFilesToKnowledgeBatchApiV1KnowledgeIdFilesBatchAddPost**](KnowledgeApi.md#addfilestoknowledgebatchapiv1knowledgeidfilesbatchaddpost) | **POST** /api/v1/knowledge/{id}/files/batch/add | Add Files To Knowledge Batch |
| [**CreateNewKnowledgeApiV1KnowledgeCreatePost**](KnowledgeApi.md#createnewknowledgeapiv1knowledgecreatepost) | **POST** /api/v1/knowledge/create | Create New Knowledge |
| [**DeleteKnowledgeByIdApiV1KnowledgeIdDeleteDelete**](KnowledgeApi.md#deleteknowledgebyidapiv1knowledgeiddeletedelete) | **DELETE** /api/v1/knowledge/{id}/delete | Delete Knowledge By Id |
| [**GetKnowledgeApiV1KnowledgeGet**](KnowledgeApi.md#getknowledgeapiv1knowledgeget) | **GET** /api/v1/knowledge/ | Get Knowledge |
| [**GetKnowledgeByIdApiV1KnowledgeIdGet**](KnowledgeApi.md#getknowledgebyidapiv1knowledgeidget) | **GET** /api/v1/knowledge/{id} | Get Knowledge By Id |
| [**GetKnowledgeListApiV1KnowledgeListGet**](KnowledgeApi.md#getknowledgelistapiv1knowledgelistget) | **GET** /api/v1/knowledge/list | Get Knowledge List |
| [**ReindexKnowledgeFilesApiV1KnowledgeReindexPost**](KnowledgeApi.md#reindexknowledgefilesapiv1knowledgereindexpost) | **POST** /api/v1/knowledge/reindex | Reindex Knowledge Files |
| [**RemoveFileFromKnowledgeByIdApiV1KnowledgeIdFileRemovePost**](KnowledgeApi.md#removefilefromknowledgebyidapiv1knowledgeidfileremovepost) | **POST** /api/v1/knowledge/{id}/file/remove | Remove File From Knowledge By Id |
| [**ResetKnowledgeByIdApiV1KnowledgeIdResetPost**](KnowledgeApi.md#resetknowledgebyidapiv1knowledgeidresetpost) | **POST** /api/v1/knowledge/{id}/reset | Reset Knowledge By Id |
| [**UpdateFileFromKnowledgeByIdApiV1KnowledgeIdFileUpdatePost**](KnowledgeApi.md#updatefilefromknowledgebyidapiv1knowledgeidfileupdatepost) | **POST** /api/v1/knowledge/{id}/file/update | Update File From Knowledge By Id |
| [**UpdateKnowledgeByIdApiV1KnowledgeIdUpdatePost**](KnowledgeApi.md#updateknowledgebyidapiv1knowledgeidupdatepost) | **POST** /api/v1/knowledge/{id}/update | Update Knowledge By Id |

<a id="addfiletoknowledgebyidapiv1knowledgeidfileaddpost"></a>
# **AddFileToKnowledgeByIdApiV1KnowledgeIdFileAddPost**
> KnowledgeFilesResponse AddFileToKnowledgeByIdApiV1KnowledgeIdFileAddPost (string id, KnowledgeFileIdForm knowledgeFileIdForm)

Add File To Knowledge By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **knowledgeFileIdForm** | [**KnowledgeFileIdForm**](KnowledgeFileIdForm.md) |  |  |

### Return type

[**KnowledgeFilesResponse**](KnowledgeFilesResponse.md)

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

<a id="addfilestoknowledgebatchapiv1knowledgeidfilesbatchaddpost"></a>
# **AddFilesToKnowledgeBatchApiV1KnowledgeIdFilesBatchAddPost**
> KnowledgeFilesResponse AddFilesToKnowledgeBatchApiV1KnowledgeIdFilesBatchAddPost (string id, List<KnowledgeFileIdForm> knowledgeFileIdForm)

Add Files To Knowledge Batch

Add multiple files to a knowledge base


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **knowledgeFileIdForm** | [**List&lt;KnowledgeFileIdForm&gt;**](KnowledgeFileIdForm.md) |  |  |

### Return type

[**KnowledgeFilesResponse**](KnowledgeFilesResponse.md)

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

<a id="createnewknowledgeapiv1knowledgecreatepost"></a>
# **CreateNewKnowledgeApiV1KnowledgeCreatePost**
> KnowledgeResponse CreateNewKnowledgeApiV1KnowledgeCreatePost (KnowledgeForm knowledgeForm)

Create New Knowledge


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **knowledgeForm** | [**KnowledgeForm**](KnowledgeForm.md) |  |  |

### Return type

[**KnowledgeResponse**](KnowledgeResponse.md)

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

<a id="deleteknowledgebyidapiv1knowledgeiddeletedelete"></a>
# **DeleteKnowledgeByIdApiV1KnowledgeIdDeleteDelete**
> bool DeleteKnowledgeByIdApiV1KnowledgeIdDeleteDelete (string id)

Delete Knowledge By Id


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

<a id="getknowledgeapiv1knowledgeget"></a>
# **GetKnowledgeApiV1KnowledgeGet**
> List&lt;KnowledgeUserResponse&gt; GetKnowledgeApiV1KnowledgeGet ()

Get Knowledge


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;KnowledgeUserResponse&gt;**](KnowledgeUserResponse.md)

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

<a id="getknowledgebyidapiv1knowledgeidget"></a>
# **GetKnowledgeByIdApiV1KnowledgeIdGet**
> KnowledgeFilesResponse GetKnowledgeByIdApiV1KnowledgeIdGet (string id)

Get Knowledge By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**KnowledgeFilesResponse**](KnowledgeFilesResponse.md)

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

<a id="getknowledgelistapiv1knowledgelistget"></a>
# **GetKnowledgeListApiV1KnowledgeListGet**
> List&lt;KnowledgeUserResponse&gt; GetKnowledgeListApiV1KnowledgeListGet ()

Get Knowledge List


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;KnowledgeUserResponse&gt;**](KnowledgeUserResponse.md)

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

<a id="reindexknowledgefilesapiv1knowledgereindexpost"></a>
# **ReindexKnowledgeFilesApiV1KnowledgeReindexPost**
> bool ReindexKnowledgeFilesApiV1KnowledgeReindexPost ()

Reindex Knowledge Files


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

<a id="removefilefromknowledgebyidapiv1knowledgeidfileremovepost"></a>
# **RemoveFileFromKnowledgeByIdApiV1KnowledgeIdFileRemovePost**
> KnowledgeFilesResponse RemoveFileFromKnowledgeByIdApiV1KnowledgeIdFileRemovePost (string id, KnowledgeFileIdForm knowledgeFileIdForm)

Remove File From Knowledge By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **knowledgeFileIdForm** | [**KnowledgeFileIdForm**](KnowledgeFileIdForm.md) |  |  |

### Return type

[**KnowledgeFilesResponse**](KnowledgeFilesResponse.md)

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

<a id="resetknowledgebyidapiv1knowledgeidresetpost"></a>
# **ResetKnowledgeByIdApiV1KnowledgeIdResetPost**
> KnowledgeResponse ResetKnowledgeByIdApiV1KnowledgeIdResetPost (string id)

Reset Knowledge By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**KnowledgeResponse**](KnowledgeResponse.md)

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

<a id="updatefilefromknowledgebyidapiv1knowledgeidfileupdatepost"></a>
# **UpdateFileFromKnowledgeByIdApiV1KnowledgeIdFileUpdatePost**
> KnowledgeFilesResponse UpdateFileFromKnowledgeByIdApiV1KnowledgeIdFileUpdatePost (string id, KnowledgeFileIdForm knowledgeFileIdForm)

Update File From Knowledge By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **knowledgeFileIdForm** | [**KnowledgeFileIdForm**](KnowledgeFileIdForm.md) |  |  |

### Return type

[**KnowledgeFilesResponse**](KnowledgeFilesResponse.md)

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

<a id="updateknowledgebyidapiv1knowledgeidupdatepost"></a>
# **UpdateKnowledgeByIdApiV1KnowledgeIdUpdatePost**
> KnowledgeFilesResponse UpdateKnowledgeByIdApiV1KnowledgeIdUpdatePost (string id, KnowledgeForm knowledgeForm)

Update Knowledge By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **knowledgeForm** | [**KnowledgeForm**](KnowledgeForm.md) |  |  |

### Return type

[**KnowledgeFilesResponse**](KnowledgeFilesResponse.md)

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

